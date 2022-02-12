namespace Coursework
{
    partial class weekly_report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblDailyReport = new System.Windows.Forms.Label();
            this.chartWeeklyReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSortbyEarning = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartWeeklyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(88, 108);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 20);
            this.dtTo.TabIndex = 27;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(19, 114);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(63, 13);
            this.lblTo.TabIndex = 26;
            this.lblTo.Text = "Select Date";
            // 
            // lblDailyReport
            // 
            this.lblDailyReport.AutoSize = true;
            this.lblDailyReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDailyReport.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyReport.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDailyReport.Location = new System.Drawing.Point(22, 57);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Size = new System.Drawing.Size(148, 26);
            this.lblDailyReport.TabIndex = 36;
            this.lblDailyReport.Text = "Weekly Report";
            // 
            // chartWeeklyReport
            // 
            chartArea1.Name = "ChartArea1";
            this.chartWeeklyReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartWeeklyReport.Legends.Add(legend1);
            this.chartWeeklyReport.Location = new System.Drawing.Point(12, 134);
            this.chartWeeklyReport.Name = "chartWeeklyReport";
            this.chartWeeklyReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Total Earning";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Total Visitors";
            this.chartWeeklyReport.Series.Add(series1);
            this.chartWeeklyReport.Series.Add(series2);
            this.chartWeeklyReport.Size = new System.Drawing.Size(495, 227);
            this.chartWeeklyReport.TabIndex = 31;
            this.chartWeeklyReport.Text = "chart1";
            // 
            // btnSortbyEarning
            // 
            this.btnSortbyEarning.BackColor = System.Drawing.Color.IndianRed;
            this.btnSortbyEarning.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSortbyEarning.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortbyEarning.ForeColor = System.Drawing.Color.White;
            this.btnSortbyEarning.Location = new System.Drawing.Point(116, 378);
            this.btnSortbyEarning.Name = "btnSortbyEarning";
            this.btnSortbyEarning.Size = new System.Drawing.Size(114, 23);
            this.btnSortbyEarning.TabIndex = 30;
            this.btnSortbyEarning.Text = "Sort by Earning";
            this.btnSortbyEarning.UseVisualStyleBackColor = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.IndianRed;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(22, 378);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 29;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(512, 129);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Earning";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(262, 244);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(512, 108);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // weekly_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 440);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblDailyReport);
            this.Controls.Add(this.chartWeeklyReport);
            this.Controls.Add(this.btnSortbyEarning);
            this.Controls.Add(this.btnLoad);
            this.Name = "weekly_report";
            this.Text = "weekly_report";
            ((System.ComponentModel.ISupportInitialize)(this.chartWeeklyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblDailyReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartWeeklyReport;
        private System.Windows.Forms.Button btnSortbyEarning;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}