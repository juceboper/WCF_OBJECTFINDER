using Dao_ObjectFinder.Datos;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
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

        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file. 
            return "DATA SOURCE=proyectoud.cuegptboywjw.us-west-2.rds.amazonaws.com:1521/OBJECTF;PERSIST SECURITY INFO=True;USER ID=ADMIN;Password=Pa$$w0rd";
        }

        public void dao_Crear_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            try
            {
                string connectionString = GetConnectionString();
                using(OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    using(OracleCommand cmd = connection.CreateCommand())//GetStoredProcCommand("pkg_insert.sp_insert_media"))
                    {
                        cmd.CommandText = "pkg_insert.sp_insert_media";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("PID_OBJETO", OracleDbType.Int32).Value = Media.idObjeto;
                        cmd.Parameters.Add("PTIPO_IMAGEN", OracleDbType.Varchar2).Value = Media.tipoImagen;
                        cmd.Parameters.Add("PNOMBRE_IMAGEN", OracleDbType.Varchar2).Value = Media.nombreImagen;
                        cmd.Parameters.Add("PIMAGEN", OracleDbType.Blob).Value = Media.imagen;

                        cmd.ExecuteNonQuery();
                    }
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
                string connectionString = GetConnectionString();
                using(OracleConnection connection = new OracleConnection())
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();

                    using(OracleCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandText = "pkg_update.sp_update_media";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("PID_OBJETO", OracleDbType.Int32).Value = Media.idObjeto;
                        cmd.Parameters.Add("PTIPO_IMAGEN", OracleDbType.Varchar2).Value = Media.tipoImagen;
                        cmd.Parameters.Add("PNOMBRE_IMAGEN", OracleDbType.Varchar2).Value = Media.nombreImagen;
                        cmd.Parameters.Add("PIMAGEN", OracleDbType.Blob).Value = Media.imagen;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public ICollection<Entities_ObjectFinder.Media.entMedia> dao_Get_MediaxObjeto(int idObjeto)
        {
            List<Entities_ObjectFinder.Media.entMedia> lMedia = new List<Entities_ObjectFinder.Media.entMedia>();
            Entities_ObjectFinder.Media.entMedia objMedia;
            
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_mediasxobjeto"))
                {
                    dbDatos.AddInParameter(cmd, "PID_OBJETO", DbType.Int32, idObjeto);

                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objMedia = new Entities_ObjectFinder.Media.entMedia();

                            if(dbReader["ID_MEDIA"] != null)
                                objMedia.idMedia = int.Parse(dbReader["ID_MEDIA"].ToString());
                            if(dbReader["ID_OBJETO"] != null)
                                objMedia.idObjeto = int.Parse(dbReader["ID_OBJETO"].ToString());
                            if(dbReader["TIPO_IMAGEN"] != null)
                                objMedia.tipoImagen = dbReader["TIPO_IMAGEN"].ToString();
                            if(dbReader["IMAGEN"] != null)
                                objMedia.imagen = (byte[])((dbReader["IMAGEN"]));
                            if(dbReader["NOMBRE_IMAGEN"] != null)
                                objMedia.nombreImagen = dbReader["NOMBRE_IMAGEN"].ToString();


                            lMedia.Add(objMedia);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lMedia;
        }

        public ICollection<Entities_ObjectFinder.Media.entMedia> dao_Get_Media_All()
        {
            List<Entities_ObjectFinder.Media.entMedia> lMedia = new List<Entities_ObjectFinder.Media.entMedia>();
            Entities_ObjectFinder.Media.entMedia objMedia;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_objetosximagen"))
                {
                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objMedia = new Entities_ObjectFinder.Media.entMedia();

                            if(dbReader["ID_MEDIA"] != null)
                                objMedia.idMedia = int.Parse(dbReader["ID_MEDIA"].ToString());
                            if(dbReader["ID_OBJETO"] != null)
                                objMedia.idObjeto = int.Parse(dbReader["ID_OBJETO"].ToString());
                            if(dbReader["TIPO_IMAGEN"] != null)
                                objMedia.tipoImagen = dbReader["TIPO_IMAGEN"].ToString();
                            if(dbReader["IMAGEN"] != null)
                                objMedia.imagen = objMedia.imagen = (byte[])((dbReader["IMAGEN"]));
                            if(dbReader["NOMBRE_IMAGEN"] != null)
                                objMedia.nombreImagen = dbReader["NOMBRE_IMAGEN"].ToString();
                            if(dbReader["NOMBRE_OBJETO"] != null)
                                objMedia.nombreObjeto = dbReader["NOMBRE_OBJETO"].ToString();


                            lMedia.Add(objMedia);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lMedia;
        }

        //private byte[] ReadFile(string sPath)
        //{
        //    byte[] data = null;

        //    FileInfo fInfo = new FileInfo(sPath);

        //    long numBytes = fInfo.Length;

        //    FileStream fStream = new  FileStream(sPath, FileMode.Open, FileAccess.Read);

        //    BinaryReader br = new  BinaryReader(fStream);

        //    data = br.ReadBytes((int)numBytes);

        //    return  data;
        //}
    }
}

	

