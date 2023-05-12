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
    class PatientService : Idao<Patient>
    {
        public bool create(Patient o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "insert into patients(fname, lname, phone) values (@fname, @lname, @phone)";
                    cmd.Parameters.AddWithValue("@fname", o.Fname);
                    cmd.Parameters.AddWithValue("@lname", o.Lname);
                    cmd.Parameters.AddWithValue("@phone", o.Phone);
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

        public bool delete(Patient o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "Delete from patients where id = @id";
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

        public List<Patient> getAll()
        {
            Connection conn = new Connection();
            conn.Initialize();
            List<Patient> patients = new List<Patient>();

            if (conn.openConnection())
            {
                string sql = "SELECT * from patients";
                var cmd = new MySqlCommand(sql, conn.getConnection());

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        patients.Add(new Patient(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3)));
                    }
                }
            }
            conn.closeConnection();
            return patients;
        }

        public Patient getById(int id)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                cmd.CommandText = "select * from patients where id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    if (res.Read())
                    {
                        return new Patient(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3));
                    }
                }
            }
            conn.closeConnection();
            return null;
        }

        public bool update(Patient o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "update patients set fname = @fname, lname = @lname, phone = @phone  where id=@id";
                    cmd.Parameters.AddWithValue("@fname", o.Fname);
                    cmd.Parameters.AddWithValue("@lname", o.Lname);
                    cmd.Parameters.AddWithValue("@phone", o.Phone);
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

        public List<Patient> filterBy(string val)
        {
            Connection conn = new Connection();
            conn.Initialize();
            List<Patient> patients = new List<Patient>();

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                cmd.CommandText = "select * from patients where lname like @val";
                cmd.Parameters.AddWithValue("@val", val + "%");

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        patients.Add(new Patient(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3)));
                    }
                }
            }
            conn.closeConnection();
            return patients;
        }
    }
}
