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
            this.btnSendWarning = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblAdminType = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.cboSensorPort = new System.Windows.Forms.ComboBox();
            this.cboGSM = new System.Windows.Forms.ComboBox();
            this.btnSensorPort = new System.Windows.Forms.Button();
            this.btnGSMPort = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelCandaba = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.candabaBrgy2 = new System.Windows.Forms.PictureBox();
            this.candabaBrgy3 = new System.Windows.Forms.PictureBox();
            this.candabaBrgy1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelCandaba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candabaBrgy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candabaBrgy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candabaBrgy1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendWarning
            // 
            this.btnSendWarning.Location = new System.Drawing.Point(17, 373);
            this.btnSendWarning.Name = "btnSendWarning";
            this.btnSendWarning.Size = new System.Drawing.Size(148, 27);
            this.btnSendWarning.TabIndex = 2;
            this.btnSendWarning.Text = "Logout";
            this.btnSendWarning.UseVisualStyleBackColor = true;
            this.btnSendWarning.Click += new System.EventHandler(this.btnSendWarning_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(19, 9);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(52, 20);
            this.lblAccountName.TabIndex = 6;
            this.lblAccountName.Text = "Name:";
            // 
            // lblAdminType
            // 
            this.lblAdminType.AutoSize = true;
            this.lblAdminType.Location = new System.Drawing.Point(19, 29);
            this.lblAdminType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminType.Name = "lblAdminType";
            this.lblAdminType.Size = new System.Drawing.Size(86, 20);
            this.lblAdminType.TabIndex = 7;
            this.lblAdminType.Text = "Admin type";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cboSensorPort
            // 
            this.cboSensorPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSensorPort.FormattingEnabled = true;
            this.cboSensorPort.Location = new System.Drawing.Point(6, 21);
            this.cboSensorPort.Name = "cboSensorPort";
            this.cboSensorPort.Size = new System.Drawing.Size(128, 21);
            this.cboSensorPort.TabIndex = 9;
            // 
            // cboGSM
            // 
            this.cboGSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGSM.FormattingEnabled = true;
            this.cboGSM.Location = new System.Drawing.Point(6, 21);
            this.cboGSM.Name = "cboGSM";
            this.cboGSM.Size = new System.Drawing.Size(128, 21);
            this.cboGSM.TabIndex = 11;
            // 
            // btnSensorPort
            // 
            this.btnSensorPort.Location = new System.Drawing.Point(6, 48);
            this.btnSensorPort.Name = "btnSensorPort";
            this.btnSensorPort.Size = new System.Drawing.Size(128, 30);
            this.btnSensorPort.TabIndex = 12;
            this.btnSensorPort.Text = "Connect";
            this.btnSensorPort.UseVisualStyleBackColor = true;
            this.btnSensorPort.Click += new System.EventHandler(this.btnSensorPort_Click);
            // 
            // btnGSMPort
            // 
            this.btnGSMPort.Location = new System.Drawing.Point(6, 48);
            this.btnGSMPort.Name = "btnGSMPort";
            this.btnGSMPort.Size = new System.Drawing.Size(128, 30);
            this.btnGSMPort.TabIndex = 14;
            this.btnGSMPort.Text = "Connect";
            this.btnGSMPort.UseVisualStyleBackColor = true;
            this.btnGSMPort.Click += new System.EventHandler(this.btnGSMPort_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(17, 236);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(148, 40);
            this.btnManage.TabIndex = 15;
            this.btnManage.Text = "Manage";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSensorPort);
            this.groupBox1.Controls.Add(this.btnSensorPort);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox1.Location = new System.Drawing.Point(17, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboGSM);
            this.groupBox2.Controls.Add(this.btnGSMPort);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox2.Location = new System.Drawing.Point(17, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 86);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Port";
            // 
            // panelCandaba
            // 
            this.panelCandaba.BackgroundImage = global::GIS_for_Flood_Prone_Areas_in_Pampanga.Properties.Resources.candaba_baragay_bound;
            this.panelCandaba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCandaba.Controls.Add(this.label3);
            this.panelCandaba.Controls.Add(this.label2);
            this.panelCandaba.Controls.Add(this.label1);
            this.panelCandaba.Controls.Add(this.candabaBrgy2);
            this.panelCandaba.Controls.Add(this.candabaBrgy3);
            this.panelCandaba.Controls.Add(this.candabaBrgy1);
            this.panelCandaba.Enabled = false;
            this.panelCandaba.Location = new System.Drawing.Point(171, 9);
            this.panelCandaba.Name = "panelCandaba";
            this.panelCandaba.Size = new System.Drawing.Size(601, 391);
            this.panelCandaba.TabIndex = 18;
            this.panelCandaba.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(475, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // candabaBrgy2
            // 
            this.candabaBrgy2.Image = global::GIS_for_Flood_Prone_Areas_in_Pampanga.Properties.Resources.candaba_brgy2_normal;
            this.candabaBrgy2.Location = new System.Drawing.Point(83, 210);
            this.candabaBrgy2.Name = "candabaBrgy2";
            this.candabaBrgy2.Size = new System.Drawing.Size(177, 180);
            this.candabaBrgy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candabaBrgy2.TabIndex = 23;
            this.candabaBrgy2.TabStop = false;
            this.candabaBrgy2.Click += new System.EventHandler(this.candabaBrgy2_Click);
            // 
            // candabaBrgy3
            // 
            this.candabaBrgy3.Image = global::GIS_for_Flood_Prone_Areas_in_Pampanga.Properties.Resources.candaba_brgy3_normal;
            this.candabaBrgy3.Location = new System.Drawing.Point(412, 104);
            this.candabaBrgy3.Name = "candabaBrgy3";
            this.candabaBrgy3.Size = new System.Drawing.Size(170, 104);
            this.candabaBrgy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candabaBrgy3.TabIndex = 22;
            this.candabaBrgy3.TabStop = false;
            this.candabaBrgy3.Click += new System.EventHandler(this.candabaBrgy3_Click);
            // 
            // candabaBrgy1
            // 
            this.candabaBrgy1.Image = global::GIS_for_Flood_Prone_Areas_in_Pampanga.Properties.Resources.candaba_brgy1_normal;
            this.candabaBrgy1.Location = new System.Drawing.Point(17, 1);
            this.candabaBrgy1.Margin = new System.Windows.Forms.Padding(0);
            this.candabaBrgy1.Name = "candabaBrgy1";
            this.candabaBrgy1.Size = new System.Drawing.Size(243, 213);
            this.candabaBrgy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candabaBrgy1.TabIndex = 21;
            this.candabaBrgy1.TabStop = false;
            this.candabaBrgy1.Click += new System.EventHandler(this.candabaBrgy1_Click);
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 412);
            this.Controls.Add(this.panelCandaba);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.lblAdminType);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSendWarning);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelCandaba.ResumeLayout(false);
            this.panelCandaba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candabaBrgy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candabaBrgy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candabaBrgy1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendWarning;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblAdminType;
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.ComboBox cboSensorPort;
        private System.Windows.Forms.ComboBox cboGSM;
        private System.Windows.Forms.Button btnSensorPort;
        private System.Windows.Forms.Button btnGSMPort;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelCandaba;
        private System.Windows.Forms.PictureBox candabaBrgy1;
        private System.Windows.Forms.PictureBox candabaBrgy3;
        private System.Windows.Forms.PictureBox candabaBrgy2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}