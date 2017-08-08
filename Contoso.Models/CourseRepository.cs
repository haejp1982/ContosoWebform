using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Contoso.Model;
using System.Data.SqlClient;
using Contoso.Data;

namespace Contoso.Models
{
    public class CourseRepository : IRepository<Course>
    {
        public void Create(Course Data)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spInsertCourse";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@Title", Data.Title);
            command.Parameters.AddWithValue("@Credit", Data.Credit);
            command.Parameters.AddWithValue("@DepartmentId", Data.DepartmentId);
            command.Parameters.AddWithValue("@CreatedDate", Data.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", Data.CreatedBy);
            command.Parameters.AddWithValue("@UpdatedDate", Data.UpdatedDate);
            command.Parameters.AddWithValue("@UpdatedBy", Data.UpdatedBy);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();
        }

        public void Delete(Course Data)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spDeleteCourse";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@Id", Data.Id);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();
        }

        public IEnumerable<Course> GetAll()
        {
            return null;
        }

        public Course GetBy(int Id)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spGetByIdCourse";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", Id);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            Course course = new Course();
            if (reader != null)
            {
                course.Id = Convert.ToInt32(reader["Id"]);
            }
            return course;
        }

        public void Update(Course Data)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spUpdateCourse";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@Title", Data.Title);
            command.Parameters.AddWithValue("@Credit", Data.Credit);
            command.Parameters.AddWithValue("@DepartmentId", Data.DepartmentId);
            command.Parameters.AddWithValue("@CreatedDate", Data.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", Data.CreatedBy);
            command.Parameters.AddWithValue("@UpdatedDate", Data.UpdatedDate);
            command.Parameters.AddWithValue("@UpdatedBy", Data.UpdatedBy);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();
        }
    }

}
