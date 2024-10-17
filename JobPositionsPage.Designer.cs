namespace Job_Application
{
    partial class JobPositionsPage
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
            this.saveBTN = new System.Windows.Forms.Button();
            this.descrTXT = new System.Windows.Forms.TextBox();
            this.positionCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(300, 269);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 35);
            this.saveBTN.TabIndex = 11;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // descrTXT
            // 
            this.descrTXT.Location = new System.Drawing.Point(227, 177);
            this.descrTXT.Multiline = true;
            this.descrTXT.Name = "descrTXT";
            this.descrTXT.Size = new System.Drawing.Size(183, 26);
            this.descrTXT.TabIndex = 10;
            // 
            // positionCombo
            // 
            this.positionCombo.FormattingEnabled = true;
            this.positionCombo.Items.AddRange(new object[] {
            "Backend Developer",
            "Frontend Developer",
            "Software Tester",
            "DevOps Engineer",
            "Network Engineer"});
            this.positionCombo.Location = new System.Drawing.Point(227, 126);
            this.positionCombo.Name = "positionCombo";
            this.positionCombo.Size = new System.Drawing.Size(183, 28);
            this.positionCombo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Job Position Form";
            // 
            // JobPositionsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.descrTXT);
            this.Controls.Add(this.positionCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JobPositionsPage";
            this.Text = "JobPositionsPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.TextBox descrTXT;
        private System.Windows.Forms.ComboBox positionCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}