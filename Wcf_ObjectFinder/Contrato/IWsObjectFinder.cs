using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_ObjectFinder
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWsObjectFinder" en el código y en el archivo de configuración a la vez.
    [ServiceContract(Namespace = "http://localhost:8080/Wcf_ObjectFinder/Servicio/")]
    public interface IWsObjectFinder
    {
        //-----------------INSERT-----------------------------//
        [OperationContract]
        void Crear_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario);

        [OperationContract]
        void Actualizar_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario);

        [OperationContract]
        void Crear_Registro(Entities_ObjectFinder.Registro.entRegistro Registro);

        //[OperationContract]
        //void Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto);

        [OperationContract]
        void Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto, out Int32 idObjeto);

        [OperationContract]
        void Actualizar_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto);

        [OperationContract]
        void Crear_Notificacion(Entities_ObjectFinder.Notificacion.entNotificacion Notificacion);

        [OperationContract]
        void Crear_Media(Entities_ObjectFinder.Media.entMedia Media);

        [OperationContract]
        void Actualizar_Media(Entities_ObjectFinder.Media.entMedia Media);

        //-------------GETTER--------------------------//
        [OperationContract]
        ICollection<Entities_ObjectFinder.Categoria.entCategoria> Get_Categoria();

        [OperationContract]
        ICollection<Entities_ObjectFinder.Estado.entEstado> Get_Estado();

        [OperationContract]
        ICollection<Entities_ObjectFinder.Facultad.entFacultad> Get_Facultad();

        [OperationContract]
        ICollection<Entities_ObjectFinder.Media.entMedia> Get_MediaxObjeto(int idObjeto);

        [OperationContract]
        ICollection<Entities_ObjectFinder.Notificacion.entNotificacion> Get_Notificacion(int idObjeto);

        [OperationContract]
        ICollection<Entities_ObjectFinder.Objeto.entObjeto> Get_Objeto_All();

        [OperationContract]
        ICollection<Entities_ObjectFinder.Media.entMedia> Get_Media_All();

        [OperationContract]
        ICollection<Entities_ObjectFinder.Usuario.entUsuario> Get_Usuario();

        [OperationContract]
        ICollection<Entities_ObjectFinder.Objeto.entObjeto> Get_ObjetoxUsuario(int idUsuario);

        [OperationContract]
        Int32 Get_Nro_Objetos_All();

        [OperationContract]
        Int32 Get_Nro_Objetos(int idEstado);

        [OperationContract]
        ICollection<Entities_ObjectFinder.Objeto.entObjeto> Get_Objeto(int idEstado);
    }
}
