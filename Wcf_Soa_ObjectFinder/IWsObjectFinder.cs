using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_Soa_ObjectFinder
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsObjectFinder" in both code and config file together.
    [ServiceContract]
    public interface IWsObjectFinder
    {
        [OperationContract]
        void Crear_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario);

        [OperationContract]
        void Actualizar_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario);

        [OperationContract]
        void Crear_Registro(Entities_ObjectFinder.Registro.entRegistro Registro);

        [OperationContract]
        void Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto);

        [OperationContract]
        void Actualizar_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto);

        [OperationContract]
        void Crear_Notificacion(Entities_ObjectFinder.Notificacion.entNotificacion Notificacion);

        [OperationContract]
        void Crear_Media(Entities_ObjectFinder.Media.entMedia Media);

        [OperationContract]
        void log_Actualizar_Media(Entities_ObjectFinder.Media.entMedia Media);
    }
}
