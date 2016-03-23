using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_ObjectFinder.Datos
{
    public class BaseDatos
    {
        protected Database dbDatos;

        public Database Instance()
        {
            string CadenaConexion = "ConexionObjectFinder";
            return DatabaseFactory.CreateDatabase(CadenaConexion);
        }

        public BaseDatos()
        {
            dbDatos = Instance();
        }
    }
}
