namespace Traffic_Fines_Application
{
    partial class Officer
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
            this.retBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.psw_txt = new System.Windows.Forms.TextBox();
            this.usrname_txt = new System.Windows.Forms.TextBox();
            this.signIN_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // retBtn
            // 
            this.retBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retBtn.Location = new System.Drawing.Point(306, 278);
            this.retBtn.Name = "retBtn";
            this.retBtn.Size = new System.Drawing.Size(118, 60);
            this.retBtn.TabIndex = 6;
            this.retBtn.Text = "Return";
            this.retBtn.UseVisualStyleBackColor = true;
            this.retBtn.Click += new System.EventHandler(this.retBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter UserName";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password";
            // 
            // psw_txt
            // 
            this.psw_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.psw_txt.Location = new System.Drawing.Point(263, 142);
            this.psw_txt.Name = "psw_txt";
            this.psw_txt.Size = new System.Drawing.Size(100, 22);
            this.psw_txt.TabIndex = 4;
            // 
            // usrname_txt
            // 
            this.usrname_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usrname_txt.Location = new System.Drawing.Point(263, 75);
            this.usrname_txt.Name = "usrname_txt";
            this.usrname_txt.Size = new System.Drawing.Size(100, 22);
            this.usrname_txt.TabIndex = 3;
            // 
            // signIN_btn
            // 
            this.signIN_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signIN_btn.Location = new System.Drawing.Point(124, 278);
            this.signIN_btn.Name = "signIN_btn";
            this.signIN_btn.Size = new System.Drawing.Size(112, 60);
            this.signIN_btn.TabIndex = 5;
            this.signIN_btn.Text = "Sign In";
            this.signIN_btn.UseVisualStyleBackColor = true;
            this.signIN_btn.Click += new System.EventHandler(this.signIN_btn_Click);
            // 
            // Officer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 417);
            this.Controls.Add(this.signIN_btn);
            this.Controls.Add(this.usrname_txt);
            this.Controls.Add(this.psw_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retBtn);
            this.Name = "Officer";
            this.Text = "Officer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Officer_FormClosing);
            this.Load += new System.EventHandler(this.Officer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox psw_txt;
        private System.Windows.Forms.TextBox usrname_txt;
        private System.Windows.Forms.Button signIN_btn;
    }
}