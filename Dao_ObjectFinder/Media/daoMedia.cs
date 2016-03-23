using Dao_ObjectFinder.Datos;
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

        public ICollection<Entities_ObjectFinder.Media.entMedia> dao_Get_MediaxObjeto(int idObjeto)
        {
            List<Entities_ObjectFinder.Media.entMedia> lMedia = new List<Entities_ObjectFinder.Media.entMedia>();
            Entities_ObjectFinder.Media.entMedia objMedia;

            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_mediasxobjeto", new object[] { idObjeto }))
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
                                objMedia.imagen = BitConverter.GetBytes(byte.Parse(dbReader["IMAGEN"].ToString()));
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
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_objetosximagen", new object[] { null }))
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
                                objMedia.imagen = BitConverter.GetBytes(byte.Parse(dbReader["IMAGEN"].ToString()));
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

	

