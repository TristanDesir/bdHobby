using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiants
    {
        private List<SqlParameter> definirParametresAjout (Etudiants etudiant)
        {
            List<SqlParameter> mesParametres = new List<SqlParameter>();
            mesParametres.Add("@prenom", etudiants.Prenom == string.Empty ? DBNull.Value : etudiants.Prenom));
            mesParametres.Add("@Nom", etudiants.Nom == string.Empty ? DBNull.Value : etudiants.Nom));
            mesParametres.Add("@humour", etudiants.Humour == string.Empty ? DBNull.Value : etudiants.Humour));
            mesParametres.Add("@Cellulaire", etudiants.Cellulaire == string.Empty ? DBNull.Value : etudiants.Cellulaire));
            mesParametres.Add("@No_provenance", etudiants.No_provenance == string.Empty ? DBNull.Value : etudiants.No_provenance));
        }
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
                        List<SqlParameter> mesParametres;
                        mesParametres = definirParametresAjout(etudiant);
                        maCommande.Parameters.AddRange(mesParametres.ToArray());

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
