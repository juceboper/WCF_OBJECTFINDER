using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Usuario
{
    [DataContract]
    public class entUsuario
    {
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public string primerNombre { get; set; }
        [DataMember]
        public string segundoNombre { get; set; }
        [DataMember]
        public string primerApellido { get; set; }
        [DataMember]
        public string segundoApellido { get; set; }
        [DataMember]
        public int idEstado { get; set; }
        [DataMember]
        public int telefono { get; set; }
        [DataMember]
        public int celular { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public DateTime fechaNacimiento { get; set; }
        [DataMember]
        public char genero { get; set; }
        [DataMember]
        public int idIntegracion { get; set; }
        [DataMember]
        public string usuario { get; set; }
        [DataMember]
        public string clave { get; set; }
        [DataMember]
        public DateTime fechaRegistro { get; set; }

    }
}
