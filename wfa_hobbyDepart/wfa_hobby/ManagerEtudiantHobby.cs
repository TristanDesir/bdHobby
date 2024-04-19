using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiantHobby : Manager
    {
        public List<Hobby> ListerHobbyDUnEtudiant(int no_etudiant)
        {
            List <Hobby> maListe = new List<Hobby>();
            try
            {
                using (var maConnexion = getConnection())
                {
                    List<SqlParameter> mesParametres = new List<SqlParameter>();
                    mesParametres.Add(new SqlParameter("@no_etudiant", no_etudiant==0? DBNull.Value:no_etudiant));
                    using (var maCommande = CreerCommande("ListerHobbyDUnEtudiant", mesParametres))
                    {
                        using (var monDataReader = maCommande.ExecuteReader())
                        {
                            while (monDataReader.Read())
                            {
                                Hobby hobby = new Hobby();
                                hobby.No_hobby = monDataReader["no_hobby"].
                                hobby.HobbyDescription = monDataReader["hobby"].ToString();
                                maListe.Add(hobby);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<SqlParameter> 
    }
}
