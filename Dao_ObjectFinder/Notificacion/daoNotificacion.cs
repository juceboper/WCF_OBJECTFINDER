using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_ObjectFinder.Notificacion
{
    public class daoNotificacion:BaseDatos
    {
        public daoNotificacion()
        {

        }

        public void dao_Crear_Notificacion(Entities_ObjectFinder.Notificacion.entNotificacion Notificacion)
        {
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_notificacion", new object[] { Notificacion }))
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
