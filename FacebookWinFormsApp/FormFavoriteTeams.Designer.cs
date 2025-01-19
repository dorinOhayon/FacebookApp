namespace FacebookWinFormsApp
{
    partial class FormFavoriteTeams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFavoriteTeams));
            this.LabelFavoriteTeams = new System.Windows.Forms.Label();
            this.LabelNote = new System.Windows.Forms.Label();
            this.pictureBoxTeam = new System.Windows.Forms.PictureBox();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.richTextBoxTeamDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelFavoriteTeams
            // 
            this.LabelFavoriteTeams.AutoSize = true;
            this.LabelFavoriteTeams.BackColor = System.Drawing.Color.Transparent;
            this.LabelFavoriteTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFavoriteTeams.ForeColor = System.Drawing.Color.White;
            this.LabelFavoriteTeams.Location = new System.Drawing.Point(282, 41);
            this.LabelFavoriteTeams.Name = "LabelFavoriteTeams";
            this.LabelFavoriteTeams.Size = new System.Drawing.Size(267, 40);
            this.LabelFavoriteTeams.TabIndex = 64;
            this.LabelFavoriteTeams.Text = "Favorite Teams";
            // 
            // LabelNote
            // 
            this.LabelNote.AutoSize = true;
            this.LabelNote.BackColor = System.Drawing.Color.Transparent;
            this.LabelNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNote.Location = new System.Drawing.Point(38, 465);
            this.LabelNote.Name = "LabelNote";
            this.LabelNote.Size = new System.Drawing.Size(368, 22);
            this.LabelNote.TabIndex = 63;
            this.LabelNote.Text = "Note: Click on a team to view it\'s information";
            // 
            // pictureBoxTeam
            // 
            this.pictureBoxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTeam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxTeam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTeam.Location = new System.Drawing.Point(515, 105);
            this.pictureBoxTeam.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxTeam.Name = "pictureBoxTeam";
            this.pictureBoxTeam.Size = new System.Drawing.Size(218, 206);
            this.pictureBoxTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTeam.TabIndex = 62;
            this.pictureBoxTeam.TabStop = false;
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFavoriteTeams.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxFavoriteTeams.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 24;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(42, 105);
            this.listBoxFavoriteTeams.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(436, 340);
            this.listBoxFavoriteTeams.TabIndex = 61;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxTeams_SelectedIndexChanged);
            // 
            // richTextBoxTeamDescription
            // 
            this.richTextBoxTeamDescription.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBoxTeamDescription.Location = new System.Drawing.Point(489, 372);
            this.richTextBoxTeamDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBoxTeamDescription.Name = "richTextBoxTeamDescription";
            this.richTextBoxTeamDescription.Size = new System.Drawing.Size(327, 115);
            this.richTextBoxTeamDescription.TabIndex = 65;
            this.richTextBoxTeamDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point(485, 334);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(120, 22);
            this.labelDescription.TabIndex = 66;
            this.labelDescription.Text = "Description:";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(674, 24);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(94, 49);
            this.buttonGoBack.TabIndex = 67;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(764, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // FormFavoriteTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(852, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxTeamDescription);
            this.Controls.Add(this.LabelFavoriteTeams);
            this.Controls.Add(this.LabelNote);
            this.Controls.Add(this.pictureBoxTeam);
            this.Controls.Add(this.listBoxFavoriteTeams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormFavoriteTeams";
            this.Text = "Favorite Teams";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFavoriteTeams;
        private System.Windows.Forms.Label LabelNote;
        private System.Windows.Forms.PictureBox pictureBoxTeam;
        private System.Windows.Forms.ListBox listBoxFavoriteTeams;
        private System.Windows.Forms.RichTextBox richTextBoxTeamDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}