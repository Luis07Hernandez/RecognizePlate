using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconocerPlacaV1._0.Clases
{
    /// <summary>
    /// Class containing all the values and paths necessary to function 
    /// </summary>
    /// <value>
    /// _configFile: path where openalpr.conf is located 
    /// _runtimeDir: path where runtime_data folder is located
    /// _licenceKey: It is the key of the ALPR library
    /// _userCameraPlates: Username to connect to the camera
    /// _passwordCameraPlates: Password to connect to the camera
    /// _ipCamerapPlates: IP to connect to to the camera
    /// _portCameraPlates: Port to connect to the camera
    /// _useCamera: Variable that contains the connection string to the camera
    /// </value>
    class Const
    {
        public static string _configFile = @"C:\ALPR\openalpr.conf";
        public static string _runtimeDir = @"C:\ALPR\runtime_data\";
        public static string _licenceKey = @"SEpKS0xNTk3w4ODv6/bl7u3n/uL/+b2+qc71/qWgr6ahoKOtra2vqpmQm5qdk5eXAkESrYGtKyNWgknAqlbvhbwYr9NbwyNoRUwiAHo9A+yswuRyaFxPFHxWTJwId5ueyHoFpp1k4RbuhFaYtVApuRKOECVJmPjTRDUkJZxkEhmWP1qSYs20pHOSYACuilUI";
        public static string _userCameraPlates = "root";
        public static string _passwordCameraPlates = "cima12345*";
        public static string _ipCamerapPlates = "192.168.0.254";
        public static string _portCameraPlates = "5085";
        public static string _useCamera = $"http://{_userCameraPlates}:{_passwordCameraPlates}@{_ipCamerapPlates}:{_portCameraPlates}/axis-cgi/mjpg/video.cgi"; //mjpg/video.cgi"; //Video
    }
}

//HELP VALUES
//----public static string _ipvideocameraplates = $"http://{_userCameraPlates}:{_passwordCameraPlates}@{_ipCamerapPlates}:{_portCameraPlates}/axis-cgi/jpg/image.cgi"; //Image