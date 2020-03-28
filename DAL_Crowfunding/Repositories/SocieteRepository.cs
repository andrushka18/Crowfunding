using DAL_Crowfunding.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Crowfunding.Repositories
{
    public class SocieteRepository : ISocieteRepository<int, Societe>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["Crowfunding"].ConnectionString;
        public void Add(Societe entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Societe_Add";
                    command.Parameters.AddWithValue("@Description", entity.Description);
                    command.Parameters.AddWithValue("@numeroTVA", entity.NumeroTVA);
                    connection.Open();
                    entity.NumeroTVA = (int)command.ExecuteScalar();
                }
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Societe_Delete";
                    command.Parameters.AddWithValue("@numeroTVA", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Societe> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Societe_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Societe()
                            {
                                NumeroTVA = (int)reader["NumeroTVA"],
                                Description = (string)reader["Description"],
                               

                            };
                        }
                    }
                }
            }
        }

        public Societe Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Societe_GetById";
                    command.Parameters.AddWithValue("utilisateurId", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Societe()
                            {

                                NumeroTVA = (int)reader["NumeroTVA"],
                                Description = (string)reader["Description"],

                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public void Update(int id, Societe entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Societe_Update";
                    command.Parameters.AddWithValue("@numeroTVA", id);
                    command.Parameters.AddWithValue("@description", entity.Description);
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
