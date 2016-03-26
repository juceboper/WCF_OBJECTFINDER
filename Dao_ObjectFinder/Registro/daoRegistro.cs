using Dao_ObjectFinder.Datos;
using System;
using System.Data;
using System.Data.Common;

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
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_registro"))
                {
                    dbDatos.AddInParameter(cmd, "PID_OBJETO",DbType.Int32, Registro.idObjeto);
                    dbDatos.AddInParameter(cmd, "PID_USUARIO", DbType.Int32, Registro.idUsuario);
                    dbDatos.AddInParameter(cmd, "PID_FACULTAD", DbType.Int32, Registro.idFacultad);
                    dbDatos.AddInParameter(cmd, "PID_ESTADO", DbType.Int32, Registro.idEstado);
                    dbDatos.AddInParameter(cmd, "POBSERVACION", DbType.String, Registro.observacion);

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