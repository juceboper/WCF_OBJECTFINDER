using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Media
{
    public class entMedia
    {
        public int idObjeto { get; set; }

        public string tipoImagen { get; set; }

        public string nombreImagen { get; set; }

        public byte[] imagen { get; set; }
    }
}
