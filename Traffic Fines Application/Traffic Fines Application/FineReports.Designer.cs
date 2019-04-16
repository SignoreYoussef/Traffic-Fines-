namespace Traffic_Fines_Application
{
    partial class FineReports
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
            this.ret_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ofcr_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fty_txt = new System.Windows.Forms.TextBox();
            this.sbmt_btn = new System.Windows.Forms.Button();
            this.fid_cmb = new System.Windows.Forms.ComboBox();
            this.vpn_cmb = new System.Windows.Forms.ComboBox();
            this.cin_cmb = new System.Windows.Forms.ComboBox();
            this.vd_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.amt_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ret_btn
            // 
            this.ret_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ret_btn.Location = new System.Drawing.Point(266, 380);
            this.ret_btn.Name = "ret_btn";
            this.ret_btn.Size = new System.Drawing.Size(100, 50);
            this.ret_btn.TabIndex = 0;
            this.ret_btn.Text = "Return ";
            this.ret_btn.UseVisualStyleBackColor = true;
            this.ret_btn.Click += new System.EventHandler(this.ret_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fine ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fine Type";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veichle Plate Number";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Officer UserName";
            // 
            // ofcr_txt
            // 
            this.ofcr_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ofcr_txt.Location = new System.Drawing.Point(180, 79);
            this.ofcr_txt.Name = "ofcr_txt";
            this.ofcr_txt.ReadOnly = true;
            this.ofcr_txt.Size = new System.Drawing.Size(121, 22);
            this.ofcr_txt.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Court Issue Number";
            // 
            // fty_txt
            // 
            this.fty_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fty_txt.Location = new System.Drawing.Point(147, 167);
            this.fty_txt.Name = "fty_txt";
            this.fty_txt.ReadOnly = true;
            this.fty_txt.Size = new System.Drawing.Size(192, 22);
            this.fty_txt.TabIndex = 8;
            // 
            // sbmt_btn
            // 
            this.sbmt_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbmt_btn.Location = new System.Drawing.Point(131, 380);
            this.sbmt_btn.Name = "sbmt_btn";
            this.sbmt_btn.Size = new System.Drawing.Size(100, 50);
            this.sbmt_btn.TabIndex = 11;
            this.sbmt_btn.Text = "Submit";
            this.sbmt_btn.UseVisualStyleBackColor = true;
            this.sbmt_btn.Click += new System.EventHandler(this.sbmt_btn_Click);
            // 
            // fid_cmb
            // 
            this.fid_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fid_cmb.FormattingEnabled = true;
            this.fid_cmb.Location = new System.Drawing.Point(180, 130);
            this.fid_cmb.Name = "fid_cmb";
            this.fid_cmb.Size = new System.Drawing.Size(121, 24);
            this.fid_cmb.TabIndex = 12;
            this.fid_cmb.SelectedIndexChanged += new System.EventHandler(this.fid_cmb_SelectedIndexChanged);
            // 
            // vpn_cmb
            // 
            this.vpn_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vpn_cmb.FormattingEnabled = true;
            this.vpn_cmb.Location = new System.Drawing.Point(180, 246);
            this.vpn_cmb.Name = "vpn_cmb";
            this.vpn_cmb.Size = new System.Drawing.Size(121, 24);
            this.vpn_cmb.TabIndex = 13;
            // 
            // cin_cmb
            // 
            this.cin_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cin_cmb.FormattingEnabled = true;
            this.cin_cmb.Location = new System.Drawing.Point(180, 290);
            this.cin_cmb.Name = "cin_cmb";
            this.cin_cmb.Size = new System.Drawing.Size(121, 24);
            this.cin_cmb.TabIndex = 14;
            // 
            // vd_btn
            // 
            this.vd_btn.Location = new System.Drawing.Point(349, 52);
            this.vd_btn.Name = "vd_btn";
            this.vd_btn.Size = new System.Drawing.Size(120, 50);
            this.vd_btn.TabIndex = 15;
            this.vd_btn.Text = "Vehicle-Driver";
            this.vd_btn.UseVisualStyleBackColor = true;
            this.vd_btn.Click += new System.EventHandler(this.vd_btn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fine Amount";
            // 
            // amt_txt
            // 
            this.amt_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amt_txt.Location = new System.Drawing.Point(149, 208);
            this.amt_txt.Name = "amt_txt";
            this.amt_txt.ReadOnly = true;
            this.amt_txt.Size = new System.Drawing.Size(192, 22);
            this.amt_txt.TabIndex = 17;
            // 
            // FineReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 442);
            this.Controls.Add(this.amt_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vd_btn);
            this.Controls.Add(this.cin_cmb);
            this.Controls.Add(this.vpn_cmb);
            this.Controls.Add(this.fid_cmb);
            this.Controls.Add(this.sbmt_btn);
            this.Controls.Add(this.fty_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ofcr_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ret_btn);
            this.Name = "FineReports";
            this.Text = "FineReports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FineReports_FormClosing);
            this.Load += new System.EventHandler(this.FineReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ret_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ofcr_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fty_txt;
        private System.Windows.Forms.Button sbmt_btn;
        private System.Windows.Forms.ComboBox fid_cmb;
        private System.Windows.Forms.ComboBox vpn_cmb;
        private System.Windows.Forms.ComboBox cin_cmb;
        private System.Windows.Forms.Button vd_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amt_txt;
    }
}