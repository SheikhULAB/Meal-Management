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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
             signupForm signupForm = new signupForm();
             signupForm.Show();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {

                string MydataConnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=meal_management";

                string Query = "select * from signup where user_name='"+ textBox1.Text+ "' and password='"+ textBox2.Text+"'";

                MySqlConnection MyConnection = new MySqlConnection(MydataConnection);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConnection);
                MySqlDataReader MyReader;
                MyConnection.Open();
                MyReader = MyCommand.ExecuteReader();

                if (MyReader.Read())
                {
                    HomePage homepage = new HomePage();
                    homepage.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Username or Password incorrect");
                }
                MyConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
