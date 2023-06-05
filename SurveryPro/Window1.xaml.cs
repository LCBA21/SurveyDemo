using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace SurveryPro
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();


            Total();


            Oldest();


            Youngest();

        }

        public void Total() 
        {
            //To display Total Number of Surveys
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    string query = "SELECT COUNT(ID)  FROM  Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTable.Columns.Add("Total");
                    dataGrid.ItemsSource = dataTable.DefaultView;

                    connection.Close();
                    //MessageBox.Show("Personal Details Captured!!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        public void Oldest() 
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True";
            //To display Oldest Age of Surveys
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    string query = "SELECT MAX(Age)  FROM  Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTable.Columns.Add("Oldest");
                    dataGrid.ItemsSource = dataTable.DefaultView;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        public void Youngest() 
        {

            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    string query = "SELECT COUNT(ID)  FROM  Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTable.Columns.Add("Total");
                    dataGrid.ItemsSource = dataTable.DefaultView;

                    connection.Close();
                    //MessageBox.Show("Personal Details Captured!!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    string query = "SELECT MAX(Age)  FROM  Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTable.Columns.Add("Oldest");
                    dataGrid.ItemsSource = dataTable.DefaultView;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    string query = "SELECT MIN(Age)  FROM  Users";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTable.Columns.Add("Youngest");
                    dataGrid.ItemsSource = dataTable.DefaultView;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




            //

            //To display Youngest Age of Surveys
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    string query = "SELECT Total,AverageAge,Oldest,Youngest  FROM  tblResults";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGrid.ItemsSource = dataTable.DefaultView;
                    dataGrid.Items.Add(dataTable.DefaultView);


                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }



    }



     
}
