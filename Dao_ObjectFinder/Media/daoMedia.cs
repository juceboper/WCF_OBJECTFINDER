using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_ObjectFinder.Media
{
    public class daoMedia:BaseDatos
    {
        public daoMedia()
        {

        }

        public void dao_Crear_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_media", new object[] { Media }))
                {
                    dbDatos.ExecuteNonQuery(cmd);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void dao_Actualizar_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_update.sp_update_media", new object[] { Media }))
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
