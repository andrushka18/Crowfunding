using DAL_Crowfunding.Models;
using Google.Type;
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
    public class ProjetRepository : IProjetRepository<int, Projet>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["Crowfunding"].ConnectionString;
        public void Add(Projet entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Projets_Add";
                    command.Parameters.AddWithValue("@plafondFinance", entity.PlafondFinance);
                    command.Parameters.AddWithValue("@nom", entity.Nom);
                    command.Parameters.AddWithValue("@numeroCompte", entity.NumeroCompte);
                    command.Parameters.AddWithValue("@urlVideo", entity.UrlVideo);
                    connection.Open();
                    entity.IdProjet = (int)command.ExecuteScalar();
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
                    command.CommandText = "SP_Projets_Delete";
                    command.Parameters.AddWithValue("@idProjet", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }

        public IEnumerable<Projet> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Projets_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Projet()
                            {
                                IdProjet = (int)reader["Id Projet"],
                                Nom = (string)reader["Nom"],
                                PlafondFinance = (Money)reader["Plafond Projet"],
                                UrlVideo = (string)reader["Url Video"],
                                NumeroCompte = (string)reader["Compte"],

                            };
                        }
                    }
                }
            }
        }

        public Projet Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Projets_GetById";
                    command.Parameters.AddWithValue("IdProjet", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Projet()
                            {
                                IdProjet = (int)reader["Id Projet"],
                                Nom = (string)reader["Nom"],
                                PlafondFinance = (Money)reader["Plafond Projet"],
                                UrlVideo = (string)reader["Url Video"],
                                NumeroCompte = (string)reader["Compte"],

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

        public void Update(int id, Projet entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Update";
                    command.Parameters.AddWithValue("@IdProjet", id);
                    command.Parameters.AddWithValue("@nom", entity.Nom);
                    command.Parameters.AddWithValue("@numeroCompte", entity.NumeroCompte);
                    command.Parameters.AddWithValue("@plafondFinance", entity.PlafondFinance);
                    command.Parameters.AddWithValue("@urlVideo", entity.UrlVideo);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
