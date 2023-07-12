namespace CompressProgram
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
            this.BtnSelectFiles = new System.Windows.Forms.Button();
            this.ListFiles = new System.Windows.Forms.ListBox();
            this.BtnCompress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSelectFiles
            // 
            this.BtnSelectFiles.Location = new System.Drawing.Point(59, 46);
            this.BtnSelectFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSelectFiles.Name = "BtnSelectFiles";
            this.BtnSelectFiles.Size = new System.Drawing.Size(177, 63);
            this.BtnSelectFiles.TabIndex = 0;
            this.BtnSelectFiles.Text = "Seleccionar archivos";
            this.BtnSelectFiles.UseVisualStyleBackColor = true;
            this.BtnSelectFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListFiles
            // 
            this.ListFiles.FormattingEnabled = true;
            this.ListFiles.ItemHeight = 16;
            this.ListFiles.Location = new System.Drawing.Point(59, 135);
            this.ListFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(795, 228);
            this.ListFiles.TabIndex = 2;
            // 
            // BtnCompress
            // 
            this.BtnCompress.Location = new System.Drawing.Point(292, 46);
            this.BtnCompress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCompress.Name = "BtnCompress";
            this.BtnCompress.Size = new System.Drawing.Size(207, 63);
            this.BtnCompress.TabIndex = 3;
            this.BtnCompress.Text = "Reducir tamaño archivos";
            this.BtnCompress.UseVisualStyleBackColor = true;
            this.BtnCompress.Click += new System.EventHandler(this.BtnCompress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnCompress);
            this.Controls.Add(this.ListFiles);
            this.Controls.Add(this.BtnSelectFiles);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSelectFiles;
        private System.Windows.Forms.ListBox ListFiles;
        private System.Windows.Forms.Button BtnCompress;
    }
}

