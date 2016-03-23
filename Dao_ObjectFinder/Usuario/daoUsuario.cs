using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao_ObjectFinder.Datos;
using System.Data;

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

        public ICollection<Entities_ObjectFinder.Usuario.entUsuario> dao_Get_Usuario()
        {
            List<Entities_ObjectFinder.Usuario.entUsuario> lUsuario = new List<Entities_ObjectFinder.Usuario.entUsuario>();
            Entities_ObjectFinder.Usuario.entUsuario objUsuario;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_usuarios", new object[] { null }))
                {
                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objUsuario = new Entities_ObjectFinder.Usuario.entUsuario();

                            if(dbReader["ID_USUARIO"] != null)
                                objUsuario.idUsuario = int.Parse(dbReader["ID_USUARIO"].ToString());
                            if(dbReader["PRIMER_NOMBRE"] != null)
                                objUsuario.primerNombre = dbReader["PRIMER_NOMBRE"].ToString();
                            if(dbReader["SEGUNDO_NOMBRE"] != null)
                                objUsuario.segundoNombre = dbReader["SEGUNDO_NOMBRE"].ToString();
                            if(dbReader["PRIMER_APELLIDO"] != null)
                                objUsuario.primerApellido = dbReader["PRIMER_APELLIDO"].ToString();
                            if(dbReader["SEGUNDO_APELLIDO"] != null)
                                objUsuario.segundoApellido = dbReader["SEGUNDO_APELLIDO"].ToString();
                            if(dbReader["FECHA_REGISTRO"] != null)
                                objUsuario.fechaRegistro = DateTime.Parse(dbReader["FECHA_REGISTRO"].ToString());
                            if(dbReader["ID_ESTADO"] != null)
                                objUsuario.idEstado = int.Parse(dbReader["ID_ESTADO"].ToString());
                            if(dbReader["TELEFONO"] != null)
                                objUsuario.telefono = int.Parse(dbReader["TELEFONO"].ToString());
                            if(dbReader["CELULAR"] != null)
                                objUsuario.celular = int.Parse(dbReader["CELULAR"].ToString());
                            if(dbReader["EMAIL"] != null)
                                objUsuario.email = dbReader["EMAIL"].ToString();
                            if(dbReader["FECHA_NACIMIENTO"] != null)
                                objUsuario.fechaNacimiento = DateTime.Parse(dbReader["FECHA_NACIMIENTO"].ToString());
                            if(dbReader["GENERO"] != null)
                                objUsuario.genero = char.Parse(dbReader["GENERO"].ToString());
                            if(dbReader["ID_INTEGRACION"] != null)
                                objUsuario.idIntegracion = int.Parse(dbReader["ID_INTEGRACION"].ToString());
                            if(dbReader["USUARIO"] != null)
                                objUsuario.usuario = dbReader["USUARIO"].ToString();

                            lUsuario.Add(objUsuario);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lUsuario;
        }
    }
}