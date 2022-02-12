using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Coursework
{
    public partial class Visitors_page : Form
    {
        public void DataList()
        {
            
      
            string json = Utility_visitors.Read();
            try
            {


                List<Visitor> lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
                dataGridView1.DataSource = lst;




            }
            catch (Exception ex)
            {

            }

        }
        public Visitors_page()
        {

            InitializeComponent();
            DataList();
        }
     

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            int number;
            
            if (Age_comboBox2.SelectedIndex == -1 || Group_comboBox3.SelectedIndex == -1 || Phone_textBox2.Text == "" || Name_textBox4.Text == "" || Price_textbox.Text == "" )
            {
                MessageBox.Show("Fields are empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (Int32.TryParse(Price_textbox.Text, out number).Equals(false))
            {



                MessageBox.Show("In 'Price' data type is not Integer type.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string id = VisitorID_textBox1.Text;
                string dateTime = dateTimePicker1.Value.ToLongDateString();
                string phone_number = Phone_textBox2.Text;
                string name = Name_textBox4.Text;
                string age = Age_comboBox2.Text;
                string group_number = Group_comboBox3.Text;
                string in_time = dateTimePicker2.Value.ToString();
                string out_time = dateTimePicker3.Value.ToString();
                int price = int.Parse(Price_textbox.Text);
                Update_id();
                Visitor visitor = new Visitor();

                visitor.ID = id;
                visitor.Data = dateTime;
                visitor.PhoneNumber = phone_number;
                visitor.Name = name;
                visitor.Age = age;
                visitor.Group_Number = group_number;
                visitor.In_Time = in_time;
                visitor.Out_Time = out_time;
                visitor.Price = price;
                Update_id();
                string json = Utility_visitors.Read();

                List<Visitor> lst = new List<Visitor>();
                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
                }
                Update_id();
                lst.Add(visitor);
                string data = JsonConvert.SerializeObject(lst);
                string outfromUtility = Utility_visitors.Write(data);
                MessageBox.Show(outfromUtility);
                DataList();
            }
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            VisitorID_textBox1.Text = "";
            Phone_textBox2.Text = "";
            Name_textBox4.Text = "";
            Age_comboBox2.Text = "";
            Group_comboBox3.Text = "";
            Price_textbox.Text = "";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int number;
            
            if (Age_comboBox2.SelectedIndex == -1 || Group_comboBox3.SelectedIndex == -1 || VisitorID_textBox1.Text == "" || Phone_textBox2.Text == "" || Name_textBox4.Text == "" || Price_textbox.Text == "" )
            {
                MessageBox.Show("Fields are empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            
      
            else if (Int32.TryParse(Price_textbox.Text, out number).Equals(false))
            {



                MessageBox.Show("In 'Price' data type is not Integer type.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string id = VisitorID_textBox1.Text;
                string dateTime = dateTimePicker1.Value.ToString();
                string phone_number = Phone_textBox2.Text;
                string name = Name_textBox4.Text;
                string age = Age_comboBox2.Text;
                string group_number = Group_comboBox3.Text;
                string in_time = dateTimePicker2.Value.ToString();
                string out_time = dateTimePicker3.Value.ToString();
                int price = int.Parse(Price_textbox.Text);

                Visitor visitor = new Visitor();
                visitor.ID = id;
                visitor.Data = dateTime;
                visitor.PhoneNumber = phone_number;
                visitor.Name = name;
                visitor.Age = age;
                visitor.Group_Number = group_number;
                visitor.In_Time = in_time;
                visitor.Out_Time = out_time;
                visitor.Price = price;
                string json = Utility_visitors.Read();
                Update_id();
                List<Visitor> lst = new List<Visitor>();

                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
                }
                for (var i = 0; i < lst.Count; i++)
                {



                    if (dataGridView1.CurrentCell.RowIndex == i)
                    {
                        lst[dataGridView1.CurrentCell.RowIndex] = visitor;
                    }




                }


                
                string data = JsonConvert.SerializeObject(lst);
                
                string outfromUtility = Utility_visitors.Write(data);
                MessageBox.Show(outfromUtility);
                DataList();
            }
        }

        private void Dlttablebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting all table, proceed?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Utility_visitors.DeleteAll();
                DataList();
            }
        }

        private void Dltbtn_Click(object sender, EventArgs e)
        {
            string json = Utility_visitors.Read();

            List<Visitor> lst = new List<Visitor>();

            if (json != null && json != "")
            {
                lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
            }

            string data = JsonConvert.SerializeObject(lst);

            lst.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            data = JsonConvert.SerializeObject(lst);

            string outfromUtility = Utility_visitors.Write(data);
            MessageBox.Show(outfromUtility);
            DataList();
        }

   

        private void DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex.ToString() != "-1")
            {
                this.dlt_btn.Text = "Delete Row number: " + (dataGridView1.CurrentCell.RowIndex + 1).ToString();
                this.update_btn.Text = "Update Row : " + (dataGridView1.CurrentCell.RowIndex + 1).ToString();
                VisitorID_textBox1.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value).ToString();
                dateTimePicker1.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value).ToString();
                Phone_textBox2.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value).ToString();
                Name_textBox4.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value).ToString();
                Age_comboBox2.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value).ToString();
                Group_comboBox3.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value).ToString();
                dateTimePicker2.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value).ToString();
                dateTimePicker3.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value).ToString();
                Price_textbox.Text = (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[8].Value).ToString();


            }
            else
            {

                VisitorID_textBox1.Text = "";
                Phone_textBox2.Text = "";
                Name_textBox4.Text = "";
                Age_comboBox2.Text = "";
                Group_comboBox3.Text = "";
                Price_textbox.Text = "";
            }
        }

        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.ToString() != "-1")
            {
                this.dlt_btn.Text = "Delete Row number: " + (e.RowIndex + 1).ToString();
                this.update_btn.Text = "Update Row : " + (e.RowIndex + 1).ToString();

                VisitorID_textBox1.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
                dateTimePicker1.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value).ToString();
                Phone_textBox2.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value).ToString();
                Name_textBox4.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value).ToString();
                Age_comboBox2.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value).ToString();
                Group_comboBox3.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value).ToString();
                Price_textbox.Text = (dataGridView1.Rows[e.RowIndex].Cells[8].Value).ToString();





            }
            else
            {
           
                VisitorID_textBox1.Text = "";
                Phone_textBox2.Text = "";
                Name_textBox4.Text = "";
                Age_comboBox2.Text = "";
                Group_comboBox3.Text = "";
                Price_textbox.Text = "";
            }

        }


        private void Viewreportbtn_Click_1(object sender, EventArgs e)
        {
            Report_form form3 = new Report_form();
            form3.Show();
        }
        public void Update_id()
        {
            string json = Utility_visitors.Read();
            try
            {


                List<Visitor> lst = JsonConvert.DeserializeObject<List<Visitor>>(json);
                for (var j = 0; j < lst.Count; j++)
                {
                    lst[j].ID = (j + 1).ToString();

                }
                string data = JsonConvert.SerializeObject(lst);

                data = JsonConvert.SerializeObject(lst);

                string outfromUtility = Utility_visitors.Write(data);
 




            }
            catch (Exception ex)
            {

            }

        }
          private void Sortbtn_Click_1(object sender, EventArgs e)
        {
            Update_id();
        }

        private void Price_MouseHover(object sender, EventArgs e)
        {
            if (Age_comboBox2.SelectedIndex != -1 || Group_comboBox3.SelectedIndex != -1 || dateTimePicker1.Value.ToString() != "" || dateTimePicker2.Value.ToString() != "" || dateTimePicker3.Value.ToString() != "")
            {

                TimeSpan t = dateTimePicker3.Value - dateTimePicker2.Value;
                int gap_time = t.Hours;
                if (gap_time > 0)
                {

                    string type_of_time = "Whole Day";
                    if (gap_time == 1)
                    {
                        type_of_time = "1" + " hour";
                    }
                    else if (gap_time == 2)
                    {
                        type_of_time = "2" + " hour";
                    }
                    else if (gap_time == 3)
                    {
                        type_of_time = "3" + " hour";
                    }
                    else if (gap_time == 4)
                    {
                        type_of_time = "4" + " hour";
                    }
                    string what_day_of_week = "weekday";
                    if (dateTimePicker1.Value.DayOfWeek.ToString() == "Saturday")
                    {
                        what_day_of_week = "weekend";
                    }
                    string age_number = Age_comboBox2.Text;
                    string group_number = Group_comboBox3.Text;
                    string age_weekend_weekday = age_number + "_" + what_day_of_week;
                    string json = Utility.Read();
                    List<Price> lst = new List<Price>();
                    if (json != null && json != "")
                    {
                        lst = JsonConvert.DeserializeObject<List<Price>>(json);
                    }


                    int what_to_choose = 0;

                    for (var i = 0; i < lst.Count; i++)
                    {

                        if (age_weekend_weekday == "Child_weekday")
                        {
                            what_to_choose = lst[i].Child_weekdays;
                        }
                        else if (age_weekend_weekday == "Child_weekend")
                        {
                            what_to_choose = lst[i].Child_weekend;
                        }
                        else if (age_weekend_weekday == "Adult_weekday")
                        {
                            what_to_choose = lst[i].Adult_weekdays;
                        }
                        else if (age_weekend_weekday == "Adult_weekend")
                        {
                            what_to_choose = lst[i].Adult_weekend;
                        }

                        if (lst[i].Duration == type_of_time && lst[i].Group_number == group_number)
                        {

                            textBox4.Text = what_to_choose.ToString();

                        }

                    }

                }
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Price_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  
    }
}
