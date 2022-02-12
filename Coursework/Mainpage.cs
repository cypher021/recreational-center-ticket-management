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
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();


        }

       private void Pricebtn_Click(object sender, EventArgs e)
        {
            Pricing_page form1 = new Pricing_page();
            form1.Show();
            //this.Hide();
        }

        private void Visitorbtn_Click(object sender, EventArgs e)
        {
            Visitors_page form2 = new Visitors_page();
            form2.Show();
            //this.Hide();
        }

        private void Main_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
