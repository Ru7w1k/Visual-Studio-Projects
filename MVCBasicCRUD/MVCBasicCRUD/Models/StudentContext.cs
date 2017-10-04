using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCBasicCRUD.Models
{
    public static class StudentContext
    {
        private static string _connectionString = @"Data Source=Rutwik-C\SQLEXPRESS;Initial Catalog=MVCCrud;Integrated Security=True";
        private static SqlConnection _Connection = null;
        private static SqlCommand _Command = null;

        static StudentContext()
        {
            _Connection = new SqlConnection(_connectionString);
        }

        public static List<Student> Students()
        {
            List<Student> _Students = new List<Student>();
            
            _Command = new SqlCommand("SELECT * FROM Students", _Connection);

            _Connection.Open();
            SqlDataReader dr = _Command.ExecuteReader();
            while(dr.Read())
            {
                _Students.Add(new Student {
                    RollNo = Convert.ToInt32(dr["RollNo"]),
                    Name = dr["Name"].ToString(),
                    Marks = Convert.ToInt32(dr["Marks"])
                });
            }
            _Connection.Close();

            return _Students;
        }

        public static Student StudentByRollNo(int rollNo)
        {
            Student _Student = null;

            _Command = new SqlCommand(string.Format("SELECT * FROM Students WHERE RollNo = {0}", rollNo), _Connection);

            _Connection.Open();
            SqlDataReader dr = _Command.ExecuteReader();
            if(dr.Read())
            {
                _Student = new Student
                {
                    RollNo = Convert.ToInt32(dr["RollNo"]),
                    Name = dr["Name"].ToString(),
                    Marks = Convert.ToInt32(dr["Marks"])
                };
            }
            _Connection.Close();

            return _Student;
        }

        public static bool InsertStudent(Student st)
        {
            _Command = new SqlCommand(
                string.Format("INSERT INTO Students VALUES ({0}, '{1}', {2})", st.RollNo, st.Name, st.Marks), _Connection);
            int res = 0;

            try
            {
                _Connection.Open();
                res = _Command.ExecuteNonQuery();
                
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                _Connection.Close();                
            }
            return true;
        }

        public static bool UpdateStudent(Student st)
        {
            _Command = new SqlCommand(
                string.Format("UPDATE Students SET Name = '{0}', Marks = {1} WHERE RollNo = {2}", st.Name, st.Marks, st.RollNo), _Connection);
            int res = 0;

            try
            {
                _Connection.Open();
                res = _Command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                _Connection.Close();
            }
            return true;
        }

        public static bool DeleteStudent(int rollNo)
        {
            _Command = new SqlCommand(
                string.Format("DELETE FROM Students WHERE RollNo = {0}", rollNo), _Connection);
            int res = 0;

            try
            {
                _Connection.Open();
                res = _Command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                _Connection.Close();
            }
            return true;
        }


    }
}