using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IntroductionDatabase
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student(firstNameTextBox.Text,middleNameTextBox.Text,phoneTextBox.Text,addressTextBox.Text,regNoTextBox.Text);

            string conString = @"server = PC-301-21\SQLEXPRESS;database=UniversityDB;Integrated security =true";
            SqlConnection connection =new SqlConnection(conString);
            string query = "INSERT INTO Students VALUES('" + student.FirstName + "','" + student.MiddleName + "','" +
                           student.Phone + "','" + student.Address + "','" + student.RegNo + "')";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowAffected > 0)
            {
                Response.Write("Inserted Successfully");
            }
            else
            {
                Response.Write("Could not found");
            }
           
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            List<Student> studentList = GetAllStudentList();

            studentsGridView.DataSource = studentList;
            studentsGridView.DataBind();
        }

        private static List<Student> GetAllStudentList()
        {
            string conString = @"server = PC-301-21\SQLEXPRESS;database=UniversityDB;Integrated security =true";
            SqlConnection connection = new SqlConnection(conString);
            string query = "SELECT * FROM Students";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Student> studentList = new List<Student>();
            while (reader.Read())
            {
                int studentId = int.Parse(reader["StudentID"].ToString());
                string firstName = reader["FirstName"].ToString();
                string middleName = reader["MiddleName"].ToString();
                string phone = reader["Phone"].ToString();
                string address = reader["Address"].ToString();
                string regNo = reader["RegNo"].ToString();

                Student aStudent = new Student(firstName, middleName, phone, address, regNo);
                aStudent.StudentID = studentId;
                studentList.Add(aStudent);
            }
            reader.Close();
            connection.Close();
            return studentList;
        }
    }
}