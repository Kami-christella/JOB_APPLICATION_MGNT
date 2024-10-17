namespace Job_Application
{
    partial class Form1
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
            this.signupBTN = new System.Windows.Forms.Button();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDorNamesTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.roleCOMBO = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // signupBTN
            // 
            this.signupBTN.Location = new System.Drawing.Point(334, 361);
            this.signupBTN.Name = "signupBTN";
            this.signupBTN.Size = new System.Drawing.Size(121, 49);
            this.signupBTN.TabIndex = 26;
            this.signupBTN.Text = "SIGNUP";
            this.signupBTN.UseVisualStyleBackColor = true;
            this.signupBTN.Click += new System.EventHandler(this.signupBTN_Click);
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(350, 275);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(133, 26);
            this.passwordTXT.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Password";
            // 
            // IDorNamesTXT
            // 
            this.IDorNamesTXT.Location = new System.Drawing.Point(350, 141);
            this.IDorNamesTXT.Name = "IDorNamesTXT";
            this.IDorNamesTXT.Size = new System.Drawing.Size(133, 26);
            this.IDorNamesTXT.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "SIGNUP INTO THE SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Role ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 19;
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
            this.roleCOMBO.TabIndex = 27;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(604, 375);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(174, 20);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Have an Account Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.signupBTN);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDorNamesTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleCOMBO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signupBTN;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDorNamesTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox roleCOMBO;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

