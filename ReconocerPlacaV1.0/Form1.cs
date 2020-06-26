using Emgu.CV;
using Emgu.CV.Structure;
using AlprNet;
using AlprNet.Models;
using ReconocerPlacaV1._0.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReconocerPlacaV1._0
{
    public partial class Form1 : Form
    {

        VideoCapture capture;
        Alpr alpr;

        public Form1()
        {
            InitializeComponent();
        }

        public Rectangle boundingRectangle(List<Point> points)
        {
            // Add checks here, if necessary, to make sure that points is not null,
            // and that it contains at least one (or perhaps two?) elements

            var minX = points.Min(p => p.X);
            var minY = points.Min(p => p.Y);
            var maxX = points.Max(p => p.X);
            var maxY = points.Max(p => p.Y);

            return new Rectangle(new Point(minX, minY), new Size(maxX - minX, maxY - minY));
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            var bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }

        public static Bitmap combineImages(List<Image> images)
        {
            //read all images into memory
            Bitmap finalImage = null;

            try
            {
                var width = 0;
                var height = 0;

                foreach (var bmp in images)
                {
                    width += bmp.Width;
                    height = bmp.Height > height ? bmp.Height : height;
                }

                //create a bitmap to hold the combined image
                finalImage = new Bitmap(width, height);

                //get a graphics object from the image so we can draw on it
                using (var g = Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(Color.Black);

                    //go through each image and draw it on the final image
                    var offset = 0;
                    foreach (Bitmap image in images)
                    {
                        g.DrawImage(image,
                                    new Rectangle(offset, 0, image.Width, image.Height));
                        offset += image.Width;
                    }
                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
            finally
            {
                //clean up memory
                foreach (var image in images)
                {
                    image.Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetControls();
            //capture = new VideoCapture(Const._useCamera);
            capture = new VideoCapture(@"C:\ALPR\samples\us-4.jpg");
            Mat m = new Mat();
            capture.Read(m);
            Bitmap img = m.Bitmap;

            using (alpr = new Alpr("us", Const._configFile, Const._runtimeDir, Const._licenceKey))
            {
                alpr.Initialize();

                if (!alpr.IsLoaded())
                {
                    Console.WriteLine("Error initializing OpenALPR");
                    return;
                }

                var results = alpr.Recognize(img);
                
                List<double> plate_confidences = new List<double>();
                double[] arrayPlate_confidences;

                var images = new List<Image>(results.results.Count());
                var i = 1;

                foreach (var result in results.results)
                {
                    List<Point> points = new List<Point>();
                    foreach (Coordinate c in result.coordinates)
                        points.Add(new Point(c.x, c.y));

                    var rect = boundingRectangle(points);
                    var imgPlate = (Image)img;
                    var cropped = cropImage(imgPlate, rect);
                    images.Add(cropped);

                    listBoxPlacaCoincidencias.Items.Add("\t\t-- Plate #" + i++ + " --");
                    
                    foreach (var plate in result.candidates)
                    {
                        listBoxPlacaCoincidencias.Items.Add(string.Format(@"{0} {1}%", plate.plate.PadRight(10), plate.confidence.ToString()));
                        plate_confidences.Add(plate.confidence);
                        arrayPlate_confidences = plate_confidences.ToArray();
                        Array.Sort(arrayPlate_confidences);
                        if (plate.confidence == arrayPlate_confidences[arrayPlate_confidences.Length-1])
                        {
                            listFinalPlate.Items.Add($"Placa {i-1}: {plate.plate}");
                          
                        }
                    }
                    plate_confidences.Clear();
                    arrayPlate_confidences = null;
                }

                if (images.Any())
                {
                    picPlaca.Image = combineImages(images);
                }
            }
        }

        private void ResetControls()
        {
            listBoxPlacaCoincidencias.Items.Clear();
            picPlaca.Image = null;
            listFinalPlate.Items.Clear();
        }
    }
}
