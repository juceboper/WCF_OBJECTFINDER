using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Objeto
{
    [DataContract]
    public class entObjeto
    {
        [DataMember]
        public int idObjeto { get; set; }
        [DataMember]
        public int idCategoria { get; set; }
        [DataMember]
        public string nombreObjeto { get; set; }
        [DataMember]
        public string palabrasClaves { get; set; }
        [DataMember]
        public int idEstado { get; set; }
    }
}
