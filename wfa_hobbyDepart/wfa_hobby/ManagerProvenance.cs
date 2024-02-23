using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerProvenance
    {
        public List<Provenance> ListerProvenance()
        {
            List<Provenance>
            using(var maConnexion = new SqlConnection(Properties.Settings.Default.maConnectionString))
            {
                using (var maCommande = new SqlCommand("Lister Provenance", maConnexion))
                {
                    // definir commandType
                    maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                    // definir parametres 
                    
                    // ouvrir connexion
                    // executer sp
                    using (var monDataReader = maCommande.ExecuteReader())
                    {
                        while (monDataReader.Read())
                        {
                            Provenance provenance = new Provenance();
                            provenance.No_provenance = (int)monDataReader["no_provenance"]
                            provenance.ProvenanceDescription = monDataReader["Description"].ToString();
                            maListe.Add(provenance);
                        }
                    }
                    // lire resultats
                }

            }
            return maListe;
        }
    }
}
