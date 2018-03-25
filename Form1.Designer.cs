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
            this.dhcpControl2 = new EZNIC.DHCPControl();
            this.profilesControl1 = new EZNIC.ProfilesControl();
            this.panel2.SuspendLayout();
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
            this.btnDHCP.Click += new System.EventHandler(this.btnDHCP_Click);
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
            // dhcpControl2
            // 
            this.dhcpControl2.BackColor = System.Drawing.Color.White;
            this.dhcpControl2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dhcpControl2.Location = new System.Drawing.Point(15, 115);
            this.dhcpControl2.Margin = new System.Windows.Forms.Padding(0);
            this.dhcpControl2.Name = "dhcpControl2";
            this.dhcpControl2.Size = new System.Drawing.Size(476, 410);
            this.dhcpControl2.TabIndex = 4;
            this.dhcpControl2.Load += new System.EventHandler(this.dhcpControl2_Load);
            // 
            // profilesControl1
            // 
            this.profilesControl1.BackColor = System.Drawing.Color.White;
            this.profilesControl1.Location = new System.Drawing.Point(24, 126);
            this.profilesControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilesControl1.Name = "profilesControl1";
            this.profilesControl1.Size = new System.Drawing.Size(476, 410);
            this.profilesControl1.TabIndex = 5;
            this.profilesControl1.Load += new System.EventHandler(this.profilesControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.profilesControl1);
            this.Controls.Add(this.dhcpControl2);
            this.Controls.Add(this.btnProfiles);
            this.Controls.Add(this.btnDHCP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnDHCP;
        private System.Windows.Forms.Button btnProfiles;
       // private DHCPControl dhcpControl1;
        private DHCPControl dhcpControl2;
        private ProfilesControl profilesControl1;
    }
}

