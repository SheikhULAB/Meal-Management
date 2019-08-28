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
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                string MydataConnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=meal_management";
               
                string Query = "insert into signup(user_name ,password ,email) values(' "+textBox1.Text+ " ',' " + textBox2.Text + "',' " + textBox3.Text +"');";
               
                MySqlConnection MyConnection = new MySqlConnection(MydataConnection);
                
                MySqlCommand MyCommand = new MySqlCommand(Query, MyConnection);
                MySqlDataReader MyReader;
                MyConnection.Open();
                MyReader = MyCommand.ExecuteReader();     
                MessageBox.Show("Saved Data successfully");
                while (MyReader.Read())
                {
                }
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
