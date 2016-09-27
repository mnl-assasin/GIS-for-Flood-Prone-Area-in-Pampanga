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
            this.StoRosario = new System.Windows.Forms.PictureBox();
            this.Mapaniqui = new System.Windows.Forms.PictureBox();
            this.SanAgustin = new System.Windows.Forms.PictureBox();
            this.panelMacabebe = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMinalin = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelCandaba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoRosario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mapaniqui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanAgustin)).BeginInit();
            this.panelMacabebe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnSendWarning.Size = new System.Drawing.Size(182, 40);
            this.btnSendWarning.TabIndex = 2;
            this.btnSendWarning.Text = "Send Warning";
            this.btnSendWarning.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(182, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
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
            this.cboSensorPort.Size = new System.Drawing.Size(170, 21);
            this.cboSensorPort.TabIndex = 9;
            // 
            // cboGSM
            // 
            this.cboGSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGSM.FormattingEnabled = true;
            this.cboGSM.Location = new System.Drawing.Point(6, 21);
            this.cboGSM.Name = "cboGSM";
            this.cboGSM.Size = new System.Drawing.Size(170, 21);
            this.cboGSM.TabIndex = 11;
            // 
            // btnSensorPort
            // 
            this.btnSensorPort.Location = new System.Drawing.Point(6, 48);
            this.btnSensorPort.Name = "btnSensorPort";
            this.btnSensorPort.Size = new System.Drawing.Size(170, 30);
            this.btnSensorPort.TabIndex = 12;
            this.btnSensorPort.Text = "Connect";
            this.btnSensorPort.UseVisualStyleBackColor = true;
            this.btnSensorPort.Click += new System.EventHandler(this.btnSensorPort_Click);
            // 
            // btnGSMPort
            // 
            this.btnGSMPort.Location = new System.Drawing.Point(6, 48);
            this.btnGSMPort.Name = "btnGSMPort";
            this.btnGSMPort.Size = new System.Drawing.Size(170, 30);
            this.btnGSMPort.TabIndex = 14;
            this.btnGSMPort.Text = "Connect";
            this.btnGSMPort.UseVisualStyleBackColor = true;
            this.btnGSMPort.Click += new System.EventHandler(this.btnGSMPort_Click);
            // 
            // btnManage
            // 
            this.btnManage.Location = new System.Drawing.Point(17, 236);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(182, 40);
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
            this.groupBox1.Size = new System.Drawing.Size(182, 86);
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
            this.groupBox2.Size = new System.Drawing.Size(182, 86);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensor Port";
            // 
            // panelCandaba
            // 
            this.panelCandaba.Controls.Add(this.StoRosario);
            this.panelCandaba.Controls.Add(this.Mapaniqui);
            this.panelCandaba.Controls.Add(this.SanAgustin);
            this.panelCandaba.Location = new System.Drawing.Point(206, 9);
            this.panelCandaba.Name = "panelCandaba";
            this.panelCandaba.Size = new System.Drawing.Size(566, 391);
            this.panelCandaba.TabIndex = 18;
            this.panelCandaba.Visible = false;
            // 
            // StoRosario
            // 
            this.StoRosario.Image = global::GIS_for_Flood_Prone_Areas_in_Pampanga.Properties.Resources.agustin_normal;
            this.StoRosario.Location = new System.Drawing.Point(369, 43);
            this.StoRosario.Name = "StoRosario";
            this.StoRosario.Size = new System.Drawing.Size(118, 102);
            this.StoRosario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StoRosario.TabIndex = 2;
            this.StoRosario.TabStop = false;
            // 
            // Mapaniqui
            // 
            this.Mapaniqui.Image = global::GIS_for_Flood_Prone_Areas_in_Pampanga.Properties.Resources.agustin_normal;
            this.Mapaniqui.Location = new System.Drawing.Point(211, 43);
            this.Mapaniqui.Name = "Mapaniqui";
            this.Mapaniqui.Size = new System.Drawing.Size(118, 102);
            this.Mapaniqui.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mapaniqui.TabIndex = 1;
            this.Mapaniqui.TabStop = false;
            // 
            // SanAgustin
            // 
            this.SanAgustin.Image = global::GIS_for_Flood_Prone_Areas_in_Pampanga.Properties.Resources.agustin_normal;
            this.SanAgustin.Location = new System.Drawing.Point(50, 43);
            this.SanAgustin.Name = "SanAgustin";
            this.SanAgustin.Size = new System.Drawing.Size(118, 102);
            this.SanAgustin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SanAgustin.TabIndex = 0;
            this.SanAgustin.TabStop = false;
            // 
            // panelMacabebe
            // 
            this.panelMacabebe.Controls.Add(this.pictureBox1);
            this.panelMacabebe.Location = new System.Drawing.Point(173, 406);
            this.panelMacabebe.Name = "panelMacabebe";
            this.panelMacabebe.Size = new System.Drawing.Size(566, 391);
            this.panelMacabebe.TabIndex = 3;
            this.panelMacabebe.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMinalin
            // 
            this.panelMinalin.Location = new System.Drawing.Point(790, 100);
            this.panelMinalin.Name = "panelMinalin";
            this.panelMinalin.Size = new System.Drawing.Size(566, 391);
            this.panelMinalin.TabIndex = 1;
            // 
            // ClientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 619);
            this.Controls.Add(this.panelMacabebe);
            this.Controls.Add(this.panelMinalin);
            this.Controls.Add(this.panelCandaba);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.lblAdminType);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSendWarning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panelCandaba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoRosario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mapaniqui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanAgustin)).EndInit();
            this.panelMacabebe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.PictureBox StoRosario;
        private System.Windows.Forms.PictureBox Mapaniqui;
        private System.Windows.Forms.PictureBox SanAgustin;
        private System.Windows.Forms.Panel panelMacabebe;
        private System.Windows.Forms.Panel panelMinalin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}