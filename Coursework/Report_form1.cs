using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace Coursework { 


    public partial class Report_form : Form
    {
       


        public void Listchild2()
        {
            string to_find = "Child";

            string json = Utility_visitors.Read();
            try
            {


                List<Visitor> lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
                
                List<Visitor> the_list = new List<Visitor>();
                List<int> the_list_count = new List<int>();
               

                for (var i = 0; i < lst.Count; i++)
                {


                    int countup = 0;

                    for (var j = 0; j < lst.Count; j++)
                    {
                        if (lst[i].Data == lst[j].Data && lst[j].Age == to_find)
                        {
                            countup += 1;

                        }

                    }
                    if (the_list.Count == 0)
                    {
                        the_list.Add(lst[i]);
                        the_list_count.Add(countup);

                    }

                    int theclick = 0;
                    for (var j = 0; j < the_list.Count; j++)
                    {
                        if (lst[i].Data == the_list[j].Data)
                        {
                      
                            theclick = 1;
                       

                        }

                    }
                    if (theclick == 0)
                    {
                        the_list.Add(lst[i]);
                        the_list_count.Add(countup);
                    }


                }
                List<Report> the_list_for_grid = new List<Report>();





                for (var j = 0; j < the_list.Count; j++)
                {

               
                    DateTime dateTimeObj = DateTime.Parse(the_list[j].Data);
                    the_list_for_grid.Add(new Report { ID = (j + 1).ToString(), Data = dateTimeObj.ToString("d"), Count = the_list_count[j] });
                    this.chart1.Series["Child count"].Points.AddXY(dateTimeObj.ToString("d"), the_list_count[j]);

                }
                dataGridView2.DataSource = the_list_for_grid;
                
            }
            catch (Exception ex)
            {

            }

        }
        public void Listadult2()
        {
            string to_find = "Adult";

            string json = Utility_visitors.Read();
            try
            {


                List<Visitor> lst = JsonConvert.DeserializeObject<List<Visitor>>(json);

                List<Visitor> the_list = new List<Visitor>();
                List<int> the_list_count = new List<int>();


                for (var i = 0; i < lst.Count; i++)
                {


                    int countup = 0;

                    for (var j = 0; j < lst.Count; j++)
                    {
                        if (lst[i].Data == lst[j].Data && lst[j].Age == to_find)
                        {
                            countup += 1;

                        }

                    }
                    if (the_list.Count == 0)
                    {
                        the_list.Add(lst[i]);
                        the_list_count.Add(countup);

                    }

                    int theclick = 0;
                    for (var j = 0; j < the_list.Count; j++)
                    {
                        if (lst[i].Data == the_list[j].Data)
                        {
                          
                            theclick = 1;
                        

                        }

                    }
                    if (theclick == 0)
                    {
                        the_list.Add(lst[i]);
                        the_list_count.Add(countup);
                    }


                }
                List<Report> the_list_for_grid = new List<Report>();





                for (var j = 0; j < the_list.Count; j++)
                {

                    DateTime dateTimeObj = DateTime.Parse(the_list[j].Data);
                    the_list_for_grid.Add(new Report { ID = (j + 1).ToString(), Data= dateTimeObj.ToString("d"), Count = the_list_count[j] });
                    this.chart1.Series["Adult count"].Points.AddXY(dateTimeObj.ToString("d"), the_list_count[j]);

                }
                dataGridView3.DataSource = the_list_for_grid;










            }
            catch (Exception ex)
            {

            }

        }





        public void List2()
        {
         
            string json = Utility_visitors.Read();
            try
            {


                List<Visitor> lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
         
                List<Visitor> the_list = new List<Visitor>();
                List<int> the_list_count = new List<int>();
      
                
                for (var i = 0; i < lst.Count; i++)
                {
                    
                    
                        int countup = 0;

                        for (var j = 1; j < lst.Count; j++)
                        {
                            if (lst[i].Data== lst[j].Data)
                            {
                                countup += 1;

                            }

                        }
                        if (the_list.Count == 0)
                        {
                            the_list.Add(lst[i]);
                            the_list_count.Add(countup + 1);

                        }

                        int theclick = 0;
                        for (var j = 0; j < the_list.Count; j++)
                        {
                            if (lst[i].Data== the_list[j].Data)
                            {
                       
                                theclick = 1;
                  
                            }

                        }
                        if (theclick == 0)
                        {
                            the_list.Add(lst[i]);
                            the_list_count.Add(countup);
                        }
                    

                }
                List<Report> the_list_for_grid = new List<Report>();
                



                for (var j = 0; j < the_list.Count; j++)
                {

                    DateTime dateTimeObj = DateTime.Parse(the_list[j].Data);
                    the_list_for_grid.Add(new Report {ID=(j+1).ToString(),Data=dateTimeObj.ToString("d"),Count= the_list_count[j]});
                    this.chart1.Series["Number of visitor per day"].Points.AddXY(dateTimeObj.ToString("d"), the_list_count[j]);

                }
                dataGridView1.DataSource=the_list_for_grid;









            }
            catch (Exception ex)
            {

            }

        }
        public Report_form()
        {
            InitializeComponent();
            Listchild2();
            Listadult2();
            List2();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        public static string Bubble_Sort(string for_Grid_Report_Week)
        {
            List<week_chart> lst = JsonConvert.DeserializeObject<List<week_chart>>(for_Grid_Report_Week);
            List<week_chart> big = new List<week_chart>();
            for (int i = lst.Count - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (lst[j].price > lst[j + 1].price)
                    {
                        big.Clear();
                        big.Add(lst[j]);
                        lst[j] = lst[j + 1];
                        lst[j + 1] = big[0];
                    }

                }
            }
            return JsonConvert.SerializeObject(lst);
        }
        //public void main_report()
        //{
        //    chart1.Series["price"].Points.Clear();

        //    string json = Utility_visitors.Read();
        //    if (json != null && json != "")
        //    {
        //        List<Visitor> lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
        //        List<string> day_in_week = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        //        List<week_chart> the_list_for_grid1 = new List<week_chart>();
        //        for (var j = 0; j < day_in_week.Count; j++)
        //        {
        //            int the_count = 0;
        //            int the_earning = 0;
        //            for (var i = 0; i < lst.Count; i++)
        //            {
        //                DateTime dateTimeObj = DateTime.Parse(lst[i].Data);
        //                if (day_in_week[j] == dateTimeObj.DayOfWeek.ToString())
        //                {
        //                    the_count += 1;
        //                    the_earning = the_earning + lst[i].Price;
        //                }
        //            }
        //            if (!Ascending.Checked)
        //            {
        //                this.chart1.Series["Earning"].Points.AddXY(day_in_week[j], the_earning);
        //            }
        //            the_list_for_grid1.Add(new week_chart { ID = (j + 1).ToString(), Day = day_in_week[j], Count = the_count, price = the_earning });
        //        }
        //        if (!Ascending.Checked)
        //        {
        //            dataGridView1.DataSource = the_list_for_grid1;
        //        }
        //        else if (Ascending.Checked)
        //        {
        //            chart1.Series["Earning"].Points.Clear();
        //            string data = JsonConvert.SerializeObject(the_list_for_grid1);
        //            data = Bubble_Sort(data);
        //            List<week_chart> lst2 = JsonConvert.DeserializeObject<List<week_chart>>(data);
        //            dataGridView1.DataSource = lst2;
        //            dataGridView1.Refresh();
        //            for (var i = 0; i < lst2.Count; i++)
        //            {
        //                this.chart1.Series["Earning"].Points.AddXY(lst2[i].Day, lst2[i].price);
        //            }
        //        }
        //    }
        //}

        private class week_chart
        {
            public double price { get; internal set; }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            weekly_report form = new weekly_report();
            form.Show();
        }


        //private void export_Click(object sender, EventArgs e)
        //{

        //        //Build the CSV file data as a Comma separated string.
        //        string csv = string.Empty;

        //        //Add the Header row for CSV file.
        //     foreach (DataGridViewColumn column in _l.Columns)
        //        {
        //            csv += column.HeaderText + ',';
        //        }

        //        //Add new line.
        //        csv += "\r\n";

        //        //Adding the Rows
        //      foreach (DataGridViewRow row in dataGridView1.Rows)
        //        {


        //      foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                //Add the Data rows.
        //                csv += cell.Value.ToString().Replace(",", ";") + ',';
        //            }

        //            //Add new line.
        //            csv += "\r\n";
        //        }

        //        //Exporting to CSV.
        //        string folderPath = "D:\\projects\\Coursework\\Coursework\\CSV";
        //        File.WriteAllText(folderPath + "DataGridViewExport.csv", csv);
        //    }




    }
    }
 
