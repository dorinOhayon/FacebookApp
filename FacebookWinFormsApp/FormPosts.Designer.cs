namespace FacebookWinFormsApp
{
    partial class FormPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPosts));
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.textBoxPosts = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.LabelPosts = new System.Windows.Forms.Label();
            this.buttonAddPost = new System.Windows.Forms.Button();
            this.pictureBoxPost = new System.Windows.Forms.PictureBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(36, 140);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(562, 144);
            this.listBoxPosts.TabIndex = 2;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 20;
            this.listBoxPostComments.Location = new System.Drawing.Point(36, 339);
            this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(750, 144);
            this.listBoxPostComments.TabIndex = 3;
            // 
            // textBoxPosts
            // 
            this.textBoxPosts.Location = new System.Drawing.Point(159, 94);
            this.textBoxPosts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPosts.Name = "textBoxPosts";
            this.textBoxPosts.Size = new System.Drawing.Size(439, 26);
            this.textBoxPosts.TabIndex = 4;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.BackColor = System.Drawing.Color.Transparent;
            this.labelPost.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPost.Location = new System.Drawing.Point(32, 94);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(126, 28);
            this.labelPost.TabIndex = 7;
            this.labelPost.Text = "new post:";
            // 
            // LabelPosts
            // 
            this.LabelPosts.AutoSize = true;
            this.LabelPosts.BackColor = System.Drawing.Color.Transparent;
            this.LabelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPosts.ForeColor = System.Drawing.Color.White;
            this.LabelPosts.Location = new System.Drawing.Point(346, 25);
            this.LabelPosts.Name = "LabelPosts";
            this.LabelPosts.Size = new System.Drawing.Size(107, 40);
            this.LabelPosts.TabIndex = 61;
            this.LabelPosts.Text = "Posts";
            // 
            // buttonAddPost
            // 
            this.buttonAddPost.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAddPost.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddPost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPost.Location = new System.Drawing.Point(611, 89);
            this.buttonAddPost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddPost.Name = "buttonAddPost";
            this.buttonAddPost.Size = new System.Drawing.Size(177, 35);
            this.buttonAddPost.TabIndex = 62;
            this.buttonAddPost.Text = "Add Post";
            this.buttonAddPost.UseVisualStyleBackColor = false;
            this.buttonAddPost.Click += new System.EventHandler(this.buttonAddPost_Click);
            // 
            // pictureBoxPost
            // 
            this.pictureBoxPost.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPost.Location = new System.Drawing.Point(611, 141);
            this.pictureBoxPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPost.Name = "pictureBoxPost";
            this.pictureBoxPost.Size = new System.Drawing.Size(177, 145);
            this.pictureBoxPost.TabIndex = 63;
            this.pictureBoxPost.TabStop = false;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.BackColor = System.Drawing.Color.Transparent;
            this.labelNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.Location = new System.Drawing.Point(32, 289);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(354, 22);
            this.labelNote.TabIndex = 66;
            this.labelNote.Text = "Note: Click on a post to view it\'s comments";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(656, 25);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(107, 47);
            this.buttonGoBack.TabIndex = 67;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(754, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // FormPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.pictureBoxPost);
            this.Controls.Add(this.buttonAddPost);
            this.Controls.Add(this.LabelPosts);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxPosts);
            this.Controls.Add(this.listBoxPostComments);
            this.Controls.Add(this.listBoxPosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormPosts";
            this.Text = "Posts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.TextBox textBoxPosts;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label LabelPosts;
        private System.Windows.Forms.Button buttonAddPost;
        private System.Windows.Forms.PictureBox pictureBoxPost;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}