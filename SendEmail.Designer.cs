namespace EmailTester
{
    partial class SendEmail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.chkSecure = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(115, 23);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(142, 20);
            this.txtServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(145, 451);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSendEmail.TabIndex = 10;
            this.btnSendEmail.Text = "Send Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "To";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(115, 59);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(225, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 131);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(225, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(225, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(115, 277);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(225, 78);
            this.txtBody.TabIndex = 9;
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Location = new System.Drawing.Point(37, 242);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(43, 13);
            this.Body.TabIndex = 13;
            this.Body.Text = "Subject";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(115, 203);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(225, 20);
            this.txtTo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Body";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(115, 239);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(225, 20);
            this.txtSubject.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(115, 371);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(225, 62);
            this.txtResult.TabIndex = 18;
            // 
            // chkSecure
            // 
            this.chkSecure.AutoSize = true;
            this.chkSecure.Location = new System.Drawing.Point(280, 25);
            this.chkSecure.Name = "chkSecure";
            this.chkSecure.Size = new System.Drawing.Size(60, 17);
            this.chkSecure.TabIndex = 2;
            this.chkSecure.Text = "Secure";
            this.chkSecure.UseVisualStyleBackColor = true;
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 486);
            this.Controls.Add(this.chkSecure);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Name = "SendEmail";
            this.Text = "Simple Email Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.CheckBox chkSecure;
    }
}

