using System;

namespace FacebookWinFormsApp
{
    partial class FormAlbums
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbums));
            this.LabelAlbums = new System.Windows.Forms.Label();
            this.labelNote1 = new System.Windows.Forms.Label();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelNote2 = new System.Windows.Forms.Label();
            this.labelDateAdded = new System.Windows.Forms.Label();
            this.labelDateAddedText = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhotosFilterCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAlbums
            // 
            this.LabelAlbums.AutoSize = true;
            this.LabelAlbums.BackColor = System.Drawing.Color.Transparent;
            this.LabelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAlbums.ForeColor = System.Drawing.Color.White;
            this.LabelAlbums.Location = new System.Drawing.Point(385, 25);
            this.LabelAlbums.Name = "LabelAlbums";
            this.LabelAlbums.Size = new System.Drawing.Size(137, 40);
            this.LabelAlbums.TabIndex = 64;
            this.LabelAlbums.Text = "Albums";
            // 
            // labelNote1
            // 
            this.labelNote1.AutoSize = true;
            this.labelNote1.BackColor = System.Drawing.Color.Transparent;
            this.labelNote1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote1.Location = new System.Drawing.Point(48, 449);
            this.labelNote1.Name = "labelNote1";
            this.labelNote1.Size = new System.Drawing.Size(350, 22);
            this.labelNote1.TabIndex = 63;
            this.labelNote1.Text = "Note: Click on an album to view it\'s picture";
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAlbum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlbum.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.pictureBoxAlbum.Location = new System.Drawing.Point(503, 93);
            this.pictureBoxAlbum.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(260, 224);
            this.pictureBoxAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbum.TabIndex = 62;
            this.pictureBoxAlbum.TabStop = false;
            this.pictureBoxAlbum.Click += new System.EventHandler(this.pictureBoxAlbum_Click);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 24;
            this.listBoxAlbums.Location = new System.Drawing.Point(28, 93);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(392, 316);
            this.listBoxAlbums.TabIndex = 61;
            // 
            // labelNote2
            // 
            this.labelNote2.AutoSize = true;
            this.labelNote2.BackColor = System.Drawing.Color.Transparent;
            this.labelNote2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote2.Location = new System.Drawing.Point(438, 322);
            this.labelNote2.Name = "labelNote2";
            this.labelNote2.Size = new System.Drawing.Size(428, 22);
            this.labelNote2.TabIndex = 65;
            this.labelNote2.Text = "Note: Click on the album\'s picture to view it\'s photos";
            this.labelNote2.Click += new System.EventHandler(this.labelNote2_Click);
            // 
            // labelDateAdded
            // 
            this.labelDateAdded.AutoSize = true;
            this.labelDateAdded.BackColor = System.Drawing.Color.Transparent;
            this.labelDateAdded.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAdded.ForeColor = System.Drawing.Color.White;
            this.labelDateAdded.Location = new System.Drawing.Point(437, 407);
            this.labelDateAdded.Name = "labelDateAdded";
            this.labelDateAdded.Size = new System.Drawing.Size(148, 27);
            this.labelDateAdded.TabIndex = 79;
            this.labelDateAdded.Text = "Date Added:";
            // 
            // labelDateAddedText
            // 
            this.labelDateAddedText.AutoSize = true;
            this.labelDateAddedText.BackColor = System.Drawing.Color.Transparent;
            this.labelDateAddedText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.labelDateAddedText.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAddedText.ForeColor = System.Drawing.Color.White;
            this.labelDateAddedText.Location = new System.Drawing.Point(589, 407);
            this.labelDateAddedText.Name = "labelDateAddedText";
            this.labelDateAddedText.Size = new System.Drawing.Size(70, 27);
            this.labelDateAddedText.TabIndex = 80;
            this.labelDateAddedText.Text = "None";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(705, 42);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(108, 44);
            this.buttonGoBack.TabIndex = 81;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(809, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 46);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // PhotosFilterCheckBox
            // 
            this.PhotosFilterCheckBox.AutoSize = true;
            this.PhotosFilterCheckBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhotosFilterCheckBox.Location = new System.Drawing.Point(503, 365);
            this.PhotosFilterCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PhotosFilterCheckBox.Name = "PhotosFilterCheckBox";
            this.PhotosFilterCheckBox.Size = new System.Drawing.Size(335, 24);
            this.PhotosFilterCheckBox.TabIndex = 83;
            this.PhotosFilterCheckBox.Text = "Show only the photos that have comments";
            this.PhotosFilterCheckBox.UseVisualStyleBackColor = false;
            this.PhotosFilterCheckBox.CheckedChanged += new System.EventHandler(this.PhotosFilterCheckBox_CheckedChanged);
            // 
            // FormAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 515);
            this.Controls.Add(this.PhotosFilterCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelDateAddedText);
            this.Controls.Add(this.labelDateAdded);
            this.Controls.Add(this.labelNote2);
            this.Controls.Add(this.LabelAlbums);
            this.Controls.Add(this.labelNote1);
            this.Controls.Add(this.pictureBoxAlbum);
            this.Controls.Add(this.listBoxAlbums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormAlbums";
            this.Text = "Albums";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labelNote2_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label LabelAlbums;
        private System.Windows.Forms.Label labelNote1;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelNote2;
        private System.Windows.Forms.Label labelDateAdded;
        private System.Windows.Forms.Label labelDateAddedText;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox PhotosFilterCheckBox;
    }
}