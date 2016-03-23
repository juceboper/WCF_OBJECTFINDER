﻿using Dao_ObjectFinder.Datos;
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
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_objetoxusuario", new object[] { idUsuario }))
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

        public Int32 dao_Get_Nro_Objetos()
        {

            Int32 nroObjetos = 0;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_nro_objetos", new object[] { null }))
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
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_nro_objetosxestado", new object[] { idEstado }))
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

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> dao_Get_Objeto(int idEstado)
        {
            List<Entities_ObjectFinder.Objeto.entObjeto> lObjeto = new List<Entities_ObjectFinder.Objeto.entObjeto>();
            Entities_ObjectFinder.Objeto.entObjeto objObjeto;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_objetosxestado", new object[] { idEstado }))
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

    }
}	

