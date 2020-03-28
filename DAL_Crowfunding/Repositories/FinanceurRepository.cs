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
    public class FinanceurRepository : IFinanceurRepository<int, Financeur>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["Crowfunding"].ConnectionString;
        public void Add(Financeur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Financeur_Add";
                    command.Parameters.AddWithValue("@montant", entity.Montant);
                    command.Parameters.AddWithValue("@prime", entity.Prime);
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
                    command.CommandText = "SP_Financeur_Delete";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Financeur> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Financeur_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Financeur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Montant = (Money)reader["Montant"],
                                Prime = (string)reader["Prime"],

                            };
                        }
                    }
                }
            }
        }

        public Financeur Get(int id)
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
                            return new Financeur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Montant = (Money)reader["Montant"],
                                Prime = (string)reader["Prime"],

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

        public void Update(int id, Financeur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Financeur_Update";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@montant", entity.Montant);
                    command.Parameters.AddWithValue("@prime", entity.Prime);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Link(int id, Financeur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Financeur_Link";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@idProjet", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
        }
        public void Unlink(int id, Financeur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Financeur_Unlink";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@idProjet", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
