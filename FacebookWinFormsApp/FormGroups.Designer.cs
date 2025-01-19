namespace FacebookWinFormsApp
{
    partial class FormGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroups));
            this.LabelGroups = new System.Windows.Forms.Label();
            this.labelClickForLikedPagePicture = new System.Windows.Forms.Label();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxGroupDescription = new System.Windows.Forms.RichTextBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelGroups
            // 
            this.LabelGroups.AutoSize = true;
            this.LabelGroups.BackColor = System.Drawing.Color.Transparent;
            this.LabelGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGroups.ForeColor = System.Drawing.Color.White;
            this.LabelGroups.Location = new System.Drawing.Point(351, 23);
            this.LabelGroups.Name = "LabelGroups";
            this.LabelGroups.Size = new System.Drawing.Size(135, 40);
            this.LabelGroups.TabIndex = 64;
            this.LabelGroups.Text = "Groups";
            this.LabelGroups.UseMnemonic = false;
            // 
            // labelClickForLikedPagePicture
            // 
            this.labelClickForLikedPagePicture.AutoSize = true;
            this.labelClickForLikedPagePicture.BackColor = System.Drawing.Color.Transparent;
            this.labelClickForLikedPagePicture.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickForLikedPagePicture.Location = new System.Drawing.Point(33, 468);
            this.labelClickForLikedPagePicture.Name = "labelClickForLikedPagePicture";
            this.labelClickForLikedPagePicture.Size = new System.Drawing.Size(375, 22);
            this.labelClickForLikedPagePicture.TabIndex = 63;
            this.labelClickForLikedPagePicture.Text = "Note: Click on a group to view it\'s information";
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxGroup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGroup.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.groupBindingSource, "ImageNormal", true));
            this.pictureBoxGroup.Location = new System.Drawing.Point(529, 108);
            this.pictureBoxGroup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(212, 207);
            this.pictureBoxGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGroup.TabIndex = 62;
            this.pictureBoxGroup.TabStop = false;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Group);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxGroups.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxGroups.DataSource = this.groupBindingSource;
            this.listBoxGroups.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 24;
            this.listBoxGroups.Location = new System.Drawing.Point(36, 108);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(436, 340);
            this.listBoxGroups.TabIndex = 61;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(479, 314);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 22);
            this.labelDescription.TabIndex = 68;
            this.labelDescription.Text = "Description:";
            // 
            // richTextBoxGroupDescription
            // 
            this.richTextBoxGroupDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxGroupDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupBindingSource, "Description", true));
            this.richTextBoxGroupDescription.Location = new System.Drawing.Point(483, 342);
            this.richTextBoxGroupDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxGroupDescription.Name = "richTextBoxGroupDescription";
            this.richTextBoxGroupDescription.Size = new System.Drawing.Size(335, 119);
            this.richTextBoxGroupDescription.TabIndex = 67;
            this.richTextBoxGroupDescription.Text = "";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(664, 33);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(110, 48);
            this.buttonGoBack.TabIndex = 69;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(767, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxGroupDescription);
            this.Controls.Add(this.LabelGroups);
            this.Controls.Add(this.labelClickForLikedPagePicture);
            this.Controls.Add(this.pictureBoxGroup);
            this.Controls.Add(this.listBoxGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormGroups";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGroups;
        private System.Windows.Forms.Label labelClickForLikedPagePicture;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxGroupDescription;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}