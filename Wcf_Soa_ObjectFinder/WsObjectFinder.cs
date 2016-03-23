using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_Soa_ObjectFinder
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsObjectFinder" in both code and config file together.
    public class WsObjectFinder:IWsObjectFinder
    {

        public void Crear_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            throw new NotImplementedException();
        }

        public void Actualizar_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            throw new NotImplementedException();
        }

        public void Crear_Registro(Entities_ObjectFinder.Registro.entRegistro Registro)
        {
            throw new NotImplementedException();
        }

        public void Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            throw new NotImplementedException();
        }

        public void Actualizar_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            throw new NotImplementedException();
        }

        public void Crear_Notificacion(Entities_ObjectFinder.Notificacion.entNotificacion Notificacion)
        {
            throw new NotImplementedException();
        }

        public void Crear_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            throw new NotImplementedException();
        }

        public void log_Actualizar_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            throw new NotImplementedException();
        }
    }
}
