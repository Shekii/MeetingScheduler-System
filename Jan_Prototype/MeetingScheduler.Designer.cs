namespace Jan_Prototype
{
    partial class MeetingScheduler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingScheduler));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkImportant = new System.Windows.Forms.CheckBox();
            this.listParticipants = new System.Windows.Forms.ListBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.listRooms = new System.Windows.Forms.ComboBox();
            this.timePickerTo = new System.Windows.Forms.DateTimePicker();
            this.timePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.btnRequestMeeting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataRequests = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCancelMeeting = new System.Windows.Forms.Button();
            this.dataSchedule = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSeeCancelled = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRequests)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(18, 628);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(135, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back, ";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(16, 660);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkImportant);
            this.groupBox1.Controls.Add(this.listParticipants);
            this.groupBox1.Controls.Add(this.lblRooms);
            this.groupBox1.Controls.Add(this.listRooms);
            this.groupBox1.Controls.Add(this.timePickerTo);
            this.groupBox1.Controls.Add(this.timePickerFrom);
            this.groupBox1.Controls.Add(this.btnRequestMeeting);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.txtComments);
            this.groupBox1.Controls.Add(this.lblDesc);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 590);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Meeting";
            // 
            // chkImportant
            // 
            this.chkImportant.AutoSize = true;
            this.chkImportant.Location = new System.Drawing.Point(6, 476);
            this.chkImportant.Name = "chkImportant";
            this.chkImportant.Size = new System.Drawing.Size(151, 17);
            this.chkImportant.TabIndex = 14;
            this.chkImportant.Text = "Is This Meeting Important?";
            this.chkImportant.UseVisualStyleBackColor = true;
            // 
            // listParticipants
            // 
            this.listParticipants.FormattingEnabled = true;
            this.listParticipants.Location = new System.Drawing.Point(88, 340);
            this.listParticipants.Name = "listParticipants";
            this.listParticipants.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listParticipants.Size = new System.Drawing.Size(117, 121);
            this.listParticipants.TabIndex = 13;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Location = new System.Drawing.Point(14, 525);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(48, 13);
            this.lblRooms.TabIndex = 12;
            this.lblRooms.Text = "Location";
            // 
            // listRooms
            // 
            this.listRooms.FormattingEnabled = true;
            this.listRooms.Location = new System.Drawing.Point(72, 517);
            this.listRooms.Name = "listRooms";
            this.listRooms.Size = new System.Drawing.Size(121, 21);
            this.listRooms.TabIndex = 11;
            // 
            // timePickerTo
            // 
            this.timePickerTo.Location = new System.Drawing.Point(77, 272);
            this.timePickerTo.Name = "timePickerTo";
            this.timePickerTo.Size = new System.Drawing.Size(132, 20);
            this.timePickerTo.TabIndex = 10;
            this.timePickerTo.Value = new System.DateTime(2017, 1, 22, 10, 0, 0, 0);
            // 
            // timePickerFrom
            // 
            this.timePickerFrom.Location = new System.Drawing.Point(74, 242);
            this.timePickerFrom.Name = "timePickerFrom";
            this.timePickerFrom.Size = new System.Drawing.Size(132, 20);
            this.timePickerFrom.TabIndex = 9;
            this.timePickerFrom.Value = new System.DateTime(2017, 1, 22, 9, 0, 0, 0);
            // 
            // btnRequestMeeting
            // 
            this.btnRequestMeeting.Location = new System.Drawing.Point(9, 557);
            this.btnRequestMeeting.Name = "btnRequestMeeting";
            this.btnRequestMeeting.Size = new System.Drawing.Size(197, 23);
            this.btnRequestMeeting.TabIndex = 8;
            this.btnRequestMeeting.Text = "Request Meeting";
            this.btnRequestMeeting.UseVisualStyleBackColor = true;
            this.btnRequestMeeting.Click += new System.EventHandler(this.btnRequestMeeting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Required Participants";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 248);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(9, 171);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 4;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(80, 73);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(129, 41);
            this.txtComments.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 96);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(56, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Comments";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataRequests);
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 298);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Meeting Requests (Pending Meetings)";
            // 
            // dataRequests
            // 
            this.dataRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRequests.Location = new System.Drawing.Point(3, 16);
            this.dataRequests.Name = "dataRequests";
            this.dataRequests.Size = new System.Drawing.Size(772, 276);
            this.dataRequests.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnCancelMeeting);
            this.groupBox3.Controls.Add(this.dataSchedule);
            this.groupBox3.Location = new System.Drawing.Point(520, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 293);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Meeting Schedule (Accepted by all participants)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Double Click On A Meeting For The Attendees.";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit Meeting";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCancelMeeting
            // 
            this.btnCancelMeeting.Location = new System.Drawing.Point(19, 264);
            this.btnCancelMeeting.Name = "btnCancelMeeting";
            this.btnCancelMeeting.Size = new System.Drawing.Size(125, 23);
            this.btnCancelMeeting.TabIndex = 6;
            this.btnCancelMeeting.Text = "Cancel Meeting";
            this.btnCancelMeeting.UseVisualStyleBackColor = true;
            this.btnCancelMeeting.Click += new System.EventHandler(this.btnCancelMeeting_Click);
            // 
            // dataSchedule
            // 
            this.dataSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSchedule.Location = new System.Drawing.Point(3, 16);
            this.dataSchedule.Name = "dataSchedule";
            this.dataSchedule.Size = new System.Drawing.Size(772, 224);
            this.dataSchedule.TabIndex = 0;
            this.dataSchedule.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataSchedule_CellMouseDoubleClick);
            this.dataSchedule.SelectionChanged += new System.EventHandler(this.dataSchedule_SelectionChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(240, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 38);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Administrator Panel";
            // 
            // btnSeeCancelled
            // 
            this.btnSeeCancelled.Location = new System.Drawing.Point(306, 85);
            this.btnSeeCancelled.Name = "btnSeeCancelled";
            this.btnSeeCancelled.Size = new System.Drawing.Size(122, 35);
            this.btnSeeCancelled.TabIndex = 8;
            this.btnSeeCancelled.Text = "See Cancelled Requests";
            this.btnSeeCancelled.UseVisualStyleBackColor = true;
            this.btnSeeCancelled.Click += new System.EventHandler(this.btnSeeCancelled_Click);
            // 
            // MeetingScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 686);
            this.Controls.Add(this.btnSeeCancelled);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MeetingScheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeetingScheduler";
            this.Load += new System.EventHandler(this.MeetingScheduler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRequests)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRequestMeeting;
        private System.Windows.Forms.DateTimePicker timePickerFrom;
        private System.Windows.Forms.DateTimePicker timePickerTo;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.ComboBox listRooms;
        private System.Windows.Forms.ListBox listParticipants;
        private System.Windows.Forms.DataGridView dataRequests;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCancelMeeting;
        private System.Windows.Forms.DataGridView dataSchedule;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkImportant;
        private System.Windows.Forms.Button btnSeeCancelled;
        private System.Windows.Forms.Label label2;
    }
}