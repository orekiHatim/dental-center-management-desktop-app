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
    /// Interaction logic for addAppointment.xaml
    /// </summary>
    public partial class addAppointment : Window
    {
        DoctorService ds;
        PatientService ps;
        AppointmentService aps;

        public addAppointment()
        {
            InitializeComponent();
            ds = new DoctorService();
            ps = new PatientService();
            aps = new AppointmentService();
            doctors_load();
            patients_load();
            //dateInput.SelectedDate = new DateTime(2023, 10, 25);
          
        }

        private void doctors_load()
        {
            doctorsList.Items.Clear();
            foreach(Doctor d in ds.getAll())
            {
                doctorsList.Items.Add(d);
            }
        }

        private void patients_load()
        {
            patientsList.Items.Clear();
            foreach (Patient d in ps.getAll())
            {
                patientsList.Items.Add(d);
            }
        }

        private void submit(object sender, RoutedEventArgs e)
        {

            Doctor doctor = doctorsList.SelectedItem as Doctor;
            Patient patient = patientsList.SelectedItem as Patient;

            if (dateInput.SelectedDate.HasValue == false || doctor == null || patient == null || timeInput.SelectedTime.HasValue == false)
            {
                textError.Foreground = Brushes.Red;
                iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
                iconError.Foreground = Brushes.Red;
                textError.Text = "Please fill the form";
                formError.Visibility = Visibility.Visible;
            }
            else
            {
                string date = dateInput.SelectedDate.Value.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                string timeInputVal = timeInput.SelectedTime.ToString();
                String[] spearator = { " " };
                Int32 count = 2;
                string[] strList = timeInputVal.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);
                string time = strList[1];

                if(aps.checkIfValid(date, time, doctor.Id))
                {
                    if (aps.create(new Appointment(doctor, patient, date, time)))
                    {
                        textError.Foreground = Brushes.LimeGreen;
                        iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Done;
                        iconError.Foreground = Brushes.LimeGreen;
                        textError.Text = "Inserted Successfully!";
                        formError.Visibility = Visibility.Visible;

                        doctorsList.SelectedItem = null;
                        patientsList.SelectedItem = null;
                        dateInput.SelectedDate = null;
                        timeInput.SelectedTime = null;
                    }
                    else
                    {
                        textError.Foreground = Brushes.Red;
                        iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
                        iconError.Foreground = Brushes.Red;
                        textError.Text = "Error inserting infos to database";
                        formError.Visibility = Visibility.Visible;
                    }
                } else
                {
                    textError.Foreground = Brushes.Red;
                    iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
                    iconError.Foreground = Brushes.Red;
                    textError.Text = "Cannot reserv at this time";
                    formError.Visibility = Visibility.Visible;
                }
               

            }

        }

        private void close(object sender, RoutedEventArgs e)
        {
            AppointmentsWindow a = new AppointmentsWindow();
            a.Show();
            this.Close();
        }
    }
}
