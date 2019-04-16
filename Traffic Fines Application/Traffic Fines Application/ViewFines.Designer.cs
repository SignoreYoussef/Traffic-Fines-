namespace Traffic_Fines_Application
{
    partial class ViewFines
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
            this.bk_button = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.dlt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bk_button
            // 
            this.bk_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bk_button.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bk_button.Location = new System.Drawing.Point(814, 12);
            this.bk_button.Name = "bk_button";
            this.bk_button.Size = new System.Drawing.Size(120, 35);
            this.bk_button.TabIndex = 0;
            this.bk_button.Text = "Back";
            this.bk_button.UseVisualStyleBackColor = true;
            this.bk_button.Click += new System.EventHandler(this.bk_button_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 71);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1299, 779);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Viewbtn
            // 
            this.Viewbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Viewbtn.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.Viewbtn.Location = new System.Drawing.Point(293, 12);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(120, 35);
            this.Viewbtn.TabIndex = 2;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // dlt_btn
            // 
            this.dlt_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dlt_btn.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic);
            this.dlt_btn.Location = new System.Drawing.Point(516, 12);
            this.dlt_btn.Name = "dlt_btn";
            this.dlt_btn.Size = new System.Drawing.Size(205, 35);
            this.dlt_btn.TabIndex = 3;
            this.dlt_btn.Text = "Delete Paid Fines";
            this.dlt_btn.UseVisualStyleBackColor = true;
            this.dlt_btn.Click += new System.EventHandler(this.dlt_btn_Click);
            // 
            // ViewFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 862);
            this.Controls.Add(this.dlt_btn);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.bk_button);
            this.Name = "ViewFines";
            this.Text = "ViewFines";
            this.Load += new System.EventHandler(this.ViewFines_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bk_button;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Button dlt_btn;
    }
}