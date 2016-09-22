namespace GIS_for_Flood_Prone_Areas_in_Pampanga
{
    partial class ClientPanel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendWarning = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.candabaBox = new System.Windows.Forms.GroupBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblAdminType = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cboSensorPort = new System.Windows.Forms.ComboBox();
            this.cboGSM = new System.Windows.Forms.ComboBox();
            this.btnSensorPort = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGSMPort = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Type:";
            // 
            // btnSendWarning
            // 
            this.btnSendWarning.Location = new System.Drawing.Point(17, 282);
            this.btnSendWarning.Name = "btnSendWarning";
            this.btnSendWarning.Size = new System.Drawing.Size(182, 56);
            this.btnSendWarning.TabIndex = 2;
            this.btnSendWarning.Text = "Send Warning";
            this.btnSendWarning.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 56);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // candabaBox
            // 
            this.candabaBox.Location = new System.Drawing.Point(205, 75);
            this.candabaBox.Name = "candabaBox";
            this.candabaBox.Size = new System.Drawing.Size(567, 325);
            this.candabaBox.TabIndex = 4;
            this.candabaBox.TabStop = false;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(113, 9);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(52, 20);
            this.lblAccountName.TabIndex = 6;
            this.lblAccountName.Text = "Name:";
            // 
            // lblAdminType
            // 
            this.lblAdminType.AutoSize = true;
            this.lblAdminType.Location = new System.Drawing.Point(113, 29);
            this.lblAdminType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminType.Name = "lblAdminType";
            this.lblAdminType.Size = new System.Drawing.Size(86, 20);
            this.lblAdminType.TabIndex = 7;
            this.lblAdminType.Text = "Admin type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sensor Port:";
            // 
            // cboSensorPort
            // 
            this.cboSensorPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSensorPort.FormattingEnabled = true;
            this.cboSensorPort.Location = new System.Drawing.Point(306, 41);
            this.cboSensorPort.Name = "cboSensorPort";
            this.cboSensorPort.Size = new System.Drawing.Size(87, 28);
            this.cboSensorPort.TabIndex = 9;
            // 
            // cboGSM
            // 
            this.cboGSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGSM.FormattingEnabled = true;
            this.cboGSM.Location = new System.Drawing.Point(583, 41);
            this.cboGSM.Name = "cboGSM";
            this.cboGSM.Size = new System.Drawing.Size(87, 28);
            this.cboGSM.TabIndex = 11;
            // 
            // btnSensorPort
            // 
            this.btnSensorPort.Location = new System.Drawing.Point(399, 39);
            this.btnSensorPort.Name = "btnSensorPort";
            this.btnSensorPort.Size = new System.Drawing.Size(96, 30);
            this.btnSensorPort.TabIndex = 12;
            this.btnSensorPort.Text = "Connect";
            this.btnSensorPort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "GSM Port:";
            // 
            // btnGSMPort
            // 
            this.btnGSMPort.Location = new System.Drawing.Point(676, 39);
            this.btnGSMPort.Name = "btnGSMPort";
            this.btnGSMPort.Size = new System.Drawing.Size(96, 30);
            this.btnGSMPort.TabIndex = 14;
            this.btnGSMPort.Text = "Connect";
            this.btnGSMPort.UseVisualStyleBackColor = true;
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(17, 233);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(182, 43);
            this.btnManage.TabIndex = 15;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnGSMPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSensorPort);
            this.Controls.Add(this.cboGSM);
            this.Controls.Add(this.cboSensorPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdminType);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.candabaBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSendWarning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendWarning;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox candabaBox;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAdminType;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSensorPort;
        private System.Windows.Forms.ComboBox cboGSM;
        private System.Windows.Forms.Button btnSensorPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGSMPort;
        private System.Windows.Forms.Button btnManage;
    }
}