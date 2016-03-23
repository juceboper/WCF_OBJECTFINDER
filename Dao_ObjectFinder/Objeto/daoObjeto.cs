using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_ObjectFinder.Objeto
{
    public class daoObjeto:BaseDatos
    {
        public daoObjeto()
        {

        }

        public void dao_Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_objeto", new object[] { Objeto }))
                {
                    dbDatos.ExecuteNonQuery(cmd);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void dao_Actualizar_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_update.sp_update_objeto", new object[] { Objeto }))
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
