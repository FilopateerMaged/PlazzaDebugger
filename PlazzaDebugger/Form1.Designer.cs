
namespace PlazzaDebugger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HelloLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.homePanel = new System.Windows.Forms.Panel();
            this.MPA = new System.Windows.Forms.Button();
            this.MYTOOLS = new System.Windows.Forms.Button();
            this.Qualiparc = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HelloLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.HelloLabel.Location = new System.Drawing.Point(0, -3);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(185, 86);
            this.HelloLabel.TabIndex = 4;
            this.HelloLabel.Text = "Hello";
            this.HelloLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::PlazzaDebugger.Properties.Resources.obs_it_1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 612);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 62);
            this.button3.TabIndex = 1;
            this.button3.Text = "       IT SUPPORT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.Qualiparc);
            this.panel2.Controls.Add(this.MYTOOLS);
            this.panel2.Controls.Add(this.MPA);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(50, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 674);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Transparent;
            this.button9.Image = global::PlazzaDebugger.Properties.Resources.Pki;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(2, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(183, 56);
            this.button9.TabIndex = 2;
            this.button9.Text = "Unlock";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.HelloLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(185, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 83);
            this.panel1.TabIndex = 12;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(169, -3);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(451, 86);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "AD\\NBHS9355";
            // 
            // homePanel
            // 
            this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel.Location = new System.Drawing.Point(185, 83);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(815, 591);
            this.homePanel.TabIndex = 13;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Home_Paint);
            // 
            // MPA
            // 
            this.MPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.MPA.FlatAppearance.BorderSize = 0;
            this.MPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.MPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MPA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MPA.ForeColor = System.Drawing.Color.Transparent;
            this.MPA.Image = global::PlazzaDebugger.Properties.Resources.Pki;
            this.MPA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MPA.Location = new System.Drawing.Point(2, 62);
            this.MPA.Name = "MPA";
            this.MPA.Size = new System.Drawing.Size(183, 56);
            this.MPA.TabIndex = 3;
            this.MPA.Text = "Unlock";
            this.MPA.UseVisualStyleBackColor = false;
            // 
            // MYTOOLS
            // 
            this.MYTOOLS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MYTOOLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.MYTOOLS.FlatAppearance.BorderSize = 0;
            this.MYTOOLS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.MYTOOLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MYTOOLS.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MYTOOLS.ForeColor = System.Drawing.Color.Transparent;
            this.MYTOOLS.Image = global::PlazzaDebugger.Properties.Resources.Pki;
            this.MYTOOLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MYTOOLS.Location = new System.Drawing.Point(0, 124);
            this.MYTOOLS.Name = "MYTOOLS";
            this.MYTOOLS.Size = new System.Drawing.Size(183, 56);
            this.MYTOOLS.TabIndex = 4;
            this.MYTOOLS.Text = "Unlock";
            this.MYTOOLS.UseVisualStyleBackColor = false;
            // 
            // Qualiparc
            // 
            this.Qualiparc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Qualiparc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.Qualiparc.FlatAppearance.BorderSize = 0;
            this.Qualiparc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Qualiparc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Qualiparc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Qualiparc.ForeColor = System.Drawing.Color.Transparent;
            this.Qualiparc.Image = global::PlazzaDebugger.Properties.Resources.Pki;
            this.Qualiparc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qualiparc.Location = new System.Drawing.Point(0, 186);
            this.Qualiparc.Name = "Qualiparc";
            this.Qualiparc.Size = new System.Drawing.Size(183, 56);
            this.Qualiparc.TabIndex = 5;
            this.Qualiparc.Text = "Unlock";
            this.Qualiparc.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 674);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(112, 39);
            this.Name = "Form1";
            this.Text = "Debugger";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button Qualiparc;
        private System.Windows.Forms.Button MYTOOLS;
        private System.Windows.Forms.Button MPA;
    }
}

