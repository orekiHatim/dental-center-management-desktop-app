using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet.classes
{
    class Appointment
    {
        private int id;
        private Doctor doctor;
        private Patient patient;
        private string date;
        private string time;
        private string state;

        private string doctorUi;
        private string patientUi;

        public Appointment(int id, Doctor doctor, Patient patient, string date, string time)
        {
            this.id = id;
            this.doctor = doctor;
            this.patient = patient;
            this.date = date;
            this.time = time;
        }

        public Appointment(Doctor doctor, Patient patient, string date, string time)
        {
            this.doctor = doctor;
            this.patient = patient;
            this.date = date;
            this.time = time;
        }

        public Appointment(Doctor doctor, Patient patient, string date, string time, string state)
        {
            this.doctor = doctor;
            this.patient = patient;
            this.date = date;
            this.time = time;
            this.state = state;
        }


        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public int Id { get => id; set => id = value; }
        internal Doctor Doctor { get => doctor; set => doctor = value; }
        internal Patient Patient { get => patient; set => patient = value; }

        public string DoctorUi { get => doctor.ToString();}
        public string PatientUi { get => patient.ToString();}
        public string State { get => state; set => state = value; }
    }
}
