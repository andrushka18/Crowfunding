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
    public class DroitRepository : IDroitRepository<int, Droit>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["Crowfunding"].ConnectionString;
        public void Add(Droit entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_Add";
                    command.Parameters.AddWithValue("@NomDroit", entity.NomDroit);
                    command.Parameters.AddWithValue("@IdDroit", entity.IdDroit);
                    connection.Open();
                    entity.IdDroit = (int)command.ExecuteScalar();
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
                    command.CommandText = "SP_Droit_Delete";
                    command.Parameters.AddWithValue("@IdDroit", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Droit> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Droit()
                            {
                                IdDroit = (int)reader["IdDroit"],
                                NomDroit = (string)reader["Droit Utilisateur"],
                                

                            };
                        }
                    }
                }
            }
        }

        public Droit Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_GetById";
                    command.Parameters.AddWithValue("IdDroit", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Droit()
                            {
                                IdDroit = (int)reader["IdDroit"],
                                NomDroit = (string)reader["Droit Utilisateur"],

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

        public void SetAdmin(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_SetAdmin";
                    command.Parameters.AddWithValue("@IdDroit", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UnsetAdmin(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_UnsetAdmin";
                    command.Parameters.AddWithValue("@IdDroit", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(int id, Droit entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Droit_Update";
                    command.Parameters.AddWithValue("@idDroit", id);
                    command.Parameters.AddWithValue("@nomDroit", entity.NomDroit);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
