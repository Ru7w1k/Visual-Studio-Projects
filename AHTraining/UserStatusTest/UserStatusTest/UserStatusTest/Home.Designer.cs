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
            this.radU.Location = new System.Drawing.Point(24, 71);
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
            this.radI.Location = new System.Drawing.Point(24, 95);
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
            this.radN.Location = new System.Drawing.Point(24, 119);
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
            this.btnSend.Location = new System.Drawing.Point(146, 71);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(69, 65);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 172);
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
    }
}

