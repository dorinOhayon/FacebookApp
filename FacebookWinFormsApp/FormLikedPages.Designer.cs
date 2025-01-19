namespace FacebookWinFormsApp
{
    partial class FormLikedPages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLikedPages));
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.labelClickForLikedPagePicture = new System.Windows.Forms.Label();
            this.LabelLikedPages = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxPagesDescription = new System.Windows.Forms.RichTextBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 24;
            this.listBoxLikedPages.Location = new System.Drawing.Point(32, 114);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(436, 340);
            this.listBoxLikedPages.TabIndex = 50;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.pictureBoxPage.Location = new System.Drawing.Point(506, 114);
            this.pictureBoxPage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(212, 201);
            this.pictureBoxPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPage.TabIndex = 51;
            this.pictureBoxPage.TabStop = false;
            // 
            // labelClickForLikedPagePicture
            // 
            this.labelClickForLikedPagePicture.AutoSize = true;
            this.labelClickForLikedPagePicture.BackColor = System.Drawing.Color.Transparent;
            this.labelClickForLikedPagePicture.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickForLikedPagePicture.Location = new System.Drawing.Point(28, 474);
            this.labelClickForLikedPagePicture.Name = "labelClickForLikedPagePicture";
            this.labelClickForLikedPagePicture.Size = new System.Drawing.Size(367, 22);
            this.labelClickForLikedPagePicture.TabIndex = 53;
            this.labelClickForLikedPagePicture.Text = "Note: Click on a page to view it\'s information";
            // 
            // LabelLikedPages
            // 
            this.LabelLikedPages.AutoSize = true;
            this.LabelLikedPages.BackColor = System.Drawing.Color.Transparent;
            this.LabelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLikedPages.ForeColor = System.Drawing.Color.White;
            this.LabelLikedPages.Location = new System.Drawing.Point(290, 26);
            this.LabelLikedPages.Name = "LabelLikedPages";
            this.LabelLikedPages.Size = new System.Drawing.Size(215, 40);
            this.LabelLikedPages.TabIndex = 60;
            this.LabelLikedPages.Text = "Liked Pages";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(477, 321);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 22);
            this.labelDescription.TabIndex = 70;
            this.labelDescription.Text = "Description:";
            // 
            // richTextBoxPagesDescription
            // 
            this.richTextBoxPagesDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxPagesDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.richTextBoxPagesDescription.Location = new System.Drawing.Point(480, 348);
            this.richTextBoxPagesDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxPagesDescription.Name = "richTextBoxPagesDescription";
            this.richTextBoxPagesDescription.Size = new System.Drawing.Size(327, 119);
            this.richTextBoxPagesDescription.TabIndex = 69;
            this.richTextBoxPagesDescription.Text = "";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(658, 43);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(101, 51);
            this.buttonGoBack.TabIndex = 71;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(755, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // FormLikedPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxPagesDescription);
            this.Controls.Add(this.LabelLikedPages);
            this.Controls.Add(this.labelClickForLikedPagePicture);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.listBoxLikedPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormLikedPages";
            this.Text = "Liked Pages";
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.Label labelClickForLikedPagePicture;
        private System.Windows.Forms.Label LabelLikedPages;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxPagesDescription;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}