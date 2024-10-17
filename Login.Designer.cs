namespace Job_Application
{
    partial class Login
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
            this.loginBTN = new System.Windows.Forms.Button();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDorNamesTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.roleCOMBO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(362, 359);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(121, 49);
            this.loginBTN.TabIndex = 17;
            this.loginBTN.Text = "LOGIN ";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(350, 275);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(133, 26);
            this.passwordTXT.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password";
            // 
            // IDorNamesTXT
            // 
            this.IDorNamesTXT.Location = new System.Drawing.Point(350, 141);
            this.IDorNamesTXT.Name = "IDorNamesTXT";
            this.IDorNamesTXT.Size = new System.Drawing.Size(133, 26);
            this.IDorNamesTXT.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "lOGIN INTO THE SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Role ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "WELCOME TO JOB MANAGEMENT SYSTEM";
            // 
            // roleCOMBO
            // 
            this.roleCOMBO.FormattingEnabled = true;
            this.roleCOMBO.Items.AddRange(new object[] {
            "Applicant",
            "Admin"});
            this.roleCOMBO.Location = new System.Drawing.Point(350, 211);
            this.roleCOMBO.Name = "roleCOMBO";
            this.roleCOMBO.Size = new System.Drawing.Size(121, 28);
            this.roleCOMBO.TabIndex = 18;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDorNamesTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleCOMBO);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDorNamesTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox roleCOMBO;
    }
}