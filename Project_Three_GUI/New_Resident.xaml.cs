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
    {   //Reads data and assigns to a Observable list
        DataSource source = new DataSource(); 
        ObservableCollection<Resident> residentWindow = null;

        //Objects for each Resident type
        Resident aResident;
        Student_Worker wResident;
        Scholarship_Resident sResident;
        Athlete_Resident atResident;
        public New_Resident()
        {
            InitializeComponent();
            residentWindow = source.readData(); //Assigns observable list to data grid
            this.DataContext = residentWindow;
            entry_grid.ItemsSource = residentWindow;
        }
        private void Exit_Button(object sender, RoutedEventArgs e) //Method for close button
        {

            this.Close();
        }
        private void Back_Button(object sender, RoutedEventArgs e) //Method for Back Button
        {
            Selection_Window selectionWindow = new Selection_Window();
            selectionWindow.Show();
            this.Close();
        }

        private void Submit_Resident(object sender, RoutedEventArgs e) //Method for reading user inputted data, assigning to Resident type, and writing to the DataSource
        {
            try
            {
                ComboBoxItem residentType = (ComboBoxItem)resident_combo.SelectedItem;
                ComboBoxItem floor = (ComboBoxItem)floor_combo.SelectedItem;
                double fee;

                if (residentType.Content.ToString() == "Student Worker")
                {
                    fee = 1245 - ((Convert.ToDouble(hours_tb.Text) * Convert.ToDouble(pay_tb.Text)) / 2); //Calculates worker Boarding fee
                    aResident = new Student_Worker(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor.Content.ToString()), residentType.Content.ToString(), Convert.ToInt32(room_tb.Text), fee, Convert.ToInt32(hours_tb.Text), Convert.ToDouble(pay_tb.Text));
                    wResident = new Student_Worker(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor.Content.ToString()), residentType.Content.ToString(), Convert.ToInt32(room_tb.Text), fee, Convert.ToInt32(hours_tb.Text), Convert.ToDouble(pay_tb.Text));
                    source.writeDataW(wResident);
                }
                if (residentType.Content.ToString() == "Scholarship Recipient")
                {
                    fee = 100;
                    aResident = new Scholarship_Resident(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor.Content.ToString()), residentType.Content.ToString(), Convert.ToInt32(room_tb.Text), fee, scholarshipType_tb.Text, Convert.ToDouble(scholarshipAmount_tb.Text));
                    sResident = new Scholarship_Resident(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor.Content.ToString()), residentType.Content.ToString(), Convert.ToInt32(room_tb.Text), fee, scholarshipType_tb.Text, Convert.ToDouble(scholarshipAmount_tb.Text));
                    source.writeDataS(sResident);
                }
                if (residentType.Content.ToString() == "Student Athlete")
                {
                    fee = 1200;
                    aResident = new Athlete_Resident(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor.Content.ToString()), residentType.Content.ToString(), Convert.ToInt32(room_tb.Text), fee, sport_tb.Text, role_tb.Text);
                    atResident = new Athlete_Resident(name_tb.Text, Convert.ToInt32(id_tb.Text), Convert.ToInt32(floor.Content.ToString()), residentType.Content.ToString(), Convert.ToInt32(room_tb.Text), fee, sport_tb.Text, role_tb.Text);
                    source.writeDataA(atResident);
                }
            }
            catch
            {
                New_Resident refreshResidentWindow = new New_Resident();
                refreshResidentWindow.Show();
                this.Close();
            }
            finally
            {
                New_Resident refreshResidentWindow = new New_Resident();
                refreshResidentWindow.Show();
                this.Close();
            }
        }
    }
}
