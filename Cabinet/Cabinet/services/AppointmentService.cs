using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cabinet.classes;
using Cabinet.idao;
using MySql.Data.MySqlClient;

namespace Cabinet.services
{
    class AppointmentService : Idao<Appointment>
    {
        DoctorService ds;
        PatientService ps;

        public AppointmentService()
        {
            ds = new DoctorService();
            ps = new PatientService();
        }

        public bool create(Appointment o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "insert into appointments(doctor, patient, date, time, state) values (@doctor, @patient, @date, @time,@state)";
                    cmd.Parameters.AddWithValue("@doctor", o.Doctor.Id);
                    cmd.Parameters.AddWithValue("@patient", o.Patient.Id);
                    cmd.Parameters.AddWithValue("@date", o.Date);
                    cmd.Parameters.AddWithValue("@time", o.Time);
                    cmd.Parameters.AddWithValue("@state", "active");
                    cmd.ExecuteNonQuery();
                    conn.closeConnection();
                    return true;
                }
                catch (MySqlException)
                {

                }

            }
            conn.closeConnection();
            return false;
        }

        public bool delete(Appointment o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "Delete from appointments where id = @id";
                    cmd.Parameters.AddWithValue("@id", o.Id);
                    cmd.ExecuteNonQuery();
                    conn.closeConnection();
                    return true;
                }
                catch (MySqlException)
                {

                }

            }
            conn.closeConnection();
            return false;
        }

        public List<Appointment> getAll()
        {
            Connection conn = new Connection();
            conn.Initialize();
            List<Appointment> appointments = new List<Appointment>();

            if (conn.openConnection())
            {
                string sql = "SELECT * from appointments";
                var cmd = new MySqlCommand(sql, conn.getConnection());

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        Doctor doctor = ds.getById(res.GetInt32(1));
                        Patient patient = ps.getById(res.GetInt32(2));

                        appointments.Add(new Appointment(res.GetInt32(0), doctor, patient, res.GetString(3), res.GetString(4)));
                    }
                }
            }
            conn.closeConnection();
            return appointments;
        }

        public Appointment getById(int id)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                cmd.CommandText = "select * from appointments where id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    if (res.Read())
                    {
                        Doctor doctor = ds.getById(res.GetInt32(1));
                        Patient patient = ps.getById(res.GetInt32(2));

                        return new Appointment(res.GetInt32(0), doctor, patient, res.GetString(3), res.GetString(4));
                    }
                }
            }
            conn.closeConnection();
            return null;
        }

        public bool update(Appointment o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "update appointments set doctor = @doctor, patient = @patient, date = @date, time = @time, state = @state  where id=@id";
                    cmd.Parameters.AddWithValue("@doctor", o.Doctor.Id);
                    cmd.Parameters.AddWithValue("@patient", o.Patient.Id);
                    cmd.Parameters.AddWithValue("@date", o.Date);
                    cmd.Parameters.AddWithValue("@time", o.Time);
                    cmd.Parameters.AddWithValue("@state", o.State);
                    cmd.Parameters.AddWithValue("@id", o.Id);
                    cmd.ExecuteNonQuery();
                    conn.closeConnection();
                    return true;
                }
                catch (MySqlException)
                {

                }

            }
            conn.closeConnection();
            return false;
        }

        public bool checkIfValid(string date, string time, int doctor)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                cmd.CommandText = "SELECT * FROM appointments WHERE ( STR_TO_DATE(time, '%h:%i:%s %p') BETWEEN (STR_TO_DATE(@time, '%h:%i:%s %p') - INTERVAL 30 MINUTE) AND (STR_TO_DATE(@time, '%h:%i:%s %p') + INTERVAL 30 MINUTE) ) AND doctor = @doctor AND STR_TO_DATE(date, '%d/%m/%Y') = STR_TO_DATE(@date, '%d/%m/%Y')";
                cmd.Parameters.AddWithValue("@time", time);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doctor", doctor);

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    if (res.Read())
                    {
                        return false;
                    }
                }
            }
            conn.closeConnection();
            return true;
        }

        public List<Appointment> filterBy(string state, string date, Doctor doctor)
        {
            Connection conn = new Connection();
            conn.Initialize();
            List<Appointment> appointments = new List<Appointment>();
            

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                if (date == "" || doctor == null)
                {
                    if (date == "" && doctor == null)
                    {
                        cmd.CommandText = "SELECT * from appointments where state = @state";
                        cmd.Parameters.AddWithValue("@state", state);
                    } else if (date == "" & doctor != null)
                    {
                        cmd.CommandText = "SELECT * from appointments where state = @state and doctor = @doctor";
                        cmd.Parameters.AddWithValue("@state", state);
                        cmd.Parameters.AddWithValue("@doctor", doctor.Id);
                    } else if (doctor == null & date != "")
                    {
                        cmd.CommandText = "SELECT * from appointments where state = @state and STR_TO_DATE(date, '%d/%m/%Y') = STR_TO_DATE(@date, '%d/%m/%Y')";
                        cmd.Parameters.AddWithValue("@state", state);
                        cmd.Parameters.AddWithValue("@date", date);
                    }

                }
                else
                {
                    cmd.CommandText = "SELECT * from appointments where state = @state and STR_TO_DATE(date, '%d/%m/%Y') = STR_TO_DATE(@date, '%d/%m/%Y') and doctor = @doctor";
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doctor", doctor.Id);
                }

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        Doctor d = ds.getById(res.GetInt32(1));
                        Patient patient = ps.getById(res.GetInt32(2));

                        appointments.Add(new Appointment(res.GetInt32(0), d, patient, res.GetString(3), res.GetString(4)));
                    }
                }
            }
            conn.closeConnection();
            return appointments;
        }

        public void resolveApps()
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "update appointments set state = @state where STR_TO_DATE(date, '%d/%m/%Y') < CURDATE()";
                    cmd.Parameters.AddWithValue("@state", "resolved");
                    cmd.ExecuteNonQuery();
                    conn.closeConnection();
                }
                catch (MySqlException)
                {

                }

            }
            conn.closeConnection();
        }

        /*public List<Appointment> filterBy(string val)
        {
            Connection conn = new Connection();
            conn.Initialize();
            List<Appointment> appointments = new List<Appointment>();

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                cmd.CommandText = "select * from appointments where lname like @val";
                cmd.Parameters.AddWithValue("@val", val + "%");

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        Doctor doctor = ds.getById(res.GetInt32(1));
                        Patient patient = ps.getById(res.GetInt32(2));

                        appointments.Add(new Appointment(res.GetInt32(0), doctor, patient, res.GetString(3), res.GetString(4)));
                    }
                }
            }
            conn.closeConnection();
            return appointments;
        }*/
    }
}
