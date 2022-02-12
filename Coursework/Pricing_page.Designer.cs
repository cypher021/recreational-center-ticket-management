
namespace Coursework
{
    partial class Pricing_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pricing_page));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Group_box = new System.Windows.Forms.ComboBox();
            this.Duration_box = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChildWeekend_textbox = new System.Windows.Forms.TextBox();
            this.ChildWeekdays_textbox = new System.Windows.Forms.TextBox();
            this.AdultWeekend_textbox = new System.Windows.Forms.TextBox();
            this.AdultWeekdatys_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Submit_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.Dlt_table_btn = new System.Windows.Forms.Button();
            this.Dlt_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Weekend = new System.Windows.Forms.GroupBox();
            this.WeekDays = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Weekend.SuspendLayout();
            this.WeekDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(17, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duration";
            // 
            // Group_box
            // 
            this.Group_box.FormattingEnabled = true;
            this.Group_box.Items.AddRange(new object[] {
            "0-4",
            "5-10",
            "More than 10"});
            this.Group_box.Location = new System.Drawing.Point(126, 91);
            this.Group_box.Margin = new System.Windows.Forms.Padding(2);
            this.Group_box.Name = "Group_box";
            this.Group_box.Size = new System.Drawing.Size(85, 21);
            this.Group_box.TabIndex = 2;
            // 
            // Duration_box
            // 
            this.Duration_box.FormattingEnabled = true;
            this.Duration_box.Items.AddRange(new object[] {
            "1 hrs",
            "2 hrs",
            "3 hrs"});
            this.Duration_box.Location = new System.Drawing.Point(126, 138);
            this.Duration_box.Margin = new System.Windows.Forms.Padding(2);
            this.Duration_box.Name = "Duration_box";
            this.Duration_box.Size = new System.Drawing.Size(85, 21);
            this.Duration_box.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(15, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Child";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(15, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adult";
            // 
            // ChildWeekend_textbox
            // 
            this.ChildWeekend_textbox.Location = new System.Drawing.Point(95, 24);
            this.ChildWeekend_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.ChildWeekend_textbox.Name = "ChildWeekend_textbox";
            this.ChildWeekend_textbox.Size = new System.Drawing.Size(76, 20);
            this.ChildWeekend_textbox.TabIndex = 9;
            // 
            // ChildWeekdays_textbox
            // 
            this.ChildWeekdays_textbox.Location = new System.Drawing.Point(87, 24);
            this.ChildWeekdays_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.ChildWeekdays_textbox.Name = "ChildWeekdays_textbox";
            this.ChildWeekdays_textbox.Size = new System.Drawing.Size(76, 20);
            this.ChildWeekdays_textbox.TabIndex = 10;
            // 
            // AdultWeekend_textbox
            // 
            this.AdultWeekend_textbox.Location = new System.Drawing.Point(95, 58);
            this.AdultWeekend_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.AdultWeekend_textbox.Name = "AdultWeekend_textbox";
            this.AdultWeekend_textbox.Size = new System.Drawing.Size(76, 20);
            this.AdultWeekend_textbox.TabIndex = 12;
            // 
            // AdultWeekdatys_textbox
            // 
            this.AdultWeekdatys_textbox.Location = new System.Drawing.Point(87, 51);
            this.AdultWeekdatys_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.AdultWeekdatys_textbox.Name = "AdultWeekdatys_textbox";
            this.AdultWeekdatys_textbox.Size = new System.Drawing.Size(76, 20);
            this.AdultWeekdatys_textbox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(422, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 358);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellMouseEnter);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Clear_btn.Location = new System.Drawing.Point(11, 291);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(180, 54);
            this.Clear_btn.TabIndex = 16;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Update_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Update_btn.Location = new System.Drawing.Point(217, 291);
            this.Update_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(180, 54);
            this.Update_btn.TabIndex = 17;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Submit_btn
            // 
            this.Submit_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Submit_btn.Location = new System.Drawing.Point(217, 349);
            this.Submit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Submit_btn.Name = "Submit_btn";
            this.Submit_btn.Size = new System.Drawing.Size(180, 47);
            this.Submit_btn.TabIndex = 18;
            this.Submit_btn.Text = "Submit";
            this.Submit_btn.UseVisualStyleBackColor = false;
            this.Submit_btn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Back_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back_btn.Location = new System.Drawing.Point(11, 452);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(183, 39);
            this.Back_btn.TabIndex = 20;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Dlt_table_btn
            // 
            this.Dlt_table_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Dlt_table_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Dlt_table_btn.Location = new System.Drawing.Point(11, 400);
            this.Dlt_table_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Dlt_table_btn.Name = "Dlt_table_btn";
            this.Dlt_table_btn.Size = new System.Drawing.Size(183, 48);
            this.Dlt_table_btn.TabIndex = 22;
            this.Dlt_table_btn.Text = "Delete Table";
            this.Dlt_table_btn.UseVisualStyleBackColor = false;
            this.Dlt_table_btn.Click += new System.EventHandler(this.Dltall_Click);
            // 
            // Dlt_btn
            // 
            this.Dlt_btn.BackColor = System.Drawing.SystemColors.Window;
            this.Dlt_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Dlt_btn.Location = new System.Drawing.Point(11, 349);
            this.Dlt_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Dlt_btn.Name = "Dlt_btn";
            this.Dlt_btn.Size = new System.Drawing.Size(183, 47);
            this.Dlt_btn.TabIndex = 23;
            this.Dlt_btn.Text = "Delete";
            this.Dlt_btn.UseVisualStyleBackColor = false;
            this.Dlt_btn.Click += new System.EventHandler(this.Dlt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(14, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Child";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(15, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Adult";
            // 
            // Weekend
            // 
            this.Weekend.Controls.Add(this.label4);
            this.Weekend.Controls.Add(this.ChildWeekend_textbox);
            this.Weekend.Controls.Add(this.label5);
            this.Weekend.Controls.Add(this.AdultWeekend_textbox);
            this.Weekend.Location = new System.Drawing.Point(11, 175);
            this.Weekend.Name = "Weekend";
            this.Weekend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Weekend.Size = new System.Drawing.Size(200, 100);
            this.Weekend.TabIndex = 28;
            this.Weekend.TabStop = false;
            this.Weekend.Text = "Weekend";
            // 
            // WeekDays
            // 
            this.WeekDays.Controls.Add(this.ChildWeekdays_textbox);
            this.WeekDays.Controls.Add(this.label10);
            this.WeekDays.Controls.Add(this.label12);
            this.WeekDays.Controls.Add(this.AdultWeekdatys_textbox);
            this.WeekDays.Location = new System.Drawing.Point(217, 175);
            this.WeekDays.Name = "WeekDays";
            this.WeekDays.Size = new System.Drawing.Size(200, 100);
            this.WeekDays.TabIndex = 29;
            this.WeekDays.TabStop = false;
            this.WeekDays.Text = "WeekDays";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SlateGray;
            this.label8.Image = global::Coursework.Properties.Resources._1080495;
            this.label8.Location = new System.Drawing.Point(26, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(354, 52);
            this.label8.TabIndex = 19;
            this.label8.Text = "$$Pricing$$";
            // 
            // Pricing_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1031, 513);
            this.Controls.Add(this.WeekDays);
            this.Controls.Add(this.Weekend);
            this.Controls.Add(this.Dlt_btn);
            this.Controls.Add(this.Dlt_table_btn);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Submit_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Duration_box);
            this.Controls.Add(this.Group_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Pricing_page";
            this.Text = "Pricing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Weekend.ResumeLayout(false);
            this.Weekend.PerformLayout();
            this.WeekDays.ResumeLayout(false);
            this.WeekDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Group_box;
        private System.Windows.Forms.ComboBox Duration_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ChildWeekend_textbox;
        private System.Windows.Forms.TextBox ChildWeekdays_textbox;
        private System.Windows.Forms.TextBox AdultWeekend_textbox;
        private System.Windows.Forms.TextBox AdultWeekdatys_textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Submit_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Button Dlt_table_btn;
        private System.Windows.Forms.Button Dlt_btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Weekend;
        private System.Windows.Forms.GroupBox WeekDays;
    }
}

