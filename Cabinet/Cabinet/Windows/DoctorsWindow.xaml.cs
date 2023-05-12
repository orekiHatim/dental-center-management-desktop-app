using Cabinet.classes;
using Cabinet.services;
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
using Cabinet.Windows.Appointments;


namespace Cabinet.Windows
{
    /// <summary>
    /// Logique d'interaction pour DoctorsWindow.xaml
    /// </summary>
    public partial class DoctorsWindow : Window
    {
        DoctorService ds;
        int dataGridSelectedId;
        public DoctorsWindow()
        {
            InitializeComponent();
            ds = new DoctorService();
            doctorsDataGrid.ItemsSource = ds.getAll();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            updateDoctor ap = new updateDoctor(dataGridSelectedId);
            ap.Show();
            this.Close();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            addDoctor a = new addDoctor();
            a.Show();
            this.Close();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string val = searchBox.Text.ToLower();
            doctorsDataGrid.ItemsSource = ds.filterBy(val);
        }

        private void doctorsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (doctorsDataGrid.SelectedItems.Count >= 1)
            {
                Doctor d = (Doctor)doctorsDataGrid.SelectedItem;
                //MessageBox.Show(p.Id + "");
                dataGridSelectedId = d.Id;
                if (doctorsDataGrid.SelectedItems.Count >= 1)
                {
                    deleteBtn.IsEnabled = true;
                    updateBtn.IsEnabled = true;
                }
                else
                {
                    deleteBtn.IsEnabled = false;
                    updateBtn.IsEnabled = false;
                }
            }
        }

        private void confirmDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ds.delete(new Doctor(dataGridSelectedId, "", "", "")))
            {
                doctorsDataGrid.ItemsSource = ds.getAll();
            }
        }


        private void appointmentsWindow_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsWindow ap = new AppointmentsWindow();
            ap.Show();
            this.Close();
        }

        private void patientsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
