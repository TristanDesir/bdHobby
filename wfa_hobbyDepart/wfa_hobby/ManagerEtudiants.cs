using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiants
    {
        public int AjouterEtudiants(Etudiants etudiants)
        {
         
            int nombreDeLigneAffectee = 0;
            try
            {
                using (var maConnexion = new SqlConnection(Properties.Settings.Default.maConnectionString))
                {
                    using (var maCommande = new SqlCommand("ajouterEtudiant", maConnexion))
                    {
                        //commandtype
                        maCommande.CommandType = System.Data.CommandType.StoredProcedure;

                        //les parametres
                        maCommande.Parameters.Add(new SqlParameter("@prenom", etudiants.Prenom == string.Empty ? DBNull.Value: etudiants.Prenom)) ;
                        maCommande.Parameters.Add(new SqlParameter("@Nom", etudiants.Nom == string.Empty ? DBNull.Value : etudiants.Nom));
                        maCommande.Parameters.Add(new SqlParameter("@humour", etudiants.Humour == string.Empty ? DBNull.Value : etudiants.Humour));
                        maCommande.Parameters.Add(new SqlParameter("@Cellulaire", etudiants.Cellulaire == string.Empty ? DBNull.Value : etudiants.Cellulaire));
                        maCommande.Parameters.Add(new SqlParameter("@No_provenance", etudiants.No_provenance == string.Empty ? DBNull.Value : etudiants.No_provenance));

                        //ouvrir la connexion
                        maCommande.Connection = maCommande.Connection;
                        //exec la commande
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return nombreDeLigneAffectee;
        }
    }
}
