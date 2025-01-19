namespace FacebookWinFormsApp
{
    partial class FormNotAttendEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotAttendEvents));
            this.LabelNotYetConfirmedEvents = new System.Windows.Forms.Label();
            this.listBoxEventsNotYetConfirmed = new System.Windows.Forms.ListBox();
            this.NotAttendEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelStartTimeText = new System.Windows.Forms.Label();
            this.labelEndTimeText = new System.Windows.Forms.Label();
            this.labelLocationText = new System.Windows.Forms.Label();
            this.LabelStartTime = new System.Windows.Forms.Label();
            this.LabelEndTime = new System.Windows.Forms.Label();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.labelClickForLikedPagePicture = new System.Windows.Forms.Label();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NotAttendEventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelNotYetConfirmedEvents
            // 
            this.LabelNotYetConfirmedEvents.AutoSize = true;
            this.LabelNotYetConfirmedEvents.BackColor = System.Drawing.Color.Transparent;
            this.LabelNotYetConfirmedEvents.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotYetConfirmedEvents.ForeColor = System.Drawing.Color.White;
            this.LabelNotYetConfirmedEvents.Location = new System.Drawing.Point(41, 31);
            this.LabelNotYetConfirmedEvents.Name = "LabelNotYetConfirmedEvents";
            this.LabelNotYetConfirmedEvents.Size = new System.Drawing.Size(763, 43);
            this.LabelNotYetConfirmedEvents.TabIndex = 68;
            this.LabelNotYetConfirmedEvents.Text = "Events you have not yet confirmed your arrival";
            this.LabelNotYetConfirmedEvents.Click += new System.EventHandler(this.LabelNotYetConfirmedEvents_Click);
            // 
            // listBoxEventsNotYetConfirmed
            // 
            this.listBoxEventsNotYetConfirmed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEventsNotYetConfirmed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxEventsNotYetConfirmed.DataSource = this.NotAttendEventBindingSource;
            this.listBoxEventsNotYetConfirmed.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEventsNotYetConfirmed.FormattingEnabled = true;
            this.listBoxEventsNotYetConfirmed.ItemHeight = 24;
            this.listBoxEventsNotYetConfirmed.Location = new System.Drawing.Point(36, 100);
            this.listBoxEventsNotYetConfirmed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxEventsNotYetConfirmed.Name = "listBoxEventsNotYetConfirmed";
            this.listBoxEventsNotYetConfirmed.Size = new System.Drawing.Size(499, 340);
            this.listBoxEventsNotYetConfirmed.TabIndex = 65;
            this.listBoxEventsNotYetConfirmed.SelectedIndexChanged += new System.EventHandler(this.listBoxCheckIn_SelectedIndexChanged);
            // 
            // NotAttendEventBindingSource
            // 
            this.NotAttendEventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // labelStartTimeText
            // 
            this.labelStartTimeText.AutoSize = true;
            this.labelStartTimeText.BackColor = System.Drawing.Color.Transparent;
            this.labelStartTimeText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTimeText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStartTimeText.Location = new System.Drawing.Point(563, 376);
            this.labelStartTimeText.Name = "labelStartTimeText";
            this.labelStartTimeText.Size = new System.Drawing.Size(70, 22);
            this.labelStartTimeText.TabIndex = 78;
            this.labelStartTimeText.Text = "Starts:";
            // 
            // labelEndTimeText
            // 
            this.labelEndTimeText.AutoSize = true;
            this.labelEndTimeText.BackColor = System.Drawing.Color.Transparent;
            this.labelEndTimeText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTimeText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEndTimeText.Location = new System.Drawing.Point(563, 396);
            this.labelEndTimeText.Name = "labelEndTimeText";
            this.labelEndTimeText.Size = new System.Drawing.Size(60, 22);
            this.labelEndTimeText.TabIndex = 76;
            this.labelEndTimeText.Text = "Ends:";
            // 
            // labelLocationText
            // 
            this.labelLocationText.AutoSize = true;
            this.labelLocationText.BackColor = System.Drawing.Color.Transparent;
            this.labelLocationText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLocationText.Location = new System.Drawing.Point(563, 418);
            this.labelLocationText.Name = "labelLocationText";
            this.labelLocationText.Size = new System.Drawing.Size(94, 22);
            this.labelLocationText.TabIndex = 75;
            this.labelLocationText.Text = "Location:";
            // 
            // LabelStartTime
            // 
            this.LabelStartTime.AutoSize = true;
            this.LabelStartTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelStartTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelStartTime.Location = new System.Drawing.Point(634, 376);
            this.LabelStartTime.Name = "LabelStartTime";
            this.LabelStartTime.Size = new System.Drawing.Size(58, 22);
            this.LabelStartTime.TabIndex = 74;
            this.LabelStartTime.Text = "None";
            // 
            // LabelEndTime
            // 
            this.LabelEndTime.AutoSize = true;
            this.LabelEndTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelEndTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEndTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelEndTime.Location = new System.Drawing.Point(634, 396);
            this.LabelEndTime.Name = "LabelEndTime";
            this.LabelEndTime.Size = new System.Drawing.Size(58, 22);
            this.LabelEndTime.TabIndex = 73;
            this.LabelEndTime.Text = "None";
            // 
            // LabelLocation
            // 
            this.LabelLocation.AutoSize = true;
            this.LabelLocation.BackColor = System.Drawing.Color.Transparent;
            this.LabelLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLocation.Location = new System.Drawing.Point(654, 418);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(58, 22);
            this.LabelLocation.TabIndex = 71;
            this.LabelLocation.Text = "None";
            // 
            // labelClickForLikedPagePicture
            // 
            this.labelClickForLikedPagePicture.AutoSize = true;
            this.labelClickForLikedPagePicture.BackColor = System.Drawing.Color.Transparent;
            this.labelClickForLikedPagePicture.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClickForLikedPagePicture.Location = new System.Drawing.Point(78, 458);
            this.labelClickForLikedPagePicture.Name = "labelClickForLikedPagePicture";
            this.labelClickForLikedPagePicture.Size = new System.Drawing.Size(382, 22);
            this.labelClickForLikedPagePicture.TabIndex = 67;
            this.labelClickForLikedPagePicture.Text = "Note: Click on an event to view it\'s information";
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEvent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEvent.Location = new System.Drawing.Point(558, 175);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(212, 196);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 79;
            this.pictureBoxEvent.TabStop = false;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(638, 99);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(113, 46);
            this.buttonGoBack.TabIndex = 80;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(747, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 46);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // FormNotAttendEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.labelStartTimeText);
            this.Controls.Add(this.labelEndTimeText);
            this.Controls.Add(this.labelLocationText);
            this.Controls.Add(this.LabelStartTime);
            this.Controls.Add(this.LabelEndTime);
            this.Controls.Add(this.LabelLocation);
            this.Controls.Add(this.LabelNotYetConfirmedEvents);
            this.Controls.Add(this.labelClickForLikedPagePicture);
            this.Controls.Add(this.listBoxEventsNotYetConfirmed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNotAttendEvents";
            this.Text = "Not Attend Events";
            ((System.ComponentModel.ISupportInitialize)(this.NotAttendEventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNotYetConfirmedEvents;
        private System.Windows.Forms.ListBox listBoxEventsNotYetConfirmed;
        private System.Windows.Forms.Label labelStartTimeText;
        private System.Windows.Forms.Label labelEndTimeText;
        private System.Windows.Forms.Label labelLocationText;
        private System.Windows.Forms.Label LabelStartTime;
        private System.Windows.Forms.Label LabelEndTime;
        private System.Windows.Forms.Label LabelLocation;
        private System.Windows.Forms.Label labelClickForLikedPagePicture;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.BindingSource NotAttendEventBindingSource;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}