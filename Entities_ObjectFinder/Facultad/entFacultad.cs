using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Facultad
{
    [DataContract]
    public class entFacultad
    {
        [DataMember]
        public int ID_FACULTAD { get; set; }
        [DataMember]
        public string NOMBRE_FACULTAD { get; set; }
        [DataMember]
        public int ID_LOCALIDAD { get; set; }
    }
}
