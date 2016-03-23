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

        public void log_Actualizar_Media(Entities_ObjectFinder.Media.entMedia Media)
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
    }
}
