using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data;
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

        //public void dao_Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        //{
        //    try
        //    {
        //        using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_objeto"))
        //        {
        //            dbDatos.AddInParameter(cmd, "PID_CATEGORIA", DbType.Int32, Objeto.idCategoria);
        //            dbDatos.AddInParameter(cmd, "PNOMBRE_OBJETO", DbType.String, Objeto.nombreObjeto);
        //            dbDatos.AddInParameter(cmd, "PPALABRAS_CLAVES", DbType.String, Objeto.palabrasClaves);
        //            dbDatos.AddInParameter(cmd, "PID_ESTADO", DbType.Int32, Objeto.idEstado);

        //            dbDatos.ExecuteNonQuery(cmd);
        //        }
        //    }
        //    catch(Exception)
        //    {
        //        throw;
        //    }
        //}

        public void dao_Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto, out Int32 idObjeto)
        {
            try
            {
                idObjeto = 0;

                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_insert.sp_insert_objeto"))
                {
                    dbDatos.AddInParameter(cmd, "PID_CATEGORIA", DbType.Int32, Objeto.idCategoria);
                    dbDatos.AddInParameter(cmd, "PNOMBRE_OBJETO", DbType.String, Objeto.nombreObjeto);
                    dbDatos.AddInParameter(cmd, "PPALABRAS_CLAVES", DbType.String, Objeto.palabrasClaves);
                    dbDatos.AddInParameter(cmd, "PID_ESTADO", DbType.Int32, Objeto.idEstado);

                    dbDatos.AddOutParameter(cmd, "PID_OBJETO", DbType.Int32, 20);               
                    

                    dbDatos.ExecuteNonQuery(cmd);

                    idObjeto = Int32.Parse(dbDatos.GetParameterValue(cmd, "PID_OBJETO").ToString());
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
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_update.sp_update_objeto"))
                {
                    dbDatos.AddInParameter(cmd, "pid_objeto", DbType.Int32, Objeto.idObjeto);
                    dbDatos.AddInParameter(cmd, "PID_CATEGORIA", DbType.Int32, Objeto.idCategoria);
                    dbDatos.AddInParameter(cmd, "pnombre", DbType.String, Objeto.nombreObjeto);
                    dbDatos.AddInParameter(cmd, "p_pal_clave", DbType.String, Objeto.palabrasClaves);
                    dbDatos.AddInParameter(cmd, "PID_ESTADO", DbType.Int32, Objeto.idEstado);

                    dbDatos.ExecuteNonQuery(cmd);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> dao_Get_Objeto()
        {
            List<Entities_ObjectFinder.Objeto.entObjeto> lObjeto = new List<Entities_ObjectFinder.Objeto.entObjeto>();
            Entities_ObjectFinder.Objeto.entObjeto objObjeto;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_objetos", new object[] { null }))
                {
                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objObjeto = new Entities_ObjectFinder.Objeto.entObjeto();

                            if(dbReader["ID_OBJETO"] != null)
                                objObjeto.idObjeto = int.Parse(dbReader["ID_OBJETO"].ToString());
                            if(dbReader["ID_CATEGORIA"] != null)
                                objObjeto.idCategoria = int.Parse(dbReader["ID_CATEGORIA"].ToString());
                            if(dbReader["NOMBRE_OBJETO"] != null)
                                objObjeto.nombreObjeto = dbReader["NOMBRE_OBJETO"].ToString();
                            if(dbReader["PALABRAS_CLAVES"] != null)
                                objObjeto.palabrasClaves = dbReader["PALABRAS_CLAVES"].ToString();
                            if(dbReader["ID_ESTADO"] != null)
                                objObjeto.idEstado = int.Parse(dbReader["ID_ESTADO"].ToString());

                            lObjeto.Add(objObjeto);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lObjeto;
        }

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> dao_Get_ObjetoxUsuario(int idUsuario)
        {
            List<Entities_ObjectFinder.Objeto.entObjeto> lObjeto = new List<Entities_ObjectFinder.Objeto.entObjeto>();
            Entities_ObjectFinder.Objeto.entObjeto objObjeto;

            try
            {

                using(DbCommand cmd = dbDatos.GetStoredProcCommand("PKG_GETTER.SP_GET_OBJETOXUSUARIO"))
                {
                    dbDatos.AddInParameter(cmd, "PID_USUARIO", DbType.Int32, idUsuario);

                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {

                        while(dbReader.Read())
                        {
                            objObjeto = new Entities_ObjectFinder.Objeto.entObjeto();

                            if(dbReader["ID_OBJETO"] != null)
                                objObjeto.idObjeto = int.Parse(dbReader["ID_OBJETO"].ToString());
                            if(dbReader["ID_CATEGORIA"] != null)
                                objObjeto.idCategoria = int.Parse(dbReader["ID_CATEGORIA"].ToString());
                            if(dbReader["NOMBRE_OBJETO"] != null)
                                objObjeto.nombreObjeto = dbReader["NOMBRE_OBJETO"].ToString();
                            if(dbReader["PALABRAS_CLAVES"] != null)
                                objObjeto.palabrasClaves = dbReader["PALABRAS_CLAVES"].ToString();
                            if(dbReader["ID_ESTADO"] != null)
                                objObjeto.idEstado = int.Parse(dbReader["ID_ESTADO"].ToString());

                            lObjeto.Add(objObjeto);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lObjeto;
        }

        public Int32 dao_Get_Nro_Objetos()
        {

            Int32 nroObjetos = 0;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_nro_objetos"))
                {
                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            if(dbReader["NRO_OBJETOS"] != null)
                                nroObjetos = int.Parse(dbReader["NRO_OBJETOS"].ToString());
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return nroObjetos;
        }

        public Int32 dao_Get_Nro_Objetos(int idEstado)
        {

            Int32 nroObjetos = 0;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_nro_objetosxestado"))
                {
                    dbDatos.AddInParameter(cmd, "PID_ESTADO", DbType.Int32, idEstado);

                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            if(dbReader["NRO_OBJETOS"] != null)
                                nroObjetos = int.Parse(dbReader["NRO_OBJETOS"].ToString());
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return nroObjetos;
        }

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> dao_Get_Objeto(int idEstado)
        {
            List<Entities_ObjectFinder.Objeto.entObjeto> lObjeto = new List<Entities_ObjectFinder.Objeto.entObjeto>();
            Entities_ObjectFinder.Objeto.entObjeto objObjeto;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_objetosxestado"))
                {
                    dbDatos.AddInParameter(cmd, "PID_ESTADO", DbType.Int32, idEstado);

                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objObjeto = new Entities_ObjectFinder.Objeto.entObjeto();

                            if(dbReader["ID_OBJETO"] != null)
                                objObjeto.idObjeto = int.Parse(dbReader["ID_OBJETO"].ToString());
                            if(dbReader["ID_CATEGORIA"] != null)
                                objObjeto.idCategoria = int.Parse(dbReader["ID_CATEGORIA"].ToString());
                            if(dbReader["NOMBRE_OBJETO"] != null)
                                objObjeto.nombreObjeto = dbReader["NOMBRE_OBJETO"].ToString();
                            if(dbReader["PALABRAS_CLAVES"] != null)
                                objObjeto.palabrasClaves = dbReader["PALABRAS_CLAVES"].ToString();
                            if(dbReader["ID_ESTADO"] != null)
                                objObjeto.idEstado = int.Parse(dbReader["ID_ESTADO"].ToString());

                            lObjeto.Add(objObjeto);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lObjeto;
        }

    }
}

