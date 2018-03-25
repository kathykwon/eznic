﻿namespace EZNIC
{
    partial class DHCPControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioAutoIP = new System.Windows.Forms.RadioButton();
            this.radioStaticIP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddressInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subnetMaskInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.defaultGatewayInput = new System.Windows.Forms.TextBox();
            this.radioAutoDNS = new System.Windows.Forms.RadioButton();
            this.radioSpecifyDNS = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dnsAddressInput = new System.Windows.Forms.TextBox();
            this.btnApplyDHCP = new System.Windows.Forms.Button();
            this.btnCreateNewProf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioStaticIP);
            this.panel1.Controls.Add(this.radioAutoIP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioSpecifyDNS);
            this.panel2.Controls.Add(this.radioAutoDNS);
            this.panel2.Location = new System.Drawing.Point(0, 261);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 39);
            this.panel2.TabIndex = 1;
            // 
            // radioAutoIP
            // 
            this.radioAutoIP.AutoSize = true;
            this.radioAutoIP.Location = new System.Drawing.Point(21, 14);
            this.radioAutoIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioAutoIP.Name = "radioAutoIP";
            this.radioAutoIP.Size = new System.Drawing.Size(215, 24);
            this.radioAutoIP.TabIndex = 0;
            this.radioAutoIP.TabStop = true;
            this.radioAutoIP.Text = "Automatically detect IP address";
            this.radioAutoIP.UseVisualStyleBackColor = true;
            // 
            // radioStaticIP
            // 
            this.radioStaticIP.AutoSize = true;
            this.radioStaticIP.Location = new System.Drawing.Point(274, 14);
            this.radioStaticIP.Margin = new System.Windows.Forms.Padding(0);
            this.radioStaticIP.Name = "radioStaticIP";
            this.radioStaticIP.Size = new System.Drawing.Size(170, 24);
            this.radioStaticIP.TabIndex = 1;
            this.radioStaticIP.TabStop = true;
            this.radioStaticIP.Text = "Statically set IP address";
            this.radioStaticIP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipAddressInput
            // 
            this.ipAddressInput.Location = new System.Drawing.Point(231, 65);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(170, 26);
            this.ipAddressInput.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Subnet Mask:";
            // 
            // subnetMaskInput
            // 
            this.subnetMaskInput.Location = new System.Drawing.Point(231, 127);
            this.subnetMaskInput.Name = "subnetMaskInput";
            this.subnetMaskInput.Size = new System.Drawing.Size(170, 26);
            this.subnetMaskInput.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Default Gateway:";
            // 
            // defaultGatewayInput
            // 
            this.defaultGatewayInput.Location = new System.Drawing.Point(231, 182);
            this.defaultGatewayInput.Name = "defaultGatewayInput";
            this.defaultGatewayInput.Size = new System.Drawing.Size(170, 26);
            this.defaultGatewayInput.TabIndex = 17;
            // 
            // radioAutoDNS
            // 
            this.radioAutoDNS.AutoSize = true;
            this.radioAutoDNS.Location = new System.Drawing.Point(21, 3);
            this.radioAutoDNS.Name = "radioAutoDNS";
            this.radioAutoDNS.Size = new System.Drawing.Size(116, 24);
            this.radioAutoDNS.TabIndex = 18;
            this.radioAutoDNS.TabStop = true;
            this.radioAutoDNS.Text = "Automatic DNS";
            this.radioAutoDNS.UseVisualStyleBackColor = true;
            // 
            // radioSpecifyDNS
            // 
            this.radioSpecifyDNS.AutoSize = true;
            this.radioSpecifyDNS.Location = new System.Drawing.Point(274, 3);
            this.radioSpecifyDNS.Name = "radioSpecifyDNS";
            this.radioSpecifyDNS.Size = new System.Drawing.Size(103, 24);
            this.radioSpecifyDNS.TabIndex = 19;
            this.radioSpecifyDNS.TabStop = true;
            this.radioSpecifyDNS.Text = "Specify DNS";
            this.radioSpecifyDNS.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "DNS address:";
            // 
            // dnsAddressInput
            // 
            this.dnsAddressInput.Location = new System.Drawing.Point(231, 325);
            this.dnsAddressInput.Name = "dnsAddressInput";
            this.dnsAddressInput.Size = new System.Drawing.Size(170, 26);
            this.dnsAddressInput.TabIndex = 19;
            // 
            // btnApplyDHCP
            // 
            this.btnApplyDHCP.Location = new System.Drawing.Point(41, 377);
            this.btnApplyDHCP.Name = "btnApplyDHCP";
            this.btnApplyDHCP.Size = new System.Drawing.Size(75, 30);
            this.btnApplyDHCP.TabIndex = 20;
            this.btnApplyDHCP.Text = "Apply";
            this.btnApplyDHCP.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewProf
            // 
            this.btnCreateNewProf.Location = new System.Drawing.Point(231, 377);
            this.btnCreateNewProf.Name = "btnCreateNewProf";
            this.btnCreateNewProf.Size = new System.Drawing.Size(134, 30);
            this.btnCreateNewProf.TabIndex = 21;
            this.btnCreateNewProf.Text = "Create New Profile";
            this.btnCreateNewProf.UseVisualStyleBackColor = true;
            // 
            // DHCPControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCreateNewProf);
            this.Controls.Add(this.btnApplyDHCP);
            this.Controls.Add(this.dnsAddressInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.defaultGatewayInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subnetMaskInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddressInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DHCPControl";
            this.Size = new System.Drawing.Size(476, 410);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioStaticIP;
        private System.Windows.Forms.RadioButton radioAutoIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddressInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subnetMaskInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox defaultGatewayInput;
        private System.Windows.Forms.RadioButton radioAutoDNS;
        private System.Windows.Forms.RadioButton radioSpecifyDNS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dnsAddressInput;
        private System.Windows.Forms.Button btnApplyDHCP;
        private System.Windows.Forms.Button btnCreateNewProf;
    }
}