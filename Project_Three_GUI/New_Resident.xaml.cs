using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Project_Three_GUI.Models;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for New_Resident.xaml
    /// </summary>
    public partial class New_Resident : Window
    {
        DataSource source = new DataSource();
        ObservableCollection<Resident> residentWindow = null;
        Resident aResident;
        public New_Resident()
        {
            InitializeComponent();
            residentWindow = source.readData();
            this.DataContext = residentWindow;
            entry_grid.ItemsSource = residentWindow;
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
            ComboBoxItem residentType = (ComboBoxItem)resident_combo.SelectedItem;

            if (residentType.Content.ToString() == "Student Worker")
            {
                aResident = new Student_Worker(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor_tb.Text), residentType.Content.ToString(), job_tb.Text, Convert.ToDouble(pay_tb.Text));
            }
            if (residentType.Content.ToString() == "ScholarShip Recipent")
            {
                aResident = new Scholarship_Resident(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor_tb.Text), residentType.Content.ToString(), scholarshipType_tb.Text, Convert.ToDouble(scholarshipAmount_tb.Text));
            }
            if (residentType.Content.ToString() == "Student Athlete")
            {
                aResident = new Athlete_Resident(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor_tb.Text), residentType.Content.ToString(), sport_tb.Text, role_tb.Text);
            }
            residentWindow.Add(aResident);
            //source.writeData(residentWindow);
        }
    }
}
