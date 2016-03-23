using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Registro
{
    [DataContract]
    public class entRegistro
    {
        [DataMember]
        public int idObjeto { get; set; }
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public int idFacultad { get; set; }
        [DataMember]
        public int idEstado { get; set; }
        [DataMember]
        public string observacion { get; set; }
    }
}
