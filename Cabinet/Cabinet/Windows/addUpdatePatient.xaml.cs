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
    /// Interaction logic for addUpdatePatient.xaml
    /// </summary>
    public partial class addUpdatePatient : Window
    {
        PatientService ps;
        public addUpdatePatient()
        {
            InitializeComponent();
            ps = new PatientService();
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
                
                if(ps.create(new Patient(fname, lname, phone)))
                {
                    textError.Foreground = Brushes.LimeGreen;
                    iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Done;
                    iconError.Foreground = Brushes.LimeGreen;
                    textError.Text = "Inserted Successfully!";
                    formError.Visibility = Visibility.Visible;

                    txtFname.Text = "";
                    txtLname.Text = "";
                    txtPhone.Text = "";
                } else
                {
                    textError.Foreground = Brushes.Red;
                    iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Error;
                    iconError.Foreground = Brushes.Red;
                    textError.Text = "Error inserting infos to database";
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

