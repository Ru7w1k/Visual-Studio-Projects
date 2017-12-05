namespace UserStatusTest
{
    partial class Home
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
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.radU = new System.Windows.Forms.RadioButton();
            this.radI = new System.Windows.Forms.RadioButton();
            this.radN = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBulkCount = new System.Windows.Forms.TextBox();
            this.btnBulkSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Location = new System.Drawing.Point(82, 24);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(133, 21);
            this.cmbUserName.TabIndex = 0;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(21, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 13);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Username";
            // 
            // radU
            // 
            this.radU.AutoSize = true;
            this.radU.Location = new System.Drawing.Point(82, 90);
            this.radU.Name = "radU";
            this.radU.Size = new System.Drawing.Size(80, 17);
            this.radU.TabIndex = 2;
            this.radU.TabStop = true;
            this.radU.Text = "Understood";
            this.radU.UseVisualStyleBackColor = true;
            this.radU.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // radI
            // 
            this.radI.AutoSize = true;
            this.radI.Location = new System.Drawing.Point(82, 114);
            this.radI.Name = "radI";
            this.radI.Size = new System.Drawing.Size(116, 17);
            this.radI.TabIndex = 3;
            this.radI.TabStop = true;
            this.radI.Text = "More Info Required";
            this.radI.UseVisualStyleBackColor = true;
            this.radI.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // radN
            // 
            this.radN.AutoSize = true;
            this.radN.Location = new System.Drawing.Point(82, 138);
            this.radN.Name = "radN";
            this.radN.Size = new System.Drawing.Size(90, 17);
            this.radN.TabIndex = 4;
            this.radN.TabStop = true;
            this.radN.Text = "No Response";
            this.radN.UseVisualStyleBackColor = true;
            this.radN.CheckedChanged += new System.EventHandler(this.checkChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(221, 21);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 25);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBulkCount
            // 
            this.txtBulkCount.Location = new System.Drawing.Point(82, 54);
            this.txtBulkCount.Name = "txtBulkCount";
            this.txtBulkCount.Size = new System.Drawing.Size(133, 20);
            this.txtBulkCount.TabIndex = 6;
            // 
            // btnBulkSend
            // 
            this.btnBulkSend.Location = new System.Drawing.Point(221, 51);
            this.btnBulkSend.Name = "btnBulkSend";
            this.btnBulkSend.Size = new System.Drawing.Size(87, 25);
            this.btnBulkSend.TabIndex = 7;
            this.btnBulkSend.Text = "Update Bulk";
            this.btnBulkSend.UseVisualStyleBackColor = true;
            this.btnBulkSend.Click += new System.EventHandler(this.btnBulkSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Count";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(79, 167);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "label1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 189);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBulkSend);
            this.Controls.Add(this.txtBulkCount);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.radN);
            this.Controls.Add(this.radI);
            this.Controls.Add(this.radU);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbUserName);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RadioButton radU;
        private System.Windows.Forms.RadioButton radI;
        private System.Windows.Forms.RadioButton radN;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBulkCount;
        private System.Windows.Forms.Button btnBulkSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
    }
}

