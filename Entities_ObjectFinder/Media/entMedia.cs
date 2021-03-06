﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Media
{
    [DataContract]
    public class entMedia:Entities_ObjectFinder.Objeto.entObjeto
    {
        [DataMember]
        public int idMedia { get; set; }
        [DataMember]
        public int idObjeto { get; set; }
        [DataMember]
        public string tipoImagen { get; set; }
        [DataMember]
        public string nombreImagen { get; set; }
        [DataMember]
        public byte[] imagen { get; set; }
    }
}
