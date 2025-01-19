namespace FacebookWinFormsApp
{
    partial class FormFriends
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriends));
            this.LabelFriends = new System.Windows.Forms.Label();
            this.LabelNote = new System.Windows.Forms.Label();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelFriends
            // 
            this.LabelFriends.AutoSize = true;
            this.LabelFriends.BackColor = System.Drawing.Color.Transparent;
            this.LabelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFriends.ForeColor = System.Drawing.Color.White;
            this.LabelFriends.Location = new System.Drawing.Point(350, 33);
            this.LabelFriends.Name = "LabelFriends";
            this.LabelFriends.Size = new System.Drawing.Size(137, 40);
            this.LabelFriends.TabIndex = 64;
            this.LabelFriends.Text = "Friends";
            // 
            // LabelNote
            // 
            this.LabelNote.AutoSize = true;
            this.LabelNote.BackColor = System.Drawing.Color.Transparent;
            this.LabelNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNote.Location = new System.Drawing.Point(28, 448);
            this.LabelNote.Name = "LabelNote";
            this.LabelNote.Size = new System.Drawing.Size(337, 22);
            this.LabelNote.TabIndex = 63;
            this.LabelNote.Text = "Note: Click on a friend to view it\'s picture";
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFriend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFriend.Location = new System.Drawing.Point(503, 112);
            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(212, 224);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 62;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFriends.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 24;
            this.listBoxFriends.Location = new System.Drawing.Point(32, 112);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(436, 316);
            this.listBoxFriends.TabIndex = 61;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.FormattingEnabled = true;
            this.sortByComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortByComboBox.Location = new System.Drawing.Point(150, 76);
            this.sortByComboBox.Name = "sortByComboBox";
            this.sortByComboBox.Size = new System.Drawing.Size(144, 28);
            this.sortByComboBox.TabIndex = 65;
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.sortByComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Sort friends by:";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(676, 49);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(91, 50);
            this.buttonGoBack.TabIndex = 67;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(762, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.LabelFriends);
            this.Controls.Add(this.LabelNote);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.listBoxFriends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormFriends";
            this.Text = "Friends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFriends;
        private System.Windows.Forms.Label LabelNote;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ComboBox sortByComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


//namespace FacebookWinFormsApp
//{
//    partial class FormFriends
//    {
//        private System.ComponentModel.IContainer components = null;

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriends));
//            this.LabelFriends = new System.Windows.Forms.Label();
//            this.LabelNote = new System.Windows.Forms.Label();
//            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
//            this.listBoxFriends = new System.Windows.Forms.ListBox();
//            this.friendListBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
//            this.SuspendLayout();

//            // pictureBoxFriend

//            this.pictureBoxFriend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//            | System.Windows.Forms.AnchorStyles.Left)
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.pictureBoxFriend.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.membersBindingSource, "ImageNormal", true));
//            this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.pictureBoxFriend.Location = new System.Drawing.Point(503, 112);
//            this.pictureBoxFriend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
//            this.pictureBoxFriend.Name = "pictureBoxFriend";
//            this.pictureBoxFriend.Size = new System.Drawing.Size(212, 224);
//            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pictureBoxFriend.TabIndex = 62;
//            this.pictureBoxFriend.TabStop = false;

//            // LabelFriends

//            this.LabelFriends.AutoSize = true;
//            this.LabelFriends.BackColor = System.Drawing.Color.Transparent;
//            this.LabelFriends.Font = new System.Drawing.Font("Verdana Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.LabelFriends.ForeColor = System.Drawing.Color.White;
//            this.LabelFriends.Location = new System.Drawing.Point(350, 33);
//            this.LabelFriends.Name = "LabelFriends";
//            this.LabelFriends.Size = new System.Drawing.Size(134, 40);
//            this.LabelFriends.TabIndex = 64;
//            this.LabelFriends.Text = "Friends";

//            // LabelNote

//            this.LabelNote.AutoSize = true;
//            this.LabelNote.BackColor = System.Drawing.Color.Transparent;
//            this.LabelNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.LabelNote.Location = new System.Drawing.Point(28, 448);
//            this.LabelNote.Name = "LabelNote";
//            this.LabelNote.Size = new System.Drawing.Size(334, 22);
//            this.LabelNote.TabIndex = 63;
//            this.LabelNote.Text = "Note: Click on a friend to view it\'s picture";

//            // listBoxFriends

//            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left)));
//            this.listBoxFriends.DataSource = this.friendListBindingSource;
//            this.listBoxFriends.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.listBoxFriends.FormattingEnabled = true;
//            this.listBoxFriends.ItemHeight = 25;
//            this.listBoxFriends.Location = new System.Drawing.Point(32, 112);
//            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
//            this.listBoxFriends.Name = "listBoxFriends";
//            this.listBoxFriends.Size = new System.Drawing.Size(436, 329);
//            this.listBoxFriends.TabIndex = 61;

//            // membersBindingSource 
//            this.membersBindingSource.DataMember = "Members";
//            this.membersBindingSource.DataSource = this.friendListBindingSource;

//            // friendListBindingSource
//            this.friendListBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.FriendList);

//            // FormFriends
//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
//            this.ClientSize = new System.Drawing.Size(846, 515);
//            this.Controls.Add(this.LabelFriends);
//            this.Controls.Add(this.LabelNote);
//            this.Controls.Add(this.pictureBoxFriend);
//            this.Controls.Add(this.listBoxFriends);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
//            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
//            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.MaximizeBox = false;
//            this.Name = "FormFriends";
//            this.Text = "Friends";
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.friendListBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();
//        }

//        #endregion

//        private System.Windows.Forms.Label LabelFriends;
//        private System.Windows.Forms.Label LabelNote;
//        private System.Windows.Forms.PictureBox pictureBoxFriend;
//        private System.Windows.Forms.ListBox listBoxFriends;
//        private System.Windows.Forms.BindingSource membersBindingSource;
//        private System.Windows.Forms.BindingSource friendListBindingSource;
//    }
//}