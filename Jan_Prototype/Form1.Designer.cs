namespace Jan_Prototype
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.listUsernames = new System.Windows.Forms.ListBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnForceConflict = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnWipeAutoI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(20, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(20, 84);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(86, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // listUsernames
            // 
            this.listUsernames.FormattingEnabled = true;
            this.listUsernames.Location = new System.Drawing.Point(131, 23);
            this.listUsernames.Name = "listUsernames";
            this.listUsernames.Size = new System.Drawing.Size(171, 43);
            this.listUsernames.TabIndex = 3;
            this.listUsernames.SelectedIndexChanged += new System.EventHandler(this.listUsernames_SelectedIndexChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(131, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnForceConflict
            // 
            this.btnForceConflict.Location = new System.Drawing.Point(131, 229);
            this.btnForceConflict.Name = "btnForceConflict";
            this.btnForceConflict.Size = new System.Drawing.Size(156, 23);
            this.btnForceConflict.TabIndex = 5;
            this.btnForceConflict.Text = "Force Authorisation Conflict";
            this.btnForceConflict.UseVisualStyleBackColor = true;
            this.btnForceConflict.Click += new System.EventHandler(this.btnForceConflict_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Jan_Prototype.Properties.Resources.padlock;
            this.pictureBox1.Location = new System.Drawing.Point(24, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 66);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::Jan_Prototype.Properties.Resources.login;
            this.btnLogin.Location = new System.Drawing.Point(131, 119);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(171, 58);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnWipeAutoI
            // 
            this.btnWipeAutoI.Location = new System.Drawing.Point(12, 282);
            this.btnWipeAutoI.Name = "btnWipeAutoI";
            this.btnWipeAutoI.Size = new System.Drawing.Size(75, 23);
            this.btnWipeAutoI.TabIndex = 7;
            this.btnWipeAutoI.Text = "Wipe AI";
            this.btnWipeAutoI.UseVisualStyleBackColor = true;
            this.btnWipeAutoI.Click += new System.EventHandler(this.btnWipeAutoI_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 317);
            this.Controls.Add(this.btnWipeAutoI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnForceConflict);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.listUsernames);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meeting Scheduler Prototype";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListBox listUsernames;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnForceConflict;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnWipeAutoI;
    }
}

