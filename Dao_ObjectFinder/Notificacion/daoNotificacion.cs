using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data;
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
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_notificacion"))
                {
                    dbDatos.AddInParameter(cmd, "PID_OBJETO", DbType.Int32, Notificacion.idObjeto);
                    dbDatos.AddInParameter(cmd, "PID_USUARIO", DbType.Int32, Notificacion.idUsuario);
                    dbDatos.AddInParameter(cmd, "PMENSAJE_NOTIFICACION", DbType.String, Notificacion.mensajeNotificacion);

                    dbDatos.ExecuteNonQuery(cmd);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public ICollection<Entities_ObjectFinder.Notificacion.entNotificacion> dao_Get_Notificacion(int idObjeto)
        {
            List<Entities_ObjectFinder.Notificacion.entNotificacion> lNotificacion = new List<Entities_ObjectFinder.Notificacion.entNotificacion>();
            Entities_ObjectFinder.Notificacion.entNotificacion objNotificacion;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_notificaciones"))
                {
                    dbDatos.AddInParameter(cmd, "PID_OBJETO", DbType.Int32, idObjeto);

                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objNotificacion = new Entities_ObjectFinder.Notificacion.entNotificacion();

                            if(dbReader["ID_NOTIFICACION"] != null)
                                objNotificacion.idNotificacion = int.Parse(dbReader["ID_NOTIFICACION"].ToString());
                            if(dbReader["ID_OBJETO"] != null)
                                objNotificacion.idObjeto = int.Parse(dbReader["ID_OBJETO"].ToString());
                            if(dbReader["ID_USUARIO"] != null)
                                objNotificacion.idUsuario = int.Parse(dbReader["ID_USUARIO"].ToString());
                            if(dbReader["FECHA_NOTIFICACION"] != null)
                                objNotificacion.fechaNotificacion = DateTime.Parse(dbReader["FECHA_NOTIFICACION"].ToString());
                            if(dbReader["MENSAJE_NOTIFICACION"] != null)
                                objNotificacion.mensajeNotificacion = dbReader["MENSAJE_NOTIFICACION"].ToString();


                            lNotificacion.Add(objNotificacion);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lNotificacion;
        }

    }
}

	
	
	
	
	

