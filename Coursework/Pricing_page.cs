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
    public partial class Pricing_page : Form
    {
        public void DataList()
        {
            string json = Utility.Read();
            try
            {

                List<Price> lst = JsonConvert.DeserializeObject<List<Price>>(json);
                dataGridView1.DataSource = lst;
            }
            catch (Exception ex)
            {

            }

        }
        public Pricing_page()
        {
            InitializeComponent();
            DataList();
        }

        
        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            int number;

            if (Group_box.SelectedIndex == -1 || Duration_box.SelectedIndex == -1 || ChildWeekend_textbox.Text == "" || ChildWeekdays_textbox.Text == "" || AdultWeekend_textbox.Text == "" || AdultWeekdatys_textbox.Text == "" )
            {
                MessageBox.Show("Fields are empyt", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (Int32.TryParse(ChildWeekend_textbox.Text, out number).Equals(false) || Int32.TryParse(ChildWeekdays_textbox.Text, out number).Equals(false) || Int32.TryParse(AdultWeekend_textbox.Text, out number).Equals(false) || Int32.TryParse(AdultWeekdatys_textbox.Text, out number).Equals(false))
            {



                MessageBox.Show("Wrong data type.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string group_number = Group_box.Text;
                string duration = Duration_box.Text;
                int child_weekend = int.Parse(ChildWeekend_textbox.Text);
                int child_weekdays = int.Parse(ChildWeekdays_textbox.Text);
                int adult_weekend = int.Parse(AdultWeekdatys_textbox.Text);
                int adult_weekdays = int.Parse(AdultWeekend_textbox.Text);


                Price p =  new Price();
                p.Group_number = group_number;
                p.Duration = duration;
                p.Child_weekend = child_weekend;
                p.Child_weekdays = child_weekdays;
                p.Adult_weekend = adult_weekend;
                p.Adult_weekdays = adult_weekdays;

                string json = Utility.Read();

                List<Price> lst = new List<Price>();
                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<Price>>(json);
                }
                lst.Add(p);
                string data = JsonConvert.SerializeObject(lst);

                string outfromUtility = Utility.Write(data);
                MessageBox.Show(outfromUtility);
                DataList();
            }
        }

        private void Dltall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deleting all details,proceed?", "Delete Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Utility.DeleteAll();
                DataList();
            }
        }

        private void Dlt_Click(object sender, EventArgs e)
        {
            string json = Utility.Read();

            List<Price> lst = new List<Price>();

            if (json != null && json != "")
            {
                lst = JsonConvert.DeserializeObject<List<Price>>(json);
            }

            string data = JsonConvert.SerializeObject(lst);
            lst.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            data = JsonConvert.SerializeObject(lst);
            string outfromUtility = Utility.Write(data);
            MessageBox.Show(outfromUtility);
            DataList();
        }

        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.ToString() != "-1")
            {
               
                Group_box.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
                Duration_box.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value).ToString();
                ChildWeekend_textbox.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value).ToString();
                ChildWeekdays_textbox.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value).ToString();
                AdultWeekend_textbox.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value).ToString();
                AdultWeekdatys_textbox.Text = (dataGridView1.Rows[e.RowIndex].Cells[5].Value).ToString();


            }
            else
            {

                Group_box.Text = "";
                Duration_box.Text = "";
                ChildWeekend_textbox.Text = "";
                ChildWeekdays_textbox.Text = "";
                AdultWeekend_textbox.Text = "";
                AdultWeekdatys_textbox.Text = "";

            }

        }

  

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            int number;

            if (Group_box.SelectedIndex == -1 || Duration_box.SelectedIndex == -1 || ChildWeekend_textbox.Text == "" || ChildWeekdays_textbox.Text == "" || AdultWeekend_textbox.Text == "" || AdultWeekdatys_textbox.Text == "" )
            {
                MessageBox.Show("Fields are empty, proceed?", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (Int32.TryParse(ChildWeekend_textbox.Text, out number).Equals(false) || Int32.TryParse(ChildWeekdays_textbox.Text, out number).Equals(false) || Int32.TryParse(AdultWeekend_textbox.Text, out number).Equals(false) || Int32.TryParse(AdultWeekdatys_textbox.Text, out number).Equals(false) )
            {

      

                MessageBox.Show("Incorrect Data type.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                string group_number = Group_box.Text;
                string duration = Duration_box.Text;
                int child_weekend = int.Parse(ChildWeekend_textbox.Text);
                int child_weekdays = int.Parse(ChildWeekdays_textbox.Text);
                int adult_weekend = int.Parse(AdultWeekdatys_textbox.Text);
                int adult_weekdays = int.Parse(AdultWeekend_textbox.Text);

                Price p = new Price();
                p.Group_number = group_number;
                p.Duration = duration;
                p.Child_weekend = child_weekend;
                p.Child_weekdays = child_weekdays;
                p.Adult_weekend = adult_weekend;
                p.Adult_weekdays = adult_weekdays;

                string json = Utility.Read();

                List<Price> lst = new List<Price>();

                if (json != null && json != "")
                {
                    lst = JsonConvert.DeserializeObject<List<Price>>(json);
                }
                for (var i = 0; i < lst.Count; i++)
                {



                    if (dataGridView1.CurrentCell.RowIndex == i)
                    {
                        lst[dataGridView1.CurrentCell.RowIndex] = p;
                    }




                }



                string data = JsonConvert.SerializeObject(lst);

                string outfromUtility = Utility.Write(data);
                MessageBox.Show(outfromUtility);
                DataList();
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Group_box.Text = "";
            Duration_box.Text = "";
            ChildWeekend_textbox.Text = "";
            ChildWeekdays_textbox.Text = "";
            AdultWeekend_textbox.Text = "";
            AdultWeekdatys_textbox.Text = "";

        }


    }
}
