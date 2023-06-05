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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SurveryPro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Event Listener that when submit button is clicked the user is taken to the Survey Page
        private void btnSurvey_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            SurveyPage serveyObj = new SurveyPage();
            main.Close();
            serveyObj.Show();
        }

        //Event Listener that when Results button is clicked the user is taken to the Results Page
        private void btnResults_Click(object sender, RoutedEventArgs e)
        {

            Window1 results = new Window1();
            results.Show();

        }
    }
}
