using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao_ObjectFinder.Datos;

namespace Dao_ObjectFinder.Usuario
{
    public class daoUsuario:BaseDatos
    {
        public daoUsuario()
        {
        }

        public void dao_Crear_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            try 
	        {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_usuario",new object[]{ Usuario }))
	            {
                    dbDatos.ExecuteNonQuery(cmd);
	            }
	        }
	        catch (Exception)
	        {	
		        throw;
	        }  
        }

        public void dao_Actualizar_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_update.sp_update_usuario", new object[] { Usuario }))
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
