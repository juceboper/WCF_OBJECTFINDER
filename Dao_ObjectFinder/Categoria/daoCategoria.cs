using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dao_ObjectFinder.Datos;
using System.Data.Common;

namespace Dao_ObjectFinder.Categoria
{
    public class daoCategoria:BaseDatos
    {
        public daoCategoria()
        {

        }

        public ICollection<Entities_ObjectFinder.Categoria.entCategoria> dao_get_Categoria()
        {
                List<Entities_ObjectFinder.Categoria.entCategoria> lCategoria = new List<Entities_ObjectFinder.Categoria.entCategoria>();
                Entities_ObjectFinder.Categoria.entCategoria objCategoria;
            try
            {
                using(DbCommand cmd = dbDatos.GetStoredProcCommand("pkg_getter.sp_get_categorias"))
                {
                    using(IDataReader dbReader = dbDatos.ExecuteReader(cmd))
                    {
                        while(dbReader.Read())
                        {
                            objCategoria = new Entities_ObjectFinder.Categoria.entCategoria();

                            if(dbReader["ID_CATEGORIA"] != null)
                                objCategoria.ID_CATEGORIA = int.Parse(dbReader["ID_CATEGORIA"].ToString());
                            if(dbReader["NOMBRE_CATEGORIA"] != null)
                                objCategoria.NOMBRE_CATEGORIA = dbReader["NOMBRE_CATEGORIA"].ToString();

                            lCategoria.Add(objCategoria);
                        }
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }

            return lCategoria;
        }
    }
}
