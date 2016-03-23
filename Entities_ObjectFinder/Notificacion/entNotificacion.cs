using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Notificacion
{
    [DataContract]
    public class entNotificacion
    {
        [DataMember]
        public int idObjeto { get; set; }
        [DataMember]
        public int idUsuario { get; set; }
        [DataMember]
        public string mensajeNotificacion { get; set; }
    }
}
