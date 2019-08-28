using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealManagement
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            add_meal addmeal = new add_meal();
            addmeal.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            add_member addmember = new add_member();
            addmember.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            add_bazar addbazar = new add_bazar();
            addbazar.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            add_payment addpayment = new add_payment();
            addpayment.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            calculation calc = new calculation();
            calc.Show();
        }
    }
}
