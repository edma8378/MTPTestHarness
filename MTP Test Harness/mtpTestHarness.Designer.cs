namespace MTP_Test_Harness
{
    partial class mtpTestHarness
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
            this.test1B = new System.Windows.Forms.Button();
            this.test2B = new System.Windows.Forms.Button();
            this.test4B = new System.Windows.Forms.Button();
            this.test3B = new System.Windows.Forms.Button();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.connectB = new System.Windows.Forms.Button();
            this.deviceLB = new System.Windows.Forms.Label();
            this.launchB = new System.Windows.Forms.Button();
            this.disconnectB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test1B
            // 
            this.test1B.Location = new System.Drawing.Point(10, 64);
            this.test1B.Name = "test1B";
            this.test1B.Size = new System.Drawing.Size(78, 23);
            this.test1B.TabIndex = 0;
            this.test1B.Text = "Test 1";
            this.test1B.UseVisualStyleBackColor = true;
            this.test1B.Click += new System.EventHandler(this.test1B_Click);
            // 
            // test2B
            // 
            this.test2B.Location = new System.Drawing.Point(103, 64);
            this.test2B.Name = "test2B";
            this.test2B.Size = new System.Drawing.Size(78, 23);
            this.test2B.TabIndex = 1;
            this.test2B.Text = "Test 2";
            this.test2B.UseVisualStyleBackColor = true;
            this.test2B.Click += new System.EventHandler(this.test2B_Click);
            // 
            // test4B
            // 
            this.test4B.Location = new System.Drawing.Point(103, 93);
            this.test4B.Name = "test4B";
            this.test4B.Size = new System.Drawing.Size(78, 23);
            this.test4B.TabIndex = 3;
            this.test4B.Text = "Test 4";
            this.test4B.UseVisualStyleBackColor = true;
            this.test4B.Click += new System.EventHandler(this.test4B_Click);
            // 
            // test3B
            // 
            this.test3B.Location = new System.Drawing.Point(10, 93);
            this.test3B.Name = "test3B";
            this.test3B.Size = new System.Drawing.Size(78, 23);
            this.test3B.TabIndex = 2;
            this.test3B.Text = "Test 3";
            this.test3B.UseVisualStyleBackColor = true;
            this.test3B.Click += new System.EventHandler(this.test3B_Click);
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(10, 10);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(171, 22);
            this.addressTB.TabIndex = 4;
            this.addressTB.Text = "address";
            // 
            // connectB
            // 
            this.connectB.Location = new System.Drawing.Point(187, 9);
            this.connectB.Name = "connectB";
            this.connectB.Size = new System.Drawing.Size(88, 23);
            this.connectB.TabIndex = 5;
            this.connectB.Text = "Connect";
            this.connectB.UseVisualStyleBackColor = true;
            this.connectB.Click += new System.EventHandler(this.connectB_Click);
            // 
            // deviceLB
            // 
            this.deviceLB.BackColor = System.Drawing.Color.Red;
            this.deviceLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deviceLB.Location = new System.Drawing.Point(10, 38);
            this.deviceLB.Name = "deviceLB";
            this.deviceLB.Size = new System.Drawing.Size(171, 20);
            this.deviceLB.TabIndex = 6;
            this.deviceLB.Text = "Device Not Connected";
            // 
            // launchB
            // 
            this.launchB.Location = new System.Drawing.Point(187, 64);
            this.launchB.Name = "launchB";
            this.launchB.Size = new System.Drawing.Size(88, 52);
            this.launchB.TabIndex = 7;
            this.launchB.Text = "Launch ACE";
            this.launchB.UseVisualStyleBackColor = true;
            this.launchB.Click += new System.EventHandler(this.launchB_Click);
            // 
            // disconnectB
            // 
            this.disconnectB.Enabled = false;
            this.disconnectB.Location = new System.Drawing.Point(187, 35);
            this.disconnectB.Name = "disconnectB";
            this.disconnectB.Size = new System.Drawing.Size(88, 23);
            this.disconnectB.TabIndex = 8;
            this.disconnectB.Text = "Disconnect";
            this.disconnectB.UseVisualStyleBackColor = true;
            this.disconnectB.Click += new System.EventHandler(this.disconnectB_Click);
            // 
            // mtpTestHarness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 124);
            this.Controls.Add(this.disconnectB);
            this.Controls.Add(this.launchB);
            this.Controls.Add(this.deviceLB);
            this.Controls.Add(this.connectB);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.test4B);
            this.Controls.Add(this.test3B);
            this.Controls.Add(this.test2B);
            this.Controls.Add(this.test1B);
            this.Name = "mtpTestHarness";
            this.Text = "MTP Test Harness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button test1B;
        private System.Windows.Forms.Button test2B;
        private System.Windows.Forms.Button test4B;
        private System.Windows.Forms.Button test3B;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Button connectB;
        private System.Windows.Forms.Label deviceLB;
        private System.Windows.Forms.Button launchB;
        private System.Windows.Forms.Button disconnectB;
    }
}

