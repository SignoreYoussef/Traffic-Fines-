namespace Traffic_Fines_Application
{
    partial class OfficerControl
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
            this.addfine_btn = new System.Windows.Forms.Button();
            this.addtype_btn = new System.Windows.Forms.Button();
            this.viewrep_btn = new System.Windows.Forms.Button();
            this.drvr_vecbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ret_btn
            // 
            this.ret_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ret_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ret_btn.Location = new System.Drawing.Point(66, 273);
            this.ret_btn.Name = "ret_btn";
            this.ret_btn.Size = new System.Drawing.Size(375, 50);
            this.ret_btn.TabIndex = 5;
            this.ret_btn.Text = "Return";
            this.ret_btn.UseVisualStyleBackColor = true;
            this.ret_btn.Click += new System.EventHandler(this.ret_btn_Click);
            // 
            // addfine_btn
            // 
            this.addfine_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addfine_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addfine_btn.Location = new System.Drawing.Point(66, 49);
            this.addfine_btn.Name = "addfine_btn";
            this.addfine_btn.Size = new System.Drawing.Size(375, 50);
            this.addfine_btn.TabIndex = 1;
            this.addfine_btn.Text = "Add Fine";
            this.addfine_btn.UseVisualStyleBackColor = true;
            this.addfine_btn.Click += new System.EventHandler(this.addfine_btn_Click);
            // 
            // addtype_btn
            // 
            this.addtype_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addtype_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtype_btn.Location = new System.Drawing.Point(66, 105);
            this.addtype_btn.Name = "addtype_btn";
            this.addtype_btn.Size = new System.Drawing.Size(375, 50);
            this.addtype_btn.TabIndex = 2;
            this.addtype_btn.Text = "Add Fine Type";
            this.addtype_btn.UseVisualStyleBackColor = true;
            this.addtype_btn.Click += new System.EventHandler(this.addtype_btn_Click);
            // 
            // viewrep_btn
            // 
            this.viewrep_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewrep_btn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.viewrep_btn.Location = new System.Drawing.Point(66, 161);
            this.viewrep_btn.Name = "viewrep_btn";
            this.viewrep_btn.Size = new System.Drawing.Size(375, 50);
            this.viewrep_btn.TabIndex = 4;
            this.viewrep_btn.Text = "View Fine Reports";
            this.viewrep_btn.UseVisualStyleBackColor = true;
            this.viewrep_btn.Click += new System.EventHandler(this.viewrep_btn_Click);
            // 
            // drvr_vecbtn
            // 
            this.drvr_vecbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drvr_vecbtn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drvr_vecbtn.Location = new System.Drawing.Point(66, 217);
            this.drvr_vecbtn.Name = "drvr_vecbtn";
            this.drvr_vecbtn.Size = new System.Drawing.Size(375, 50);
            this.drvr_vecbtn.TabIndex = 6;
            this.drvr_vecbtn.Text = "Driver Vehicles";
            this.drvr_vecbtn.UseVisualStyleBackColor = true;
            this.drvr_vecbtn.Click += new System.EventHandler(this.drvr_vecbtn_Click);
            // 
            // OfficerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 341);
            this.Controls.Add(this.drvr_vecbtn);
            this.Controls.Add(this.viewrep_btn);
            this.Controls.Add(this.addtype_btn);
            this.Controls.Add(this.addfine_btn);
            this.Controls.Add(this.ret_btn);
            this.Name = "OfficerControl";
            this.Text = "OfficerControl";
            this.Load += new System.EventHandler(this.OfficerControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ret_btn;
        private System.Windows.Forms.Button addfine_btn;
        private System.Windows.Forms.Button addtype_btn;
        private System.Windows.Forms.Button viewrep_btn;
        private System.Windows.Forms.Button drvr_vecbtn;
    }
}