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

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string GenericUser = "Home"; //Username
        public string GenericPass = "1234"; //Password
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_Button(object sender, RoutedEventArgs e) //Method for exit button
        {

            this.Close();
        }
        private void selection_btn_click(object sender, RoutedEventArgs e) //Checks username and password
        {
            if (username.Text == GenericUser && password.Text == GenericPass)
            {
                Selection_Window selectionWindow = new Selection_Window(); //If correct moves to slection window
                selectionWindow.Show();
                this.Close();
            }
            else //If wrong prompts user to try again
            {
                username.Clear();
                password.Clear();
                introText.Content = "Wrong Username or Password, please try again";
                introText.Foreground = Brushes.Red;
            }
        }
    }
}
