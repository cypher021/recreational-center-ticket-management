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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string texta = "admin";
        public string textb = "admin123";


        private void Login_Click(object sender, EventArgs e)
        {

            if (username_textBox1.Text == texta && Password_textBox2.Text == textb)
            {Main_page form1 = new Main_page();

             form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check if the blanks are empty or incorrect");
            }

           

        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (username_textBox1.Text == texta && Password_textBox2.Text == textb)
                {
                    Main_page form1 = new Main_page();
                    form1.Show();
                }
                else
            {
                MessageBox.Show("Please check if the blanks are empty or incorrect");
            }
            }
        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (show_box.Checked) {
                Password_textBox2.UseSystemPasswordChar = true;

            }
            else
            {
                Password_textBox2.UseSystemPasswordChar = true ;
            }
        }
    }

    }

