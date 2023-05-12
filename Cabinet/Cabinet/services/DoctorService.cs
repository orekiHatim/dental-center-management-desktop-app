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
    internal class DoctorService : Idao<Doctor>
    {
        public bool create(Doctor o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "insert into doctors(fname, lname, phone) values (@fname, @lname, @phone)";
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

        public bool delete(Doctor o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "Delete from doctors where id = @id";
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

        public List<Doctor> getAll()
        {
            Connection conn = new Connection();
            conn.Initialize();
            List<Doctor> doctors = new List<Doctor>();

            if (conn.openConnection())
            {
                string sql = "SELECT * from doctors";
                var cmd = new MySqlCommand(sql, conn.getConnection());

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        doctors.Add(new Doctor(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3)));
                    }
                }
            }
            conn.closeConnection();
            return doctors;
        }

        public Doctor getById(int id)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                cmd.CommandText = "select * from doctors where id = @id";
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    if (res.Read())
                    {
                        return new Doctor(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3));
                    }
                }
            }
            conn.closeConnection();
            return null;
        }

        public bool update(Doctor o)
        {
            Connection conn = new Connection();
            conn.Initialize();

            if (conn.openConnection())
            {
                try
                {
                    MySqlCommand cmd = conn.getConnection().CreateCommand();
                    cmd.CommandText = "update doctors set fname = @fname, lname = @lname, phone = @phone  where id=@id";
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

        public List<Doctor> filterBy(string val)
        {
            Connection conn = new Connection();
            conn.Initialize();
            List<Doctor> doctors = new List<Doctor>();

            if (conn.openConnection())
            {
                MySqlCommand cmd = conn.getConnection().CreateCommand();
                cmd.CommandText = "select * from doctors where lname like @val";
                cmd.Parameters.AddWithValue("@val", val + "%");

                using (MySqlDataReader res = cmd.ExecuteReader())
                {
                    while (res.Read())
                    {
                        doctors.Add(new Doctor(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3)));
                    }
                }
            }
            conn.closeConnection();
            return doctors;
        }
    }
}
