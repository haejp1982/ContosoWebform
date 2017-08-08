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
    class DepartmentRepository : IRepository<Department>
    {
        public void Create(Department Data)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spInsertDepartment";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@Name", Data.Name);
            command.Parameters.AddWithValue("@Budget", Data.Budget);
            command.Parameters.AddWithValue("@StartDate", Data.StartDate);
            command.Parameters.AddWithValue("@InstructorId", Data.InstructorId);
            command.Parameters.AddWithValue("@RowVersion", Data.RowVersion);
            command.Parameters.AddWithValue("@CreatedDate", Data.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", Data.CreatedBy);
            command.Parameters.AddWithValue("@UpdatedDate", Data.UpdatedDate);
            command.Parameters.AddWithValue("@UpdatedBy", Data.UpdatedBy);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();
        }

        public void Delete(Department Data)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spDeleteDepartment";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@Id", Data.Id);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();
        }

        public IEnumerable<Department> GetAll()
        {
            return null;
        }

        public Department GetBy(int Id)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spGetByIdDepartment";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", Id);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            Department department = new Department();
            if (reader != null)
            {
                department.Id = Convert.ToInt32(reader["Id"]);
            }
            return department ;
        }

        public void Update(Department Data)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spUpdateDepartment";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@Name", Data.Name);
            command.Parameters.AddWithValue("@Budget", Data.Budget);
            command.Parameters.AddWithValue("@StartDate", Data.StartDate);
            command.Parameters.AddWithValue("@InstructorId", Data.InstructorId);
            command.Parameters.AddWithValue("@RowVersion", Data.RowVersion);
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
