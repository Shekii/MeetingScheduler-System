namespace Jan_Prototype
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.dataMeetRequests = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnCancelAttendance = new System.Windows.Forms.Button();
            this.dataSchedule = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveExclusionDates = new System.Windows.Forms.Button();
            this.userPanelHelp = new System.Windows.Forms.HelpProvider();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMeetRequests)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSchedule)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(8, 453);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(160, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back, ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataMeetRequests);
            this.groupBox1.Location = new System.Drawing.Point(753, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meeting Requests";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAccept);
            this.groupBox3.Controls.Add(this.btnDecline);
            this.groupBox3.Location = new System.Drawing.Point(19, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(677, 79);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manage Requests";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(6, 37);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(119, 37);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(75, 23);
            this.btnDecline.TabIndex = 1;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // dataMeetRequests
            // 
            this.dataMeetRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataMeetRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMeetRequests.Location = new System.Drawing.Point(0, 28);
            this.dataMeetRequests.MultiSelect = false;
            this.dataMeetRequests.Name = "dataMeetRequests";
            this.dataMeetRequests.ReadOnly = true;
            this.dataMeetRequests.Size = new System.Drawing.Size(735, 240);
            this.dataMeetRequests.TabIndex = 4;
            this.dataMeetRequests.SelectionChanged += new System.EventHandler(this.dataMeetRequests_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dataSchedule);
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 391);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meeting Schedule";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblReason);
            this.groupBox4.Controls.Add(this.txtReason);
            this.groupBox4.Controls.Add(this.btnCancelAttendance);
            this.groupBox4.Location = new System.Drawing.Point(16, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 75);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manage Your Schedule";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(428, 24);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 7;
            this.lblReason.Text = "Reason";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(6, 21);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(416, 48);
            this.txtReason.TabIndex = 6;
            // 
            // btnCancelAttendance
            // 
            this.btnCancelAttendance.Location = new System.Drawing.Point(428, 46);
            this.btnCancelAttendance.Name = "btnCancelAttendance";
            this.btnCancelAttendance.Size = new System.Drawing.Size(140, 23);
            this.btnCancelAttendance.TabIndex = 5;
            this.btnCancelAttendance.Text = "Cancel Your Attendance";
            this.btnCancelAttendance.UseVisualStyleBackColor = true;
            this.btnCancelAttendance.Click += new System.EventHandler(this.btnCancelAttendance_Click);
            // 
            // dataSchedule
            // 
            this.dataSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSchedule.Location = new System.Drawing.Point(0, 28);
            this.dataSchedule.Name = "dataSchedule";
            this.dataSchedule.ReadOnly = true;
            this.dataSchedule.Size = new System.Drawing.Size(729, 240);
            this.dataSchedule.TabIndex = 3;
            this.dataSchedule.SelectionChanged += new System.EventHandler(this.dataSchedule_SelectionChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 479);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(236, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRemoveExclusionDates);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lblEndDate);
            this.groupBox5.Controls.Add(this.lblStartDate);
            this.groupBox5.Location = new System.Drawing.Point(753, 420);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(344, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Your Exclusion Dates";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(220, 37);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(99, 20);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "24/01/2017";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(16, 38);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(99, 20);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "24/01/2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "until";
            // 
            // btnRemoveExclusionDates
            // 
            this.btnRemoveExclusionDates.Location = new System.Drawing.Point(19, 71);
            this.btnRemoveExclusionDates.Name = "btnRemoveExclusionDates";
            this.btnRemoveExclusionDates.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveExclusionDates.TabIndex = 2;
            this.btnRemoveExclusionDates.Text = "Change Exclusion Dates";
            this.btnRemoveExclusionDates.UseVisualStyleBackColor = true;
            this.btnRemoveExclusionDates.Click += new System.EventHandler(this.btnRemoveExclusionDates_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(1223, 477);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 38);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "User Control Panel";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 532);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMeetRequests)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSchedule)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataSchedule;
        private System.Windows.Forms.DataGridView dataMeetRequests;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCancelAttendance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveExclusionDates;
        private System.Windows.Forms.HelpProvider userPanelHelp;
        private System.Windows.Forms.Label lblTitle;
    }
}