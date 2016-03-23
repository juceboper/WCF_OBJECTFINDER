using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_ObjectFinder.Registro
{
    public class daoRegistro:BaseDatos
    {
        public daoRegistro()
        {

        }

        public void dao_Crear_Registro(Entities_ObjectFinder.Registro.entRegistro Registro)
        {
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_registro", new object[] { Registro }))
                {
                    dbDatos.ExecuteNonQuery(cmd);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
