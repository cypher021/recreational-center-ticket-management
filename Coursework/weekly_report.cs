using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class weekly_report : Form
    {
        public weekly_Report()
        {
            InitializeComponent();
            main_report();
        }
        public static string Bubble_Sort(string for_Grid_Report_Week)
        {
            List<wreport> lst = JsonConvert.DeserializeObject<List<wreport>>(for_Grid_Report_Week);
            List<wreport> big = new List<wreport>();
            for (int i = lst.Count - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (lst[j].Earning > lst[j + 1].Earning)
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
        private static string _location = "visitor_information_json.txt";
        public void main_report()
        {
            chart1.Series["Earning"].Points.Clear();

            string json = AllFunctions.ReadFromText(_location);
            if (json != null && json != "")
            {
                List<Visitor> lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
                List<string> day_in_week = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                List<weekly_Report_> the_list_for_grid1 = new List<wreport>();
                for (var j = 0; j < day_in_week.Count; j++)
                {
                    int the_count = 0;
                    int the_earning = 0;
                    for (var i = 0; i < lst.Count; i++)
                    {
                        DateTime dateTimeObj = DateTime.Parse(lst[i].Data);
                        if (day_in_week[j] == dateTimeObj.DayOfWeek.ToString())
                        {
                            the_count += 1;
                            the_earning = the_earning + lst[i].Price;
                        }
                    }
                    if (!checkBox1.Checked)
                    {
                        this.chart1.Series["Earning"].Points.AddXY(day_in_week[j], the_earning);
                    }
                    the_list_for_grid1.Add(new wreport { ID = (j + 1).ToString(), Day = day_in_week[j], Count = the_count, Earning = the_earning });
                }
     
                else if (checkBox1.Checked)
                {
                    chart1.Series["Earning"].Points.Clear();
                    string data = JsonConvert.SerializeObject(the_list_for_grid1);
                    data = Bubble_Sort(data);
                    List<wreport> lst2 = JsonConvert.DeserializeObject<List<wreport>>(data);
                    for (var i = 0; i < lst2.Count; i++)
                    {
                        this.chart1.Series["Earning"].Points.AddXY(lst2[i].Day, lst2[i].Earning);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            main_report();
        }


