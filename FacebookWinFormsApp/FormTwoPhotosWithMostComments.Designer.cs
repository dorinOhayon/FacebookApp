namespace FacebookWinFormsApp
{
    partial class FormTwoPhotosWithMostComments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTwoPhotosWithMostComments));
            this.PictureBoxTopFirst = new System.Windows.Forms.PictureBox();
            this.pictureBoxTopSecond = new System.Windows.Forms.PictureBox();
            this.LabelTopTwoPhotos = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.listBoxPhotoComments = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTopFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxTopFirst
            // 
            this.PictureBoxTopFirst.Location = new System.Drawing.Point(531, 333);
            this.PictureBoxTopFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBoxTopFirst.Name = "PictureBoxTopFirst";
            this.PictureBoxTopFirst.Size = new System.Drawing.Size(219, 239);
            this.PictureBoxTopFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTopFirst.TabIndex = 43;
            this.PictureBoxTopFirst.TabStop = false;
            this.PictureBoxTopFirst.Click += new System.EventHandler(this.pictureBoxTopFirst_Click);
            // 
            // pictureBoxTopSecond
            // 
            this.pictureBoxTopSecond.Location = new System.Drawing.Point(129, 331);
            this.pictureBoxTopSecond.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxTopSecond.Name = "pictureBoxTopSecond";
            this.pictureBoxTopSecond.Size = new System.Drawing.Size(220, 239);
            this.pictureBoxTopSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTopSecond.TabIndex = 45;
            this.pictureBoxTopSecond.TabStop = false;
            this.pictureBoxTopSecond.Click += new System.EventHandler(this.pictureBoxTopSecond_Click);
            // 
            // LabelTopTwoPhotos
            // 
            this.LabelTopTwoPhotos.AutoSize = true;
            this.LabelTopTwoPhotos.BackColor = System.Drawing.Color.Transparent;
            this.LabelTopTwoPhotos.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTopTwoPhotos.ForeColor = System.Drawing.Color.White;
            this.LabelTopTwoPhotos.Location = new System.Drawing.Point(56, 96);
            this.LabelTopTwoPhotos.Name = "LabelTopTwoPhotos";
            this.LabelTopTwoPhotos.Size = new System.Drawing.Size(744, 36);
            this.LabelTopTwoPhotos.TabIndex = 65;
            this.LabelTopTwoPhotos.Text = "Top Two Photos with the highest number of comments";
            this.LabelTopTwoPhotos.Click += new System.EventHandler(this.LabelTopTwoPhotos_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(249, 575);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(366, 22);
            this.label.TabIndex = 70;
            this.label.Text = "Note: Click on a photo to view it\'s comments";
            // 
            // listBoxPhotoComments
            // 
            this.listBoxPhotoComments.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxPhotoComments.FormattingEnabled = true;
            this.listBoxPhotoComments.ItemHeight = 20;
            this.listBoxPhotoComments.Location = new System.Drawing.Point(75, 616);
            this.listBoxPhotoComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPhotoComments.Name = "listBoxPhotoComments";
            this.listBoxPhotoComments.Size = new System.Drawing.Size(751, 84);
            this.listBoxPhotoComments.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 190);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(558, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 190);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(663, 37);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(109, 56);
            this.buttonGoBack.TabIndex = 77;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox3.Location = new System.Drawing.Point(767, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 56);
            this.pictureBox3.TabIndex = 78;
            this.pictureBox3.TabStop = false;
            // 
            // FormTwoPhotosWithMostComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 728);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxPhotoComments);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PictureBoxTopFirst);
            this.Controls.Add(this.LabelTopTwoPhotos);
            this.Controls.Add(this.pictureBoxTopSecond);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTwoPhotosWithMostComments";
            this.Text = "Top Two Photos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTopFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxTopFirst;
        private System.Windows.Forms.PictureBox pictureBoxTopSecond;
        private System.Windows.Forms.Label LabelTopTwoPhotos;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox listBoxPhotoComments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}