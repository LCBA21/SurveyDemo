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
    /// Interaction logic for SurveyPage.xaml
    /// </summary>
    public partial class SurveyPage : Window
    {
        //Declaring Variables Globally
        string surname, FirstName, ContactNumber, Date;
        int Age;




        public SurveyPage()
        {



            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {


            //Calling Methods
            populate();
            Validate();
        }

        //check box Event Listner to insert values into the local database when checked
        private void chkPizza_Checked(object sender, RoutedEventArgs e)
        {

            if (chkPizza.Content.Equals("Pizza"))
            {


                try
                {

                    Window1 screen3 = new Window1();
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Users (Surname,FirstName,contactNumber,Date,FavouriteFood,Age)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtfirstName.Text}','{txtContact.Text}','{txtDate.Text}','{chkPizza.Content}',{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Pizza selected as Favourite!!!");
                    screen3.Show();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                try
                {
                    int count = 0;
                    Window1 screen3 = new Window1();
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO tblResults (Surname,Date,Total,AverageAge,Oldest,Youngest)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtDate.Text}',{count++},{int.Parse(txtAge.Text)/count},{int.Parse(txtAge.Text)},{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                   // MessageBox.Show("Pizza selected as Favourite!!!");
                    screen3.Show();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }



        }

        //check box Event Listner to insert values into the local database when checked

        private void chkPasta_Checked(object sender, RoutedEventArgs e)
        {



            if (chkPasta.Content.Equals("Pasta"))
            {


                try
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Users (Surname,FirstName,contactNumber,Date,FavouriteFood,Age)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtfirstName.Text}','{txtContact.Text}','{txtDate.Text}','{chkPasta.Content}',{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Pasta selected as Favourite!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                try
                {
                    int count = 0;
                    Window1 screen3 = new Window1();
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO tblResults (Surname,Date,Total,AverageAge,Oldest,Youngest)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtDate.Text}',{count++},{int.Parse(txtAge.Text) / count},{int.Parse(txtAge.Text)},{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    // MessageBox.Show("Pizza selected as Favourite!!!");
                    screen3.Show();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }
        }

        //check box Event Listner to insert values into the local database when checked

        private void chkPap_Checked(object sender, RoutedEventArgs e)
        {

            if (chkPap.Content.Equals("Pap and Wors"))
            {


                try
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Users (Surname,FirstName,contactNumber,Date,FavouriteFood,Age)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtfirstName.Text}','{txtContact.Text}','{txtDate.Text}','{chkPap.Content}',{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Pap and Wors selected as Favourite!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                try
                {
                    int count = 0;
                    Window1 screen3 = new Window1();
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO tblResults (Surname,Date,Total,AverageAge,Oldest,Youngest)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtDate.Text}',{count++},{int.Parse(txtAge.Text) / count},{int.Parse(txtAge.Text)},{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    // MessageBox.Show("Pizza selected as Favourite!!!");
                    screen3.Show();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }

        }

        //check box Event Listner to insert values into the local database when checked


        private void chkChicken_Checked(object sender, RoutedEventArgs e)
        {


            if (chkChicken.Content.Equals("Chicken stir fry"))
            {


                try
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Users (Surname,FirstName,contactNumber,Date,FavouriteFood,Age)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtfirstName.Text}','{txtContact.Text}','{txtDate.Text}','{chkChicken.Content}',{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Chicken stir fry selected as Favourite!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                try
                {
                    int count = 0;
                    Window1 screen3 = new Window1();
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO tblResults (Surname,Date,Total,AverageAge,Oldest,Youngest)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtDate.Text}',{count++},{int.Parse(txtAge.Text) / count},{int.Parse(txtAge.Text)},{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    // MessageBox.Show("Pizza selected as Favourite!!!");
                    screen3.Show();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }


        }

        //check box Event Listner to insert values into the local database when checked


        private void chkBeef_Checked(object sender, RoutedEventArgs e)
        {


            if (chkBeef.Content.Equals("Beef stir fry"))
            {


                try
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Users (Surname,FirstName,contactNumber,Date,FavouriteFood,Age)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtfirstName.Text}','{txtContact.Text}','{txtDate.Text}','{chkBeef.Content}',{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Beef stir fry selected as Favourite!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


                try
                {
                    int count = 0;
                    Window1 screen3 = new Window1();
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO tblResults (Surname,Date,Total,AverageAge,Oldest,Youngest)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtDate.Text}',{count++},{int.Parse(txtAge.Text) / count},{int.Parse(txtAge.Text)},{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    // MessageBox.Show("Pizza selected as Favourite!!!");
                    screen3.Show();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }

        }

        //check box Event Listner to insert values into the local database when checked

        private void chkOther_Checked(object sender, RoutedEventArgs e)
        {



            if (chkOther.Content.Equals("Other"))
            {
                try
                {
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO Users (Surname,FirstName,contactNumber,Date,FavouriteFood,Age)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtfirstName.Text}','{txtContact.Text}','{txtDate.Text}','{chkOther.Content}',{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Other selected as Favourite!!!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                try
                {
                    int count = 0;
                    Window1 screen3 = new Window1();
                    SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SurveyDB;Integrated Security=True");

                    connection.Open();
                    SqlCommand command = new SqlCommand($"INSERT INTO tblResults (Surname,Date,Total,AverageAge,Oldest,Youngest)" +
                                           $" VALUES ('{ txtSurname.Text }','{txtDate.Text}',{count++},{int.Parse(txtAge.Text) / count},{int.Parse(txtAge.Text)},{int.Parse(txtAge.Text)})", connection);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                    // MessageBox.Show("Pizza selected as Favourite!!!");
                    screen3.Show();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }


        }

        public void populate() 
        {


            //Try and Catch inside  that prompts user for data and Catches Exception
            try
            {
                //Assigning Objects to User Input
                surname = txtSurname.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\nValue:{txtSurname.Text}");
            }


            //Try and Catch inside  that prompts user for data and Catches Exception
            try
            {
                //Assigning Objects to User Input
                FirstName = txtfirstName.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\nValue:{txtfirstName.Text}");
            }


            //Try and Catch inside  that prompts user for data and Catches Exception
            try
            {
                //Assigning Objects to User Input
                ContactNumber = txtContact.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\nValue:{txtContact.Text}");
            }

            //Try and Catch inside  that prompts user for data and Catches Exception
            try
            {
                //Assigning Objects to User Input
                Age = int.Parse(txtAge.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\nValue:{int.Parse(txtAge.Text)}");
            }


            //Try and Catch inside  that prompts user for data and Catches Exception
            try
            {
                //Assigning Objects to User Input
                Date = txtDate.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + $"\nValue:{txtDate.Text}");
            }

            //Function used to call the Main Screen
            MainWindow main = new MainWindow();
            main.Show();











        }


        //Method to validate textboxes
        public void Validate() 
        {

            if (txtfirstName.Text == null)
            {
                MessageBox.Show("First Name is required");
                return;
            }
            else if (txtSurname.Text == null)
            {
                MessageBox.Show("Surname is required");
                return;
            }   
            else if (txtContact.Text == null)
            {
                MessageBox.Show("Contact Numbers is required");
                return;
            }

            else if (txtAge.Text == null)
            {
                MessageBox.Show("Age is required");
                return;
            }


            else if (txtDate.Text == null)
            {
                MessageBox.Show("Date  is required");
                return;
            }
        }

    }
}
