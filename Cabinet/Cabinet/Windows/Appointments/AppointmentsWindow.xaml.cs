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
using Cabinet.services;
using Cabinet.classes;
namespace Cabinet.Windows.Appointments
{
    /// <summary>
    /// Interaction logic for AppointmentsWindow.xaml
    /// </summary>
    public partial class AppointmentsWindow : Window
    {
        AppointmentService aps;
        DoctorService ds;
        int dataGridSelectedId;
        int currentStateBtnSelected;

        public AppointmentsWindow()
        {
            InitializeComponent();
            aps = new AppointmentService();
            ds = new DoctorService();
            currentStateBtnSelected = 1;
            doctors_load();
            aps.resolveApps();
            appointmentsDataGrid.ItemsSource = aps.filterBy("active", "", null);
        }

        private void doctors_load()
        {
            doctorsList.Items.Clear();
            doctorsList.Items.Add(new Doctor("", "None", ""));
            foreach (Doctor d in ds.getAll())
            {
                doctorsList.Items.Add(d);
            }
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            addAppointment a = new addAppointment();
            a.Show();
            this.Close();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (aps.delete(new Appointment(dataGridSelectedId, null, null, "", "")))
            {
                appointmentsDataGrid.ItemsSource = aps.getAll();
            }
        }

        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void doctorsWindow_Click(object sender, RoutedEventArgs e)
        {
            DoctorsWindow d = new DoctorsWindow();
            d.Show();
            this.Close();
        }

        private void appointmentsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (appointmentsDataGrid.SelectedItems.Count >= 1)
            {
                Appointment p = (Appointment) appointmentsDataGrid.SelectedItem;
                //MessageBox.Show(p.Id + "");
                dataGridSelectedId = p.Id;
                if (appointmentsDataGrid.SelectedItems.Count >= 1)
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

        private void activeBtn_Click(object sender, RoutedEventArgs e)
        {
            currentStateBtnSelected = 1;
            string date = "";
            if (dateInput.SelectedDate.HasValue)
            {
                date = dateInput.SelectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            if(doctorsList.SelectedIndex != -1)
            {
                Doctor d = doctorsList.SelectedItem as Doctor;
                if(d.Lname == "None")
                {
                    appointmentsDataGrid.ItemsSource = aps.filterBy("active", date, null);
                } else
                {
                    appointmentsDataGrid.ItemsSource = aps.filterBy("active", date, d);
                }
            } else
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("active", date, null);
            }

            activeBtn.BorderBrush = new SolidColorBrush(Colors.Black);
            resolvedBtn.BorderBrush = new BrushConverter().ConvertFrom("#FFD6D6D6") as Brush;
            cancelledBtn.BorderBrush = new BrushConverter().ConvertFrom("#FFD6D6D6") as Brush;
        }

        private void cancelledBtn_Click(object sender, RoutedEventArgs e)
        {
            currentStateBtnSelected = 2;
            string date = "";
            if (dateInput.SelectedDate.HasValue)
            {
                date = dateInput.SelectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (doctorsList.SelectedIndex != -1)
            {
                Doctor d = doctorsList.SelectedItem as Doctor;
                if (d.Lname == "None")
                {
                    appointmentsDataGrid.ItemsSource = aps.filterBy("cancelled", date, null);
                }
                else
                {
                    appointmentsDataGrid.ItemsSource = aps.filterBy("cancelled", date, d);
                }
            }
            else
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("cancelled", date, null);
            }

            activeBtn.BorderBrush = new BrushConverter().ConvertFrom("#FFD6D6D6") as Brush;
            resolvedBtn.BorderBrush = new BrushConverter().ConvertFrom("#FFD6D6D6") as Brush;
            cancelledBtn.BorderBrush = new SolidColorBrush(Colors.Black);
        }

        private void resolvedBtn_Click(object sender, RoutedEventArgs e)
        {
            currentStateBtnSelected = 3;
            string date = "";
            if (dateInput.SelectedDate.HasValue)
            {
                date = dateInput.SelectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (doctorsList.SelectedIndex != -1)
            {
                Doctor d = doctorsList.SelectedItem as Doctor;
                if (d.Lname == "None")
                {
                    appointmentsDataGrid.ItemsSource = aps.filterBy("resolved", date, null);
                }
                else
                {
                    appointmentsDataGrid.ItemsSource = aps.filterBy("resolved", date, d);
                }
            }
            else
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("resolved", date, null);
            }

            activeBtn.BorderBrush = new BrushConverter().ConvertFrom("#FFD6D6D6") as Brush;
            resolvedBtn.BorderBrush = new SolidColorBrush(Colors.Black);
            cancelledBtn.BorderBrush = new BrushConverter().ConvertFrom("#FFD6D6D6") as Brush;
        }

        private void doctorsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string date = "";
            Doctor doctor = null;
            if (dateInput.SelectedDate.HasValue)
            {
                date = dateInput.SelectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (doctorsList.SelectedIndex != -1)
            {
                Doctor d = doctorsList.SelectedItem as Doctor;
                if (d.Lname != "None")
                {
                    doctor = d;
                }
            }
            if (currentStateBtnSelected == 1)
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("active", date, doctor);
            } else if(currentStateBtnSelected == 2)
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("cancelled", date, doctor);
            } else if (currentStateBtnSelected == 3)
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("resolved", date, doctor);
            }
        }

        private void dateInput_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            string date = "";
            Doctor doctor = null;
            if (dateInput.SelectedDate.HasValue)
            {
                date = dateInput.SelectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            if (doctorsList.SelectedIndex != -1)
            {
                Doctor d = doctorsList.SelectedItem as Doctor;
                if (d.Lname != "None")
                {
                    doctor = d;
                }
            }
            if (currentStateBtnSelected == 1)
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("active", date, doctor);
            }
            else if (currentStateBtnSelected == 2)
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("cancelled", date, doctor);
            }
            else if (currentStateBtnSelected == 3)
            {
                appointmentsDataGrid.ItemsSource = aps.filterBy("resolved", date, doctor);
            }
        }

        private void patientsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
