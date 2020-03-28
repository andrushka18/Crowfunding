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
    public class ValideurRepository : IValideurRepository<int, Valideur>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["Crowfunding"].ConnectionString;
        public void Add(Valideur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Valideur_Add";
                    command.Parameters.AddWithValue("@status", entity.Status);
                    command.Parameters.AddWithValue("@commentaire", entity.Commentaire);
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
                    command.CommandText = "SP_Valideur_Delete";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Valideur> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Valideur_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Valideur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Status = (string)reader["Status"],
                                Commentaire = (string)reader["Commentaire"],

                            };
                        }
                    }
                }
            }
        }

        public Valideur Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Valideur_GetById";
                    command.Parameters.AddWithValue("utilisateurId", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Valideur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Status = (string)reader["Status"],
                                Commentaire = (string)reader["Commentaire"],

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

        public void Update(int id, Valideur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Valideur_Update";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@status", entity.Status);
                    command.Parameters.AddWithValue("@commentaire", entity.Commentaire);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Link(int id, Valideur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Valideur_Link";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@idProjet", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
        }
        public void Unlink(int id, Valideur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Valideur_Unlink";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@idProjet", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }



            }
        }
    }
}
