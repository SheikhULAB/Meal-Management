using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MealManagement
{

    public partial class calculation : Form
    {  

        public calculation()
        {
            InitializeComponent();


        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            textBox1.Text = "87.5";
            textBox2.Text = "350";
            textBox3.Text = "1400";
            textBox4.Text = "16";

        }
    }
}
