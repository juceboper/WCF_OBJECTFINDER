using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_ObjectFinder.Facultad
{
    public class daoFacultad:BaseDatos
    {
        public ICollection<Entities_ObjectFinder.Facultad.entFacultad> dao_get_Facultad()
        {
            List<Entities_ObjectFinder.Facultad.entFacultad> lFacultad = new List<Entities_ObjectFinder.Facultad.entFacultad>();
            Entities_ObjectFinder.Facultad.entFacultad objFacultad;
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_facultades", new object[] { null }))
                {
                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objFacultad = new Entities_ObjectFinder.Facultad.entFacultad();

                            if(dbReader["ID_FACULTAD"] != null)
                                objFacultad.ID_FACULTAD = int.Parse(dbReader["ID_FACULTAD"].ToString());
                            if(dbReader["NOMBRE_FACULTAD"] != null)
                                objFacultad.NOMBRE_FACULTAD = dbReader["NOMBRE_FACULTAD"].ToString();
                            if(dbReader["ID_LOCALIDAD"] != null)
                                objFacultad.ID_LOCALIDAD = int.Parse(dbReader["ID_LOCALIDAD"].ToString());


                            lFacultad.Add(objFacultad);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lFacultad;
        }
    }
}
