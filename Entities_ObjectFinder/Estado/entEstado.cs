using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Estado
{
    [DataContract]
    public class entEstado
    {
        [DataMember]
        public int ID_ESTADO { get; set; }
        [DataMember]
        public string NOMBRE_ESTADO { get; set; }
    }
}
