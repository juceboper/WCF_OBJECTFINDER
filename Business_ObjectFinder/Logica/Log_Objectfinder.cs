using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_ObjectFinder.Logica
{
    public static class Log_Objectfinder
    {
        public static void log_Crear_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            Dao_ObjectFinder.Usuario.daoUsuario objUsuario = new Dao_ObjectFinder.Usuario.daoUsuario();

            objUsuario.dao_Crear_Usuario(Usuario);
        }

        public static void log_Actualizar_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            Dao_ObjectFinder.Usuario.daoUsuario objUsuario = new Dao_ObjectFinder.Usuario.daoUsuario();

            objUsuario.dao_Actualizar_Usuario(Usuario);
        }
    }
}
