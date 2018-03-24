namespace EZNIC
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.btnDHCP = new System.Windows.Forms.Button();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioAutoIP = new System.Windows.Forms.RadioButton();
            this.radioStaticIP = new System.Windows.Forms.RadioButton();
            this.radioAutoDNS = new System.Windows.Forms.RadioButton();
            this.radioSpecifyDNS = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ipAddressInput = new System.Windows.Forms.TextBox();
            this.subnetMaskInput = new System.Windows.Forms.TextBox();
            this.defaultGatewayInput = new System.Windows.Forms.TextBox();
            this.dnsAddressInput = new System.Windows.Forms.TextBox();
            this.btnApplyDHCP = new System.Windows.Forms.Button();
            this.btnCreateNewProf = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 15);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Title);
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 70);
            this.panel2.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(205, 18);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(86, 33);
            this.Title.TabIndex = 0;
            this.Title.Text = "EZNIC";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // btnDHCP
            // 
            this.btnDHCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDHCP.Location = new System.Drawing.Point(9, 85);
            this.btnDHCP.Margin = new System.Windows.Forms.Padding(0);
            this.btnDHCP.Name = "btnDHCP";
            this.btnDHCP.Size = new System.Drawing.Size(240, 30);
            this.btnDHCP.TabIndex = 2;
            this.btnDHCP.Text = "DHCP";
            this.btnDHCP.UseVisualStyleBackColor = true;
            // 
            // btnProfiles
            // 
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfiles.Location = new System.Drawing.Point(249, 85);
            this.btnProfiles.Margin = new System.Windows.Forms.Padding(0);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(240, 30);
            this.btnProfiles.TabIndex = 3;
            this.btnProfiles.Text = "PROFILES";
            this.btnProfiles.UseVisualStyleBackColor = true;
            this.btnProfiles.Click += new System.EventHandler(this.btnProfiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subnet Mask:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Default Gateway:";
            // 
            // radioAutoIP
            // 
            this.radioAutoIP.AutoSize = true;
            this.radioAutoIP.Location = new System.Drawing.Point(21, 20);
            this.radioAutoIP.Name = "radioAutoIP";
            this.radioAutoIP.Size = new System.Drawing.Size(215, 24);
            this.radioAutoIP.TabIndex = 7;
            this.radioAutoIP.TabStop = true;
            this.radioAutoIP.Text = "Automatically detect IP address";
            this.radioAutoIP.UseVisualStyleBackColor = true;
            // 
            // radioStaticIP
            // 
            this.radioStaticIP.AutoSize = true;
            this.radioStaticIP.Location = new System.Drawing.Point(274, 20);
            this.radioStaticIP.Name = "radioStaticIP";
            this.radioStaticIP.Size = new System.Drawing.Size(170, 24);
            this.radioStaticIP.TabIndex = 8;
            this.radioStaticIP.TabStop = true;
            this.radioStaticIP.Text = "Statically set IP address";
            this.radioStaticIP.UseVisualStyleBackColor = true;
            // 
            // radioAutoDNS
            // 
            this.radioAutoDNS.AutoSize = true;
            this.radioAutoDNS.Location = new System.Drawing.Point(32, 189);
            this.radioAutoDNS.Name = "radioAutoDNS";
            this.radioAutoDNS.Size = new System.Drawing.Size(116, 24);
            this.radioAutoDNS.TabIndex = 9;
            this.radioAutoDNS.TabStop = true;
            this.radioAutoDNS.Text = "Automatic DNS";
            this.radioAutoDNS.UseVisualStyleBackColor = true;
            // 
            // radioSpecifyDNS
            // 
            this.radioSpecifyDNS.AutoSize = true;
            this.radioSpecifyDNS.Location = new System.Drawing.Point(274, 189);
            this.radioSpecifyDNS.Name = "radioSpecifyDNS";
            this.radioSpecifyDNS.Size = new System.Drawing.Size(103, 24);
            this.radioSpecifyDNS.TabIndex = 10;
            this.radioSpecifyDNS.TabStop = true;
            this.radioSpecifyDNS.Text = "Specify DNS";
            this.radioSpecifyDNS.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "DNS address:";
            // 
            // ipAddressInput
            // 
            this.ipAddressInput.Location = new System.Drawing.Point(256, 56);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(170, 26);
            this.ipAddressInput.TabIndex = 12;
            // 
            // subnetMaskInput
            // 
            this.subnetMaskInput.Location = new System.Drawing.Point(256, 102);
            this.subnetMaskInput.Name = "subnetMaskInput";
            this.subnetMaskInput.Size = new System.Drawing.Size(170, 26);
            this.subnetMaskInput.TabIndex = 13;
            // 
            // defaultGatewayInput
            // 
            this.defaultGatewayInput.Location = new System.Drawing.Point(256, 144);
            this.defaultGatewayInput.Name = "defaultGatewayInput";
            this.defaultGatewayInput.Size = new System.Drawing.Size(170, 26);
            this.defaultGatewayInput.TabIndex = 14;
            // 
            // dnsAddressInput
            // 
            this.dnsAddressInput.Location = new System.Drawing.Point(256, 229);
            this.dnsAddressInput.Name = "dnsAddressInput";
            this.dnsAddressInput.Size = new System.Drawing.Size(170, 26);
            this.dnsAddressInput.TabIndex = 15;
            // 
            // btnApplyDHCP
            // 
            this.btnApplyDHCP.Location = new System.Drawing.Point(58, 288);
            this.btnApplyDHCP.Name = "btnApplyDHCP";
            this.btnApplyDHCP.Size = new System.Drawing.Size(75, 30);
            this.btnApplyDHCP.TabIndex = 16;
            this.btnApplyDHCP.Text = "Apply";
            this.btnApplyDHCP.UseVisualStyleBackColor = true;
            // 
            // btnCreateNewProf
            // 
            this.btnCreateNewProf.Location = new System.Drawing.Point(256, 288);
            this.btnCreateNewProf.Name = "btnCreateNewProf";
            this.btnCreateNewProf.Size = new System.Drawing.Size(134, 30);
            this.btnCreateNewProf.TabIndex = 17;
            this.btnCreateNewProf.Text = "Create New Profile";
            this.btnCreateNewProf.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCreateNewProf);
            this.panel3.Controls.Add(this.btnApplyDHCP);
            this.panel3.Controls.Add(this.dnsAddressInput);
            this.panel3.Controls.Add(this.defaultGatewayInput);
            this.panel3.Controls.Add(this.subnetMaskInput);
            this.panel3.Controls.Add(this.ipAddressInput);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.radioSpecifyDNS);
            this.panel3.Controls.Add(this.radioAutoDNS);
            this.panel3.Controls.Add(this.radioStaticIP);
            this.panel3.Controls.Add(this.radioAutoIP);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(13, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 360);
            this.panel3.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnProfiles);
            this.Controls.Add(this.btnDHCP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAutoIP;
        private System.Windows.Forms.RadioButton radioStaticIP;
        private System.Windows.Forms.RadioButton radioAutoDNS;
        private System.Windows.Forms.RadioButton radioSpecifyDNS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipAddressInput;
        private System.Windows.Forms.TextBox subnetMaskInput;
        private System.Windows.Forms.TextBox defaultGatewayInput;
        private System.Windows.Forms.TextBox dnsAddressInput;
        private System.Windows.Forms.Button btnApplyDHCP;
        private System.Windows.Forms.Button btnCreateNewProf;
        private System.Windows.Forms.Panel panel3;
    }
}

