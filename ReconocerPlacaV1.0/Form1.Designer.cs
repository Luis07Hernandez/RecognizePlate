namespace ReconocerPlacaV1._0
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScan = new System.Windows.Forms.Button();
            this.picPlaca = new System.Windows.Forms.PictureBox();
            this.listBoxPlacaCoincidencias = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listFinalPlate = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(12, 12);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(612, 23);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Escanear";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // picPlaca
            // 
            this.picPlaca.Location = new System.Drawing.Point(351, 54);
            this.picPlaca.Name = "picPlaca";
            this.picPlaca.Size = new System.Drawing.Size(272, 143);
            this.picPlaca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlaca.TabIndex = 1;
            this.picPlaca.TabStop = false;
            // 
            // listBoxPlacaCoincidencias
            // 
            this.listBoxPlacaCoincidencias.FormattingEnabled = true;
            this.listBoxPlacaCoincidencias.Location = new System.Drawing.Point(12, 54);
            this.listBoxPlacaCoincidencias.Name = "listBoxPlacaCoincidencias";
            this.listBoxPlacaCoincidencias.Size = new System.Drawing.Size(305, 147);
            this.listBoxPlacaCoincidencias.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Foto de placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coincidencias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa:";
            // 
            // listFinalPlate
            // 
            this.listFinalPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFinalPlate.FormattingEnabled = true;
            this.listFinalPlate.ItemHeight = 20;
            this.listFinalPlate.Location = new System.Drawing.Point(12, 220);
            this.listFinalPlate.Name = "listFinalPlate";
            this.listFinalPlate.Size = new System.Drawing.Size(411, 84);
            this.listFinalPlate.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 328);
            this.Controls.Add(this.listFinalPlate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxPlacaCoincidencias);
            this.Controls.Add(this.picPlaca);
            this.Controls.Add(this.btnScan);
            this.Name = "Form1";
            this.Text = "LPR DEPOSITO CIMA";
            ((System.ComponentModel.ISupportInitialize)(this.picPlaca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox picPlaca;
        private System.Windows.Forms.ListBox listBoxPlacaCoincidencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listFinalPlate;
    }
}

