using Microsoft.Practices.EnterpriseLibrary.Data;

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
