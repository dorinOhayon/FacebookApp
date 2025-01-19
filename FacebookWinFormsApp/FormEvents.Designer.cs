namespace FacebookWinFormsApp
{
    partial class FormEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEvents));
            this.LabelLikedPages = new System.Windows.Forms.Label();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelChosenEnd = new System.Windows.Forms.Label();
            this.labelChosenStart = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.LabelNote = new System.Windows.Forms.Label();
            this.labelStartTimeText = new System.Windows.Forms.Label();
            this.labelEndTimeText = new System.Windows.Forms.Label();
            this.labelLocationText = new System.Windows.Forms.Label();
            this.LabelStartTime = new System.Windows.Forms.Label();
            this.LabelEndTime = new System.Windows.Forms.Label();
            this.LabelLocation = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLikedPages
            // 
            this.LabelLikedPages.AutoSize = true;
            this.LabelLikedPages.BackColor = System.Drawing.Color.Transparent;
            this.LabelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLikedPages.ForeColor = System.Drawing.Color.White;
            this.LabelLikedPages.Location = new System.Drawing.Point(363, 23);
            this.LabelLikedPages.Name = "LabelLikedPages";
            this.LabelLikedPages.Size = new System.Drawing.Size(127, 40);
            this.LabelLikedPages.TabIndex = 64;
            this.LabelLikedPages.Text = "Events";
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEvent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEvent.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.pictureBoxEvent.Location = new System.Drawing.Point(558, 185);
            this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(212, 163);
            this.pictureBoxEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEvent.TabIndex = 62;
            this.pictureBoxEvent.TabStop = false;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxEvents.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 24;
            this.listBoxEvents.Location = new System.Drawing.Point(33, 185);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(505, 268);
            this.listBoxEvents.TabIndex = 61;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(571, 121);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 40);
            this.buttonSearch.TabIndex = 88;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelChosenEnd
            // 
            this.labelChosenEnd.AutoSize = true;
            this.labelChosenEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelChosenEnd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChosenEnd.ForeColor = System.Drawing.Color.White;
            this.labelChosenEnd.Location = new System.Drawing.Point(159, 132);
            this.labelChosenEnd.Name = "labelChosenEnd";
            this.labelChosenEnd.Size = new System.Drawing.Size(75, 28);
            this.labelChosenEnd.TabIndex = 87;
            this.labelChosenEnd.Text = "Ends:";
            // 
            // labelChosenStart
            // 
            this.labelChosenStart.AutoSize = true;
            this.labelChosenStart.BackColor = System.Drawing.Color.Transparent;
            this.labelChosenStart.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChosenStart.ForeColor = System.Drawing.Color.White;
            this.labelChosenStart.Location = new System.Drawing.Point(159, 92);
            this.labelChosenStart.Name = "labelChosenStart";
            this.labelChosenStart.Size = new System.Drawing.Size(91, 28);
            this.labelChosenStart.TabIndex = 86;
            this.labelChosenStart.Text = "Starts:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(243, 89);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(295, 26);
            this.dateTimePickerStart.TabIndex = 85;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(243, 129);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(295, 26);
            this.dateTimePickerEnd.TabIndex = 84;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // LabelNote
            // 
            this.LabelNote.AutoSize = true;
            this.LabelNote.BackColor = System.Drawing.Color.Transparent;
            this.LabelNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNote.Location = new System.Drawing.Point(86, 471);
            this.LabelNote.Name = "LabelNote";
            this.LabelNote.Size = new System.Drawing.Size(382, 22);
            this.LabelNote.TabIndex = 89;
            this.LabelNote.Text = "Note: Click on an event to view it\'s information";
            // 
            // labelStartTimeText
            // 
            this.labelStartTimeText.AutoSize = true;
            this.labelStartTimeText.BackColor = System.Drawing.Color.Transparent;
            this.labelStartTimeText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTimeText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelStartTimeText.Location = new System.Drawing.Point(555, 371);
            this.labelStartTimeText.Name = "labelStartTimeText";
            this.labelStartTimeText.Size = new System.Drawing.Size(70, 22);
            this.labelStartTimeText.TabIndex = 95;
            this.labelStartTimeText.Text = "Starts:";
            // 
            // labelEndTimeText
            // 
            this.labelEndTimeText.AutoSize = true;
            this.labelEndTimeText.BackColor = System.Drawing.Color.Transparent;
            this.labelEndTimeText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTimeText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelEndTimeText.Location = new System.Drawing.Point(555, 405);
            this.labelEndTimeText.Name = "labelEndTimeText";
            this.labelEndTimeText.Size = new System.Drawing.Size(60, 22);
            this.labelEndTimeText.TabIndex = 94;
            this.labelEndTimeText.Text = "Ends:";
            // 
            // labelLocationText
            // 
            this.labelLocationText.AutoSize = true;
            this.labelLocationText.BackColor = System.Drawing.Color.Transparent;
            this.labelLocationText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocationText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLocationText.Location = new System.Drawing.Point(555, 439);
            this.labelLocationText.Name = "labelLocationText";
            this.labelLocationText.Size = new System.Drawing.Size(94, 22);
            this.labelLocationText.TabIndex = 93;
            this.labelLocationText.Text = "Location:";
            // 
            // LabelStartTime
            // 
            this.LabelStartTime.AutoSize = true;
            this.LabelStartTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelStartTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "StartTime", true));
            this.LabelStartTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStartTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelStartTime.Location = new System.Drawing.Point(626, 371);
            this.LabelStartTime.Name = "LabelStartTime";
            this.LabelStartTime.Size = new System.Drawing.Size(58, 22);
            this.LabelStartTime.TabIndex = 92;
            this.LabelStartTime.Text = "None";
            // 
            // LabelEndTime
            // 
            this.LabelEndTime.AutoSize = true;
            this.LabelEndTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelEndTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "EndTime", true));
            this.LabelEndTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEndTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelEndTime.Location = new System.Drawing.Point(626, 405);
            this.LabelEndTime.Name = "LabelEndTime";
            this.LabelEndTime.Size = new System.Drawing.Size(58, 22);
            this.LabelEndTime.TabIndex = 91;
            this.LabelEndTime.Text = "None";
            // 
            // LabelLocation
            // 
            this.LabelLocation.AutoSize = true;
            this.LabelLocation.BackColor = System.Drawing.Color.Transparent;
            this.LabelLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.LabelLocation.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelLocation.Location = new System.Drawing.Point(652, 439);
            this.LabelLocation.Name = "LabelLocation";
            this.LabelLocation.Size = new System.Drawing.Size(58, 22);
            this.LabelLocation.TabIndex = 90;
            this.LabelLocation.Text = "None";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(656, 32);
            this.buttonGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(114, 52);
            this.buttonGoBack.TabIndex = 96;
            this.buttonGoBack.Text = "Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::FacebookWinFormsApp.Properties.Resources.go_back__1_;
            this.pictureBox1.Location = new System.Drawing.Point(760, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 52);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.labelStartTimeText);
            this.Controls.Add(this.labelEndTimeText);
            this.Controls.Add(this.labelLocationText);
            this.Controls.Add(this.LabelStartTime);
            this.Controls.Add(this.LabelEndTime);
            this.Controls.Add(this.LabelLocation);
            this.Controls.Add(this.LabelNote);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelChosenEnd);
            this.Controls.Add(this.labelChosenStart);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.LabelLikedPages);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.listBoxEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormEvents";
            this.Text = "Events";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelChosenEnd;
        private System.Windows.Forms.Label labelChosenStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label LabelNote;
        private System.Windows.Forms.Label labelStartTimeText;
        private System.Windows.Forms.Label labelEndTimeText;
        private System.Windows.Forms.Label labelLocationText;
        private System.Windows.Forms.Label LabelStartTime;
        private System.Windows.Forms.Label LabelEndTime;
        private System.Windows.Forms.Label LabelLocation;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}