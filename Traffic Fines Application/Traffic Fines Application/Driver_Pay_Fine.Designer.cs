namespace Traffic_Fines_Application
{
    partial class Driver_Pay_Fine
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
            this.ln_cmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pay_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Licence Number";
            // 
            // ln_cmb
            // 
            this.ln_cmb.FormattingEnabled = true;
            this.ln_cmb.Location = new System.Drawing.Point(181, 34);
            this.ln_cmb.Name = "ln_cmb";
            this.ln_cmb.Size = new System.Drawing.Size(121, 24);
            this.ln_cmb.TabIndex = 9;
            this.ln_cmb.SelectedIndexChanged += new System.EventHandler(this.ln_cmb_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1140, 435);
            this.dataGridView1.TabIndex = 5;
            // 
            // pay_btn
            // 
            this.pay_btn.Location = new System.Drawing.Point(932, 37);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(84, 30);
            this.pay_btn.TabIndex = 10;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // Driver_Pay_Fine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 544);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.ln_cmb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Driver_Pay_Fine";
            this.Text = "Driver_Pay_Fine";
            this.Load += new System.EventHandler(this.Driver_Pay_Fine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ln_cmb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button pay_btn;
    }
}