using Dao_ObjectFinder.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_ObjectFinder.Estado
{
    public class daoEstado:BaseDatos
    {
        public ICollection<Entities_ObjectFinder.Estado.entEstado> dao_get_Estado()
        {
            List<Entities_ObjectFinder.Estado.entEstado> lEstado = new List<Entities_ObjectFinder.Estado.entEstado>();
            Entities_ObjectFinder.Estado.entEstado objEstado;
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_estados", new object[] { null }))
                {
                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objEstado = new Entities_ObjectFinder.Estado.entEstado();

                            if(dbReader["ID_ESTADO"] != null)
                                objEstado.ID_ESTADO = int.Parse(dbReader["ID_ESTADO"].ToString());
                            if(dbReader["NOMBRE_ESTADO"] != null)
                                objEstado.NOMBRE_ESTADO = dbReader["NOMBRE_ESTADO"].ToString();

                            lEstado.Add(objEstado);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lEstado;
        }
    }
}
