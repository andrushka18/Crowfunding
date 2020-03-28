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
    public class UtilisateurRepository:IUtilisateurRepository<int, Utilisateur>
    {
        private string _connecting = ConfigurationManager.ConnectionStrings["Crowfunding"].ConnectionString;

        public void Add(Utilisateur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Add";
                    command.Parameters.AddWithValue("@nom", entity.Nom);
                    command.Parameters.AddWithValue("@Penom", entity.Prenom);
                    command.Parameters.AddWithValue("@nom_utilisateur", entity.NomUtilisateur);
                    command.Parameters.AddWithValue("@motDePasse", entity.Password);
                    
                    connection.Open();
                    entity.UtilisateurId = (int)command.ExecuteScalar();
                }
            }
           
        }

        public void ChangePassword(int id, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_ChangePassword";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@motDePasse", password);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        [Obsolete]
        public int Check(string nomUtilisateur, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SP_Utilisateur_Check";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nom utilisateur", nomUtilisateur);
                cmd.Parameters.AddWithValue("mot de passe", password);

                cmd.Parameters.Add("utilisateurId", DbType.Int32).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters["utilisateurId"].Value;
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Delete";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Utilisateur> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_GetAll";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Utilisateur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Nom = (string)reader["Nom"],
                                Prenom = (string)reader["Prénom"],
                                NomUtilisateur = (string)reader["Nom Utilisateur"],
                                Password = "********",
                                
                            };
                        }
                    }
                }
            }
        }

        public Utilisateur Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_GetById";
                    command.Parameters.AddWithValue("utilisateurId", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Utilisateur()
                            {
                                UtilisateurId = (int)reader["UtilisateurId"],
                                Nom = (string)reader["Nom"],
                                Prenom = (string)reader["Prénom"],
                                NomUtilisateur = (string)reader["Nom Utilisateur"],
                                Password = "********",
                               
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

        public void Update(int id, Utilisateur entity)
        {
            using (SqlConnection connection = new SqlConnection(_connecting))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "SP_Utilisateur_Update";
                    command.Parameters.AddWithValue("@utilisateurId", id);
                    command.Parameters.AddWithValue("@nom", entity.Nom);
                    command.Parameters.AddWithValue("@prenom", entity.Prenom);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

      
    }
}
