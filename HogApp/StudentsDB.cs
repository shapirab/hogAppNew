using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace HogApp
{
    public class StudentsDB
    {

        private static string loadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HogDBConnectionString"].ConnectionString;
        }
        public static Student getStudent(int studentID)
        {
            SqlConnection con = new SqlConnection(loadConnectionString());

            Student student = new Student();
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from Students where studentID='" + studentID + "'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    student.StudentID = Convert.ToInt32(reader.GetValue(0));
                    student.FirstName = reader.GetString(1);
                    student.LastName = reader.GetString(2);
                    student.Points = Convert.ToInt32(reader.GetValue(3));
                    student.HouseID = Convert.ToInt32(reader.GetValue(4));
                }
            }
            return student;
        }
        public static void updateStudentPoints(int points, int studentID)
        {
            SqlConnection con = new SqlConnection(loadConnectionString());
            using (con)
            {
                SqlCommand cmd = new SqlCommand("update Students set points='" + points + "' where studentID='" + studentID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static int getStudentPoints(int studentID)
        {
            int studentPoints = -99;
            SqlConnection con = new SqlConnection(loadConnectionString());
            using (con)
            {
                SqlCommand cmd = new SqlCommand("select points from Students where studentID='" + studentID + "'", con);
                con.Open();
                studentPoints = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return studentPoints;
        }
        public static List<Student> loadAllStudents()
        {
            List<Student> students = new List<Student>();
            SqlConnection con = new SqlConnection(loadConnectionString());

            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from Students", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.FirstName = reader.GetString(1);
                    student.LastName = reader.GetString(2);
                    student.Points = Convert.ToInt32(reader.GetValue(3));
                    student.StudentID = Convert.ToInt32(reader.GetValue(0));
                    student.HouseID = Convert.ToInt32(reader.GetValue(4));
                    students.Add(student);
                }
            }
            return students;
        }
        public static void setFullNames()
        {
            List<Student> students = loadAllStudents();
            foreach (Student student in students)
            {
                string fullName = student.FullName;
                int studentID = student.StudentID;
                pushFullNames(fullName, studentID);

            }
        }
        private static void pushFullNames(string fullName, int studentID)
        {
            SqlConnection con = new SqlConnection(loadConnectionString());

            using (con)
            {
                SqlCommand cmd = new SqlCommand("update Students set fullName=N'" + fullName + "' where studentID='" + studentID + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public static List<Student> getMatchingStudents(string partialName)
        {
            List<Student> matchingStudents = new List<Student>();
            SqlConnection con = new SqlConnection(loadConnectionString());

            using (con)
            {
                SqlCommand cmd = new SqlCommand("select * from Students where fullName like N'" + partialName + "%'", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student();
                    student.FirstName = reader.GetString(1);
                    student.LastName = reader.GetString(2);
                    student.Points = Convert.ToInt32(reader.GetValue(3));
                    student.StudentID = Convert.ToInt32(reader.GetValue(0));
                    student.HouseID = Convert.ToInt32(reader.GetValue(4));
                    matchingStudents.Add(student);
                }
                return matchingStudents;
            }
        }
    }
}