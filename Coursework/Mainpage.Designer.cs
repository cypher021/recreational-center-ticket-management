
namespace Coursework
{
    partial class Main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_page));
            this.label1 = new System.Windows.Forms.Label();
            this.SettingPage_btn = new System.Windows.Forms.Button();
            this.VisitorPage_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label1.Font = new System.Drawing.Font("Papyrus", 34F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(445, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recreational center ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SettingPage_btn
            // 
            this.SettingPage_btn.BackColor = System.Drawing.Color.IndianRed;
            this.SettingPage_btn.Font = new System.Drawing.Font("Papyrus", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingPage_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingPage_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SettingPage_btn.Location = new System.Drawing.Point(11, 147);
            this.SettingPage_btn.Margin = new System.Windows.Forms.Padding(2);
            this.SettingPage_btn.Name = "SettingPage_btn";
            this.SettingPage_btn.Size = new System.Drawing.Size(301, 141);
            this.SettingPage_btn.TabIndex = 3;
            this.SettingPage_btn.Text = "Setting Page";
            this.SettingPage_btn.UseVisualStyleBackColor = false;
            this.SettingPage_btn.Click += new System.EventHandler(this.Pricebtn_Click);
            // 
            // VisitorPage_btn
            // 
            this.VisitorPage_btn.BackColor = System.Drawing.Color.IndianRed;
            this.VisitorPage_btn.Font = new System.Drawing.Font("Papyrus", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitorPage_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VisitorPage_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VisitorPage_btn.Location = new System.Drawing.Point(11, 312);
            this.VisitorPage_btn.Margin = new System.Windows.Forms.Padding(2);
            this.VisitorPage_btn.Name = "VisitorPage_btn";
            this.VisitorPage_btn.Size = new System.Drawing.Size(301, 125);
            this.VisitorPage_btn.TabIndex = 4;
            this.VisitorPage_btn.Text = "Visitors Page";
            this.VisitorPage_btn.UseVisualStyleBackColor = false;
            this.VisitorPage_btn.Click += new System.EventHandler(this.Visitorbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label2.Font = new System.Drawing.Font("Papyrus", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "By 19031846";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Image = global::Coursework.Properties.Resources.namaste;
            this.pictureBox1.Location = new System.Drawing.Point(-11, -151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1060, 829);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(680, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VisitorPage_btn);
            this.Controls.Add(this.SettingPage_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Main_page";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Recreational Centre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_page_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SettingPage_btn;
        private System.Windows.Forms.Button VisitorPage_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}