namespace Traffic_Fines_Application
{
    partial class FineType
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
            this.insrt_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.fty_txt = new System.Windows.Forms.TextBox();
            this.amt_txt = new System.Windows.Forms.TextBox();
            this.fid_cmb = new System.Windows.Forms.ComboBox();
            this.uptBTN = new System.Windows.Forms.Button();
            this.dlt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ret_btn
            // 
            this.ret_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ret_btn.Location = new System.Drawing.Point(427, 233);
            this.ret_btn.Name = "ret_btn";
            this.ret_btn.Size = new System.Drawing.Size(85, 45);
            this.ret_btn.TabIndex = 0;
            this.ret_btn.Text = "Return";
            this.ret_btn.UseVisualStyleBackColor = true;
            this.ret_btn.Click += new System.EventHandler(this.ret_btn_Click);
            // 
            // insrt_btn
            // 
            this.insrt_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insrt_btn.Location = new System.Drawing.Point(83, 233);
            this.insrt_btn.Name = "insrt_btn";
            this.insrt_btn.Size = new System.Drawing.Size(85, 45);
            this.insrt_btn.TabIndex = 1;
            this.insrt_btn.Text = "Insert";
            this.insrt_btn.UseVisualStyleBackColor = true;
            this.insrt_btn.Click += new System.EventHandler(this.insrt_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fine ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fine Type";
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(141, 143);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(56, 17);
            this.text.TabIndex = 4;
            this.text.Text = "Amount";
            // 
            // fty_txt
            // 
            this.fty_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fty_txt.Location = new System.Drawing.Point(250, 87);
            this.fty_txt.Name = "fty_txt";
            this.fty_txt.Size = new System.Drawing.Size(176, 22);
            this.fty_txt.TabIndex = 6;
            // 
            // amt_txt
            // 
            this.amt_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amt_txt.Location = new System.Drawing.Point(250, 143);
            this.amt_txt.Name = "amt_txt";
            this.amt_txt.Size = new System.Drawing.Size(176, 22);
            this.amt_txt.TabIndex = 7;
            // 
            // fid_cmb
            // 
            this.fid_cmb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fid_cmb.FormattingEnabled = true;
            this.fid_cmb.Location = new System.Drawing.Point(250, 40);
            this.fid_cmb.Name = "fid_cmb";
            this.fid_cmb.Size = new System.Drawing.Size(176, 24);
            this.fid_cmb.TabIndex = 8;
            this.fid_cmb.SelectedIndexChanged += new System.EventHandler(this.fid_cmb_SelectedIndexChanged);
            // 
            // uptBTN
            // 
            this.uptBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uptBTN.Location = new System.Drawing.Point(199, 233);
            this.uptBTN.Name = "uptBTN";
            this.uptBTN.Size = new System.Drawing.Size(85, 45);
            this.uptBTN.TabIndex = 9;
            this.uptBTN.Text = "Update";
            this.uptBTN.UseVisualStyleBackColor = true;
            this.uptBTN.Click += new System.EventHandler(this.uptBTN_Click);
            // 
            // dlt_btn
            // 
            this.dlt_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dlt_btn.Location = new System.Drawing.Point(311, 233);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(85, 45);
            this.dlt_btn.TabIndex = 10;
            this.dlt_btn.Text = "Delete";
            this.dlt_btn.UseVisualStyleBackColor = true;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // FineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 356);
            this.Controls.Add(this.dlt_btn);
            this.Controls.Add(this.uptBTN);
            this.Controls.Add(this.fid_cmb);
            this.Controls.Add(this.amt_txt);
            this.Controls.Add(this.fty_txt);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insrt_btn);
            this.Controls.Add(this.ret_btn);
            this.Name = "FineType";
            this.Text = "FineType";
            this.Load += new System.EventHandler(this.FineType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ret_btn;
        private System.Windows.Forms.Button insrt_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox fty_txt;
        private System.Windows.Forms.TextBox amt_txt;
        private System.Windows.Forms.ComboBox fid_cmb;
        private System.Windows.Forms.Button uptBTN;
        private System.Windows.Forms.Button dlt_btn;
    }
}