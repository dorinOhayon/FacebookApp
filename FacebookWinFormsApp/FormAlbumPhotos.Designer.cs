namespace FacebookWinFormsApp
{
    partial class FormAlbumPhotos
    {
     
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbumPhotos));
            this.LabelPhotos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelPhotos
            // 
            this.LabelPhotos.AutoSize = true;
            this.LabelPhotos.BackColor = System.Drawing.Color.Transparent;
            this.LabelPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPhotos.ForeColor = System.Drawing.Color.White;
            this.LabelPhotos.Location = new System.Drawing.Point(624, 40);
            this.LabelPhotos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPhotos.Name = "LabelPhotos";
            this.LabelPhotos.Size = new System.Drawing.Size(174, 55);
            this.LabelPhotos.TabIndex = 65;
            this.LabelPhotos.Text = "Photos";
            // 
            // FormAlbumPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1448, 1055);
            this.Controls.Add(this.LabelPhotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "FormAlbumPhotos";
            this.Text = "Album Photos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPhotos;
    }
}