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

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for New_Resident.xaml
    /// </summary>
    public partial class New_Resident : Window
    {
        public New_Resident()
        {
            InitializeComponent();
        }
        private void Exit_Button(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
        private void Back_Button(object sender, RoutedEventArgs e)
        {
            Selection_Window selectionWindow = new Selection_Window();
            selectionWindow.Show();
            this.Close();
        }

        private void Submit_Resident(object sender, RoutedEventArgs e)
        {

        }
    }
}
