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
    public partial class add_meal : Form
    {
       
        public add_meal()
        {
            InitializeComponent();
            LoadDataintoDataGridView();
            
        }

        private void LoadDataintoDataGridView()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=meal_management"; //Set your MySQL connection string here.
            string query = "select * from addmeal"; // set query to fetch data "Select * from  tabelname"; 
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                string MydataConnection = "datasource=127.0.0.1;port=3306;username=root;password=;database=meal_management";

                string Query = "insert into addmeal(Name ,Breakfast,Launch ,Dinner ,Date ) values(' " + comboBox1.Text + " ',' " + comboBox2.Text + "',' " + comboBox3.Text + "','" + comboBox3.Text + "','"+ dateTimePicker1.Value.Date+ "');";

                MySqlConnection MyConnection = new MySqlConnection(MydataConnection);

                MySqlCommand MyCommand = new MySqlCommand(Query, MyConnection);
                MySqlDataReader MyReader;
                MyConnection.Open();
                MyReader = MyCommand.ExecuteReader();
                MessageBox.Show("Saved Data successfully");
                LoadDataintoDataGridView();

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

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
