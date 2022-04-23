
namespace PlazzaDebugger
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Network = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Delete_Temp = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC-NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "You\'re encoutring a problem with...";
            // 
            // Network
            // 
            this.Network.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.Network.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Network.FlatAppearance.BorderSize = 0;
            this.Network.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Network.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Network.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Network.Image = global::PlazzaDebugger.Properties.Resources.Network;
            this.Network.Location = new System.Drawing.Point(12, 78);
            this.Network.Name = "Network";
            this.Network.Size = new System.Drawing.Size(241, 120);
            this.Network.TabIndex = 1;
            this.Network.Text = "Network and Connection?";
            this.Network.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Network.UseVisualStyleBackColor = false;
            this.Network.Click += new System.EventHandler(this.Network_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = global::PlazzaDebugger.Properties.Resources.teams;
            this.button2.Location = new System.Drawing.Point(269, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 120);
            this.button2.TabIndex = 7;
            this.button2.Text = "Microsoft Teams";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Image = global::PlazzaDebugger.Properties.Resources.firefox_64;
            this.button3.Location = new System.Drawing.Point(530, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 120);
            this.button3.TabIndex = 8;
            this.button3.Text = "Tools not working on browser";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Delete_Temp
            // 
            this.Delete_Temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.Delete_Temp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Delete_Temp.FlatAppearance.BorderSize = 0;
            this.Delete_Temp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Delete_Temp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Temp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete_Temp.Image = global::PlazzaDebugger.Properties.Resources.trash;
            this.Delete_Temp.Location = new System.Drawing.Point(530, 219);
            this.Delete_Temp.Name = "Delete_Temp";
            this.Delete_Temp.Size = new System.Drawing.Size(241, 120);
            this.Delete_Temp.TabIndex = 11;
            this.Delete_Temp.Text = "Delete Temp Files";
            this.Delete_Temp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Delete_Temp.UseVisualStyleBackColor = false;
            this.Delete_Temp.Click += new System.EventHandler(this.Delete_Temp_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Image = global::PlazzaDebugger.Properties.Resources.Cred;
            this.button5.Location = new System.Drawing.Point(269, 219);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(241, 120);
            this.button5.TabIndex = 10;
            this.button5.Text = "Clear Credential Manager";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Image = global::PlazzaDebugger.Properties.Resources.hard_drive;
            this.button6.Location = new System.Drawing.Point(12, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(241, 120);
            this.button6.TabIndex = 9;
            this.button6.Text = "Clean Disk Space ";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Delete_Temp);
            this.Controls.Add(this.Network);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "Network";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Network;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Delete_Temp;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}