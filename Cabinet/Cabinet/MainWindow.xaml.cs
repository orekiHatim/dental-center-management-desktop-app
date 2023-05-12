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
using Cabinet.services;
using Cabinet.classes;
using Cabinet.Windows;
using Cabinet.Windows.Appointments;

namespace Cabinet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PatientService ps;
        int dataGridSelectedId;

        public MainWindow()
        {
            InitializeComponent();
            ps = new PatientService();
            //ps.create(new Patient("Test2", "Hatim", "021548451"));
            clientsDataGrid.ItemsSource = ps.getAll();
        }

        private void clientsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(clientsDataGrid.SelectedItems.Count >= 1)
            {
                Patient p = (Patient)clientsDataGrid.SelectedItem;
                //MessageBox.Show(p.Id + "");
                dataGridSelectedId = p.Id;
                if (clientsDataGrid.SelectedItems.Count >= 1)
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

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string val = searchBox.Text.ToLower();
            clientsDataGrid.ItemsSource = ps.filterBy(val);
            
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            addUpdatePatient ap = new addUpdatePatient();
            ap.Show();
            this.Close();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            updatePatient ap = new updatePatient(dataGridSelectedId);
            ap.Show();
            this.Close();
        }

        private void doctorsWindow_Click(object sender, RoutedEventArgs e)
        {
            DoctorsWindow d = new DoctorsWindow();
            d.Show();
            this.Close();
        }

        private void appointmentsWindow_Click(object sender, RoutedEventArgs e)
        {
            AppointmentsWindow ad = new AppointmentsWindow();
            ad.Show();
            this.Close();
        }

        private void confirmDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("in");
            if (ps.delete(new Patient(dataGridSelectedId, "", "", "")))
            {
                MessageBox.Show("deleted");
                clientsDataGrid.ItemsSource = ps.getAll();
            }
        }
    }
}
