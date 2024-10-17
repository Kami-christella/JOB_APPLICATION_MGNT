namespace Job_Application
{
    partial class ApplicationForm
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
            this.CancelApplication = new System.Windows.Forms.Button();
            this.SearchEmailTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.positionCOMBO = new System.Windows.Forms.ComboBox();
            this.applyBTN = new System.Windows.Forms.Button();
            this.descrTXT = new System.Windows.Forms.TextBox();
            this.experienceTXT = new System.Windows.Forms.TextBox();
            this.DOBTXT = new System.Windows.Forms.TextBox();
            this.expertiseTXT = new System.Windows.Forms.TextBox();
            this.namesTXT = new System.Windows.Forms.TextBox();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelApplication
            // 
            this.CancelApplication.Location = new System.Drawing.Point(543, 379);
            this.CancelApplication.Name = "CancelApplication";
            this.CancelApplication.Size = new System.Drawing.Size(186, 41);
            this.CancelApplication.TabIndex = 38;
            this.CancelApplication.Text = "Cancel Job Application";
            this.CancelApplication.UseVisualStyleBackColor = true;
            this.CancelApplication.Click += new System.EventHandler(this.CancelApplication_Click);
            // 
            // SearchEmailTXT
            // 
            this.SearchEmailTXT.Location = new System.Drawing.Point(543, 274);
            this.SearchEmailTXT.Name = "SearchEmailTXT";
            this.SearchEmailTXT.Size = new System.Drawing.Size(169, 26);
            this.SearchEmailTXT.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Enter Your  Email";
            // 
            // positionCOMBO
            // 
            this.positionCOMBO.FormattingEnabled = true;
            this.positionCOMBO.Items.AddRange(new object[] {
            "Backend Developer",
            "Frontend Developer",
            "Software Tester",
            "DevOps Engineer",
            "Network Engineer"});
            this.positionCOMBO.Location = new System.Drawing.Point(227, 338);
            this.positionCOMBO.Name = "positionCOMBO";
            this.positionCOMBO.Size = new System.Drawing.Size(121, 28);
            this.positionCOMBO.TabIndex = 35;
            // 
            // applyBTN
            // 
            this.applyBTN.Location = new System.Drawing.Point(563, 117);
            this.applyBTN.Name = "applyBTN";
            this.applyBTN.Size = new System.Drawing.Size(112, 42);
            this.applyBTN.TabIndex = 34;
            this.applyBTN.Text = "Apply";
            this.applyBTN.UseVisualStyleBackColor = true;
            this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
            // 
            // descrTXT
            // 
            this.descrTXT.Location = new System.Drawing.Point(227, 394);
            this.descrTXT.Name = "descrTXT";
            this.descrTXT.Size = new System.Drawing.Size(100, 26);
            this.descrTXT.TabIndex = 33;
            // 
            // experienceTXT
            // 
            this.experienceTXT.Location = new System.Drawing.Point(227, 287);
            this.experienceTXT.Name = "experienceTXT";
            this.experienceTXT.Size = new System.Drawing.Size(100, 26);
            this.experienceTXT.TabIndex = 32;
            // 
            // DOBTXT
            // 
            this.DOBTXT.Location = new System.Drawing.Point(227, 194);
            this.DOBTXT.Name = "DOBTXT";
            this.DOBTXT.Size = new System.Drawing.Size(100, 26);
            this.DOBTXT.TabIndex = 31;
            // 
            // expertiseTXT
            // 
            this.expertiseTXT.Location = new System.Drawing.Point(227, 239);
            this.expertiseTXT.Name = "expertiseTXT";
            this.expertiseTXT.Size = new System.Drawing.Size(100, 26);
            this.expertiseTXT.TabIndex = 30;
            // 
            // namesTXT
            // 
            this.namesTXT.Location = new System.Drawing.Point(227, 154);
            this.namesTXT.Name = "namesTXT";
            this.namesTXT.Size = new System.Drawing.Size(100, 26);
            this.namesTXT.TabIndex = 29;
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(227, 115);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(100, 26);
            this.emailTXT.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Job Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Years Of Experience";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Expertise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Full Names";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "JOB Application";
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(681, 117);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(112, 43);
            this.updateBTN.TabIndex = 39;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.CancelApplication);
            this.Controls.Add(this.SearchEmailTXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.positionCOMBO);
            this.Controls.Add(this.applyBTN);
            this.Controls.Add(this.descrTXT);
            this.Controls.Add(this.experienceTXT);
            this.Controls.Add(this.DOBTXT);
            this.Controls.Add(this.expertiseTXT);
            this.Controls.Add(this.namesTXT);
            this.Controls.Add(this.emailTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelApplication;
        private System.Windows.Forms.TextBox SearchEmailTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox positionCOMBO;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.TextBox descrTXT;
        private System.Windows.Forms.TextBox experienceTXT;
        private System.Windows.Forms.TextBox DOBTXT;
        private System.Windows.Forms.TextBox expertiseTXT;
        private System.Windows.Forms.TextBox namesTXT;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBTN;
    }
}