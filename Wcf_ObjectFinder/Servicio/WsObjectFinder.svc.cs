using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_ObjectFinder
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WsObjectFinder" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WsObjectFinder.svc o WsObjectFinder.svc.cs en el Explorador de soluciones e inicie la depuración.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, Namespace = "http://localhost:51565/Wcf_ObjectFinder/Servicio/")]
    public class WsObjectFinder:IWsObjectFinder
    {
        public void Crear_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            try
            {
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Crear_Usuario(Usuario);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Actualizar_Usuario(Entities_ObjectFinder.Usuario.entUsuario Usuario)
        {
            try
            {
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Actualizar_Usuario(Usuario);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Crear_Registro(Entities_ObjectFinder.Registro.entRegistro Registro)
        {
            try
            {
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Crear_Registro(Registro);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        //public void Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        //{
        //    try
        //    {
        //        Business_ObjectFinder.Logica.Log_Objectfinder.log_Crear_Objeto(Objeto);
        //    }
        //    catch(FaultException ex)
        //    {
        //        throw new FaultException(ex.Message);
        //    }
        //}

        public void Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto, out Int32 idObjeto)
        {
            try
            {
                idObjeto = 0;

                Business_ObjectFinder.Logica.Log_Objectfinder.log_Crear_Objeto(Objeto, out idObjeto);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Actualizar_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            try
            {
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Actualizar_Objeto(Objeto);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Crear_Notificacion(Entities_ObjectFinder.Notificacion.entNotificacion Notificacion)
        {
            try
            {
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Crear_Notificacion(Notificacion);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Crear_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            try
            {
                //String SourceLoc = "C:/Julio.png";
                //FileStream fs = new FileStream(SourceLoc, FileMode.Open, FileAccess.Read);

                //// Create a byte array of file stream length
                //byte[] ImageData = new byte[fs.Length];

                ////Read block of bytes from stream into the byte array
                //fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));

                ////Close the File Stream
                //fs.Close();

                //Media.imagen = ImageData;
                //Media.idCategoria = 1;
                //Media.idEstado = 1;
                //Media.idObjeto = 65;
                //Media.nombreImagen = fs.Name;
                //Media.tipoImagen = "jpg";

                //String DestinationLoc = "D:/Images/TestImage.jpg";
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Crear_Media(Media);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Actualizar_Media(Entities_ObjectFinder.Media.entMedia Media)
        {
            try
            {
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Actualizar_Media(Media);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Categoria.entCategoria> Get_Categoria()
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_get_Categoria();
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Estado.entEstado> Get_Estado()
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_get_Estado();
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Facultad.entFacultad> Get_Facultad()
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_get_Facultad();
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Media.entMedia> Get_MediaxObjeto(int idObjeto)
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_Get_MediaxObjeto(idObjeto);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Notificacion.entNotificacion> Get_Notificacion(int idObjeto)
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_Get_Notificacion(idObjeto);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> Get_Objeto_All()
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_Get_Objeto();
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Media.entMedia> Get_Media_All()
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_Get_Media_All();
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Usuario.entUsuario> Get_Usuario()
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_Get_Usuario();
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> Get_ObjetoxUsuario(int idUsuario)
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.log_Get_ObjetoxUsuario(idUsuario);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int Get_Nro_Objetos_All()
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.dao_Get_Nro_Objetos();
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public int Get_Nro_Objetos(int idEstado)
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.dao_Get_Nro_Objetos(idEstado);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> Get_Objeto(int idEstado)
        {
            try
            {
                return Business_ObjectFinder.Logica.Log_Objectfinder.dao_Get_Objeto(idEstado);
            }
            catch(FaultException ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
