namespace EZNIC
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioStaticIP = new System.Windows.Forms.RadioButton();
            this.radioAutoIP = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioSpecifyDNS = new System.Windows.Forms.RadioButton();
            this.radioAutoDNS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ipAddressInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subnetMaskInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.defaultGatewayInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dnsAddressInput = new System.Windows.Forms.TextBox();
            this.btnApplyDHCP = new System.Windows.Forms.Button();
            this.btnCreateNewProf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioStaticIP);
            this.panel1.Controls.Add(this.radioAutoIP);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 42);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioStaticIP
            // 
            this.radioStaticIP.AutoSize = true;
            this.radioStaticIP.Location = new System.Drawing.Point(274, 8);
            this.radioStaticIP.Margin = new System.Windows.Forms.Padding(0);
            this.radioStaticIP.Name = "radioStaticIP";
            this.radioStaticIP.Size = new System.Drawing.Size(206, 28);
            this.radioStaticIP.TabIndex = 1;
            this.radioStaticIP.TabStop = true;
            this.radioStaticIP.Text = "Statically set IP address";
            this.radioStaticIP.UseVisualStyleBackColor = true;
            this.radioStaticIP.CheckedChanged += new System.EventHandler(this.radioStaticIP_CheckedChanged);
            // 
            // radioAutoIP
            // 
            this.radioAutoIP.AutoSize = true;
            this.radioAutoIP.Location = new System.Drawing.Point(21, 8);
            this.radioAutoIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioAutoIP.Name = "radioAutoIP";
            this.radioAutoIP.Size = new System.Drawing.Size(262, 28);
            this.radioAutoIP.TabIndex = 0;
            this.radioAutoIP.TabStop = true;
            this.radioAutoIP.Text = "Automatically detect IP address";
            this.radioAutoIP.UseVisualStyleBackColor = true;
            this.radioAutoIP.CheckedChanged += new System.EventHandler(this.radioAutoIP_CheckedChanged);
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
            // radioSpecifyDNS
            // 
            this.radioSpecifyDNS.AutoSize = true;
            this.radioSpecifyDNS.Location = new System.Drawing.Point(274, 3);
            this.radioSpecifyDNS.Name = "radioSpecifyDNS";
            this.radioSpecifyDNS.Size = new System.Drawing.Size(125, 28);
            this.radioSpecifyDNS.TabIndex = 19;
            this.radioSpecifyDNS.TabStop = true;
            this.radioSpecifyDNS.Text = "Specify DNS";
            this.radioSpecifyDNS.UseVisualStyleBackColor = true;
            // 
            // radioAutoDNS
            // 
            this.radioAutoDNS.AutoSize = true;
            this.radioAutoDNS.Location = new System.Drawing.Point(21, 3);
            this.radioAutoDNS.Name = "radioAutoDNS";
            this.radioAutoDNS.Size = new System.Drawing.Size(145, 28);
            this.radioAutoDNS.TabIndex = 18;
            this.radioAutoDNS.TabStop = true;
            this.radioAutoDNS.Text = "Automatic DNS";
            this.radioAutoDNS.UseVisualStyleBackColor = true;
            this.radioAutoDNS.CheckedChanged += new System.EventHandler(this.radioAutoDNS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipAddressInput
            // 
            this.ipAddressInput.Location = new System.Drawing.Point(231, 91);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(170, 30);
            this.ipAddressInput.TabIndex = 13;
            this.ipAddressInput.TextChanged += new System.EventHandler(this.ipAddressInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Subnet Mask:";
            // 
            // subnetMaskInput
            // 
            this.subnetMaskInput.Location = new System.Drawing.Point(231, 143);
            this.subnetMaskInput.Name = "subnetMaskInput";
            this.subnetMaskInput.Size = new System.Drawing.Size(170, 30);
            this.subnetMaskInput.TabIndex = 15;
            this.subnetMaskInput.TextChanged += new System.EventHandler(this.subnetMaskInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Default Gateway:";
            // 
            // defaultGatewayInput
            // 
            this.defaultGatewayInput.Location = new System.Drawing.Point(231, 199);
            this.defaultGatewayInput.Name = "defaultGatewayInput";
            this.defaultGatewayInput.Size = new System.Drawing.Size(170, 30);
            this.defaultGatewayInput.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "DNS address:";
            // 
            // dnsAddressInput
            // 
            this.dnsAddressInput.Location = new System.Drawing.Point(231, 325);
            this.dnsAddressInput.Name = "dnsAddressInput";
            this.dnsAddressInput.Size = new System.Drawing.Size(170, 30);
            this.dnsAddressInput.TabIndex = 19;
            this.dnsAddressInput.TextChanged += new System.EventHandler(this.dnsAddressInput_TextChanged);
            // 
            // btnApplyDHCP
            // 
            this.btnApplyDHCP.Location = new System.Drawing.Point(41, 377);
            this.btnApplyDHCP.Name = "btnApplyDHCP";
            this.btnApplyDHCP.Size = new System.Drawing.Size(75, 30);
            this.btnApplyDHCP.TabIndex = 20;
            this.btnApplyDHCP.Text = "Apply";
            this.btnApplyDHCP.UseVisualStyleBackColor = true;
            this.btnApplyDHCP.Click += new System.EventHandler(this.btnApplyDHCP_Click);
            // 
            // btnCreateNewProf
            // 
            this.btnCreateNewProf.Location = new System.Drawing.Point(231, 377);
            this.btnCreateNewProf.Name = "btnCreateNewProf";
            this.btnCreateNewProf.Size = new System.Drawing.Size(134, 30);
            this.btnCreateNewProf.TabIndex = 21;
            this.btnCreateNewProf.Text = "Create New Profile";
            this.btnCreateNewProf.UseVisualStyleBackColor = true;
            this.btnCreateNewProf.Click += new System.EventHandler(this.btnCreateNewProf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "NIC Card:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 32);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(EZNIC.Program);
            // 
            // DHCPControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource programBindingSource;
    }
}
