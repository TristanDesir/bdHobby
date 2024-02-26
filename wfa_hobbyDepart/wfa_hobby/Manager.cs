using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class Manager
    {
        // protected signifie utilisable que par ses filles, sans new

        protected SqlCommand CreerCommande(string nomProcedureStockee,List<SqlParameter> mesParametresSql)
        {
            var maCommand = new SqlCommand(nomProcedureStockee,GetConnection());
            // definir le commandtype
        }

        protected SqlConnection
        
    }
}
