
namespace PlazzaDebugger
{
    partial class Back
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Back));
            this.TEC = new System.Windows.Forms.Button();
            this.DNS = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEC
            // 
            this.TEC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.TEC.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TEC.FlatAppearance.BorderSize = 0;
            this.TEC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.TEC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TEC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TEC.Image = global::PlazzaDebugger.Properties.Resources.TEC;
            this.TEC.Location = new System.Drawing.Point(569, 75);
            this.TEC.Name = "TEC";
            this.TEC.Size = new System.Drawing.Size(241, 120);
            this.TEC.TabIndex = 2;
            this.TEC.Text = "Generate Network TEC";
            this.TEC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TEC.UseVisualStyleBackColor = false;
            this.TEC.Click += new System.EventHandler(this.TEC_Click);
            // 
            // DNS
            // 
            this.DNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.DNS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DNS.FlatAppearance.BorderSize = 0;
            this.DNS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.DNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DNS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DNS.Image = ((System.Drawing.Image)(resources.GetObject("DNS.Image")));
            this.DNS.Location = new System.Drawing.Point(37, 75);
            this.DNS.Name = "DNS";
            this.DNS.Size = new System.Drawing.Size(241, 120);
            this.DNS.TabIndex = 3;
            this.DNS.Text = "Change DNS to Automatic";
            this.DNS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DNS.UseVisualStyleBackColor = false;
            this.DNS.Click += new System.EventHandler(this.DNS_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.Reset.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Reset.FlatAppearance.BorderSize = 0;
            this.Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Reset.Image = global::PlazzaDebugger.Properties.Resources.Network;
            this.Reset.Location = new System.Drawing.Point(304, 75);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(241, 120);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Reset Network Adapters";
            this.Reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Reset.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::PlazzaDebugger.Properties.Resources.home;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 52);
            this.button1.TabIndex = 5;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(894, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.DNS);
            this.Controls.Add(this.TEC);
            this.Name = "Back";
            this.Text = "Networks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TEC;
        private System.Windows.Forms.Button DNS;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button button1;
    }
}