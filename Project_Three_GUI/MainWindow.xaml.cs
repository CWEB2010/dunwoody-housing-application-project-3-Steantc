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
        public Boolean UsernameCheck = false;
        public Boolean PasswordCheck = false;

        public string GenericUser = "Home";
        public string GenericPass = "1234";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Exit_Button(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
        private void selection_btn_click(object sender, RoutedEventArgs e)
        {
            if (username.Text == GenericUser && password.Text == GenericPass)
            {
                Selection_Window selectionWindow = new Selection_Window();
                selectionWindow.Show();
                this.Close();
            }
            else
            {
                username.Clear();
                password.Clear();
                introText.Content = "Wrong Username or Password, please try again";
                introText.Foreground = Brushes.Red;
            }
        }
    }
}
