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

        public static void log_Crear_Registro(Entities_ObjectFinder.Registro.entRegistro Registro)
        {
            Dao_ObjectFinder.Registro.daoRegistro objRegistro = new Dao_ObjectFinder.Registro.daoRegistro();

            objRegistro.dao_Crear_Registro(Registro);
        }

        public static void log_Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            objObjeto.dao_Crear_Objeto(Objeto);
        }

        public static void log_Actualizar_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            objObjeto.dao_Actualizar_Objeto(Objeto);
        }

        public static void log_Crear_Notificacion(Entities_ObjectFinder.Notificacion.entNotificacion Notificacion)
        {
            Dao_ObjectFinder.Notificacion.daoNotificacion objNotificacion = new Dao_ObjectFinder.Notificacion.daoNotificacion();

            objNotificacion.dao_Crear_Notificacion(Notificacion);
        }

        public static void log_Crear_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            Dao_ObjectFinder.Media.daoMedia objMedia = new Dao_ObjectFinder.Media.daoMedia();

            objMedia.dao_Crear_Media(Media);
        }

        public static void log_Actualizar_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            Dao_ObjectFinder.Media.daoMedia objMedia = new Dao_ObjectFinder.Media.daoMedia();

            objMedia.dao_Actualizar_Media(Media);
        }
    }
}
