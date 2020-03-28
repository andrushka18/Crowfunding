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

    public class EmployeRepository : IEmployeRepository<int, Employe>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["Crowfunding"].ConnectionString;
        public void Add(Employe entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Employe_Add";
                    command.Parameters.AddWithValue("@NN", entity.NumeroNational);
                    command.Parameters.AddWithValue("@datedengagement", entity.Date);
                    connection.Open();
                    entity.UtilisateurId = (int)command.ExecuteScalar();
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
                    command.CommandText = "SP_Employe_Delete";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Employe> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Employe_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Employe()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                NumeroNational = (int)reader["NumeroNational"],
                                Date = (DateTime)reader["DateEngagement"],

                            };
                        }
                    }
                }
            }
        }

         public Employe Get(int id)
            {
                using (SqlConnection connection = new SqlConnection(_connecting))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "SP_Employe_GetById";
                        command.Parameters.AddWithValue("utilisateurId", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Employe()
                                {
                                    UtilisateurId = (int)reader["UtilisateurId"],
                                    NumeroNational = (int)reader["NumeroNational"],
                                    Date = (DateTime)reader["DateEngagement"],

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

         public void Update(int id, Employe entity)
            {
                using (SqlConnection connection = new SqlConnection(_connecting))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "SP_Employe_Update";
                        command.Parameters.AddWithValue("@utilisateurId", id);
                        command.Parameters.AddWithValue("@NN", entity.NumeroNational);
                        command.Parameters.AddWithValue("@dateDEngagement", entity.Date);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
         }
         public void Link(int id, Employe entity)
         {
                using (SqlConnection connection = new SqlConnection(_connecting))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "SP_Employe_Link";
                        command.Parameters.AddWithValue("@utilisateurId", id);
                        command.Parameters.AddWithValue("@idProjet", id);
                        command.Parameters.AddWithValue("@numeroTVA", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }

                }
         }
         public void Unlink(int id, Employe entity)
         {
                using (SqlConnection connection = new SqlConnection(_connecting))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "SP_Employe_Unlink";
                        command.Parameters.AddWithValue("@utilisateurId", id);
                        command.Parameters.AddWithValue("@idProjet", id);
                        command.Parameters.AddWithValue("@numeroTVA", id);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
         }
        
    }
}
