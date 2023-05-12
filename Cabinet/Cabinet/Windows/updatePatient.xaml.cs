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
using Cabinet.classes;
using Cabinet.services;

namespace Cabinet.Windows
{
    /// <summary>
    /// Interaction logic for updatePatient.xaml
    /// </summary>
    public partial class updatePatient : Window
    {
        Patient patient;
        PatientService ps;

        public updatePatient(int x)
        {
            InitializeComponent();
            ps = new PatientService();
            patient = ps.getById(x);
            txtFname.Text = patient.Fname;
            txtLname.Text = patient.Lname;
            txtPhone.Text = patient.Phone; 

            //MessageBox.Show(patient.Lname + "");
        }

        private void submit(object sender, RoutedEventArgs e)
        {
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string phone = txtPhone.Text;


            if (fname.Length == 0 || lname.Length == 0 || phone.Length == 0)
            {
                textError.Foreground = Brushes.Red;
                iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
                iconError.Foreground = Brushes.Red;
                textError.Text = "Please fill the form";
                formError.Visibility = Visibility.Visible;
            }
            else
            {

                if (ps.update(new Patient(patient.Id, fname, lname, phone)))
                {
                    textError.Foreground = Brushes.LimeGreen;
                    iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Done;
                    iconError.Foreground = Brushes.LimeGreen;
                    textError.Text = "Updated Successfully!";
                    formError.Visibility = Visibility.Visible;

                    txtFname.Text = "";
                    txtLname.Text = "";
                    txtPhone.Text = "";
                }
                else
                {
                    textError.Foreground = Brushes.Red;
                    iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
                    iconError.Foreground = Brushes.Red;
                    textError.Text = "Error updating infos to database";
                    formError.Visibility = Visibility.Visible;
                }

            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
