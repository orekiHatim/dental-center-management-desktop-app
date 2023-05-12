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

namespace Cabinet.Windows
{
    /// <summary>
    /// Logique d'interaction pour addDoctor.xaml
    /// </summary>
    public partial class addDoctor : Window
    {
        DoctorService ds;
        public addDoctor()
        {
            InitializeComponent();
            ds = new DoctorService();
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

                if (ds.create(new Doctor(fname, lname, phone)))
                {
                    textError.Foreground = Brushes.LimeGreen;
                    iconError.Kind = MaterialDesignThemes.Wpf.PackIconKind.Done;
                    iconError.Foreground = Brushes.LimeGreen;
                    textError.Text = "Inserted Successfully!";
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
                    textError.Text = "Error inserting infos to database";
                    formError.Visibility = Visibility.Visible;
                }

            }
        }

        private void close(object sender, RoutedEventArgs e)
        {
            DoctorsWindow m = new DoctorsWindow();
            m.Show();
            this.Close();
        }
    }
}
