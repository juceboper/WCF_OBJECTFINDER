using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_ObjectFinder.Usuario
{
    public class entUsuario
    {
        public string primerNombre { get; set; }

        public string segundoNombre { get; set; }

        public string primerApellido { get; set; }

        public string segundoApellido { get; set; }

        public int idEstado { get; set; }

        public int telefono { get; set; }

        public int celular { get; set; }

        public string email { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public char genero { get; set; }

        public int idIntegracion { get; set; }

        public string usuario { get; set; }

        public string clave { get; set; }

    }
}
