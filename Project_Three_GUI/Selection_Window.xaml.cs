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
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class Selection_Window : Window
    {
        public Selection_Window()
        {
            InitializeComponent();
        }
        private void Exit_Button(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void newResident_btn_click(object sender, RoutedEventArgs e)
        {
            New_Resident newResident = new New_Resident();
            newResident.Show();
            this.Close();
        }

        private void residentSearch_btn_click(object sender, RoutedEventArgs e)
        {
            Resident_Search residentSearch = new Resident_Search();
            residentSearch.Show();
            this.Close();
        }
    }
}
