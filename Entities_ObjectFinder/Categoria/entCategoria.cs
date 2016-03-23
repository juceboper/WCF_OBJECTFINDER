using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Categoria
{
    [DataContract]
    public class entCategoria
    {
        [DataMember]
        public int ID_CATEGORIA { get; set; }
        [DataMember]
        public string NOMBRE_CATEGORIA { get; set; }        
    }
}
