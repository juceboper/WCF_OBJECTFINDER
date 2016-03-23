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

        public void Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        {
            try
            {
                Business_ObjectFinder.Logica.Log_Objectfinder.log_Crear_Objeto(Objeto);
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

        public ICollection<Entities_ObjectFinder.Objeto.entObjeto> Get_Objeto()
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
              return  Business_ObjectFinder.Logica.Log_Objectfinder.log_Get_Usuario();
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

        public int Get_Nro_Objetos()
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
