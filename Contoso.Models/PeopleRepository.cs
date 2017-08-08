using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Contoso.Model;
using System.Data.SqlClient;
using Contoso.Models;

namespace Contoso.Data
{
    public class PeopleRepository : IRepository<People>
    {
        public void Create(People Model)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spInsertPeople";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@LastName", Model.LastName);
            command.Parameters.AddWithValue("@FirstName", Model.FirstName);
            command.Parameters.AddWithValue("@MiddleName", Model.MiddleName);
            command.Parameters.AddWithValue("@Age", Model.Age);
            command.Parameters.AddWithValue("@Email", Model.Email);
            command.Parameters.AddWithValue("@Phone", Model.Phone);
            command.Parameters.AddWithValue("@AddressLine1", Model.AddressLine1);
            command.Parameters.AddWithValue("@AddressLine2", Model.AddressLine2);
            command.Parameters.AddWithValue("@UnitOrApartmentNumber", Model.UnitOrApartmentNumber);
            command.Parameters.AddWithValue("@City", Model.City);
            command.Parameters.AddWithValue("@State", Model.State);
            command.Parameters.AddWithValue("@ZipCode", Model.ZipCode);
            command.Parameters.AddWithValue("@CreatedDate", Model.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", Model.CreatedBy);
            command.Parameters.AddWithValue("@UpdatedBy", Model.UpdatedBy);
            command.Parameters.AddWithValue("@Password", Model.Password);
            command.Parameters.AddWithValue("@Salt", Model.Salt);
            command.Parameters.AddWithValue("@IsLocked", Model.IsLocked);
            command.Parameters.AddWithValue("@LastLockedDateTime", Model.LastLockedDateTime);
            command.Parameters.AddWithValue("@FailedAttempts", Model.FailedAttempts);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();

        }

        public void Delete(People Data)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spDeletePeople";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@Id", Data.Id);         
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();

        }

        public List<People> GetAll()
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spGetByIdPeople";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            List<People> lipeople = new List<People>();
            while (reader.Read()) {
                People people = new People();
                people.Id = Convert.ToInt32(reader["Id"]);
                people.LastName = reader["LastName"].ToString();
                people.FirstName = reader["FirstName"].ToString();
                people.MiddleName = reader["MiddleName"].ToString();
                people.Email = reader["Email"].ToString();
                people.Phone = reader["Phone"].ToString();
                people.AddressLine1 = reader["AddressLine1"].ToString();
                people.AddressLine2 = reader["AddressLine2"].ToString();
                people.UnitOrApartmentNumber = reader["UnitOrApartmentNumber"].ToString();
                people.City = reader["City"].ToString();
                people.State = reader["State"].ToString();
                people.ZipCode = Convert.ToInt32(reader["ZipCode"]);

                //command.Parameters.AddWithValue("@CreatedDate", Data.CreatedDate);
                //command.Parameters.AddWithValue("@CreatedBy", Data.CreatedBy);
                //command.Parameters.AddWithValue("@UpdatedBy", Data.UpdatedBy);
                //command.Parameters.AddWithValue("@Password", Data.Password);
                //command.Parameters.AddWithValue("@Salt", Data.Salt);
                //command.Parameters.AddWithValue("@IsLocked", Data.IsLocked);
                //command.Parameters.AddWithValue("@LastLockedDateTime", Data.LastLockedDateTime);
                //command.Parameters.AddWithValue("@FailedAttempts", Data.FailedAttempts);









                lipeople.Add(people);
            }
            
            return lipeople;

        }

        public People GetBy(int Id)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spGetByIdPeople";
            command.CommandType = CommandType.StoredProcedure;          
            command.Parameters.AddWithValue("@Id", Id);
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            People people = new People();
            if (reader != null)
            {
                people.Id = Convert.ToInt32(reader["Id"]);
            }    
            return people;
        }

        public void Update(People Model)
        {
            SqlConnection connection = new SqlConnection(DBHelper.GetConnection());
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = "spUpdatePeople";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            command.Parameters.AddWithValue("@LastName", Model.LastName);
            command.Parameters.AddWithValue("@FirstName", Model.FirstName);
            command.Parameters.AddWithValue("@MiddleName", Model.MiddleName);
            command.Parameters.AddWithValue("@Age", Model.Age);
            command.Parameters.AddWithValue("@Email", Model.Email);
            command.Parameters.AddWithValue("@Phone", Model.Phone);
            command.Parameters.AddWithValue("@AddressLine1", Model.AddressLine1);
            command.Parameters.AddWithValue("@AddressLine2", Model.AddressLine2);
            command.Parameters.AddWithValue("@UnitOrApartmentNumber", Model.UnitOrApartmentNumber);
            command.Parameters.AddWithValue("@City", Model.City);
            command.Parameters.AddWithValue("@State", Model.State);
            command.Parameters.AddWithValue("@ZipCode", Model.ZipCode);
            command.Parameters.AddWithValue("@CreatedDate", Model.CreatedDate);
            command.Parameters.AddWithValue("@CreatedBy", Model.CreatedBy);
            command.Parameters.AddWithValue("@UpdatedBy", Model.UpdatedBy);
            command.Parameters.AddWithValue("@Password", Model.Password);
            command.Parameters.AddWithValue("@Salt", Model.Salt);
            command.Parameters.AddWithValue("@IsLocked", Model.IsLocked);
            command.Parameters.AddWithValue("@LastLockedDateTime", Model.LastLockedDateTime);
            command.Parameters.AddWithValue("@FailedAttempts", Model.FailedAttempts);
            command.ExecuteNonQuery();
            connection.Close();
            command.Dispose();
            connection.Dispose();

        }

        IEnumerable<People> IRepository<People>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
