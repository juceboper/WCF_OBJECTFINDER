using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_ObjectFinder.Logica
{
    public static class Log_Objectfinder
    {
        //--------INSERT--------------------//
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

        //public static void log_Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto)
        //{
        //    Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

        //    objObjeto.dao_Crear_Objeto(Objeto);
        //}

        public static void log_Crear_Objeto(Entities_ObjectFinder.Objeto.entObjeto Objeto, out Int32 idObjeto)
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            objObjeto.dao_Crear_Objeto(Objeto,out idObjeto);
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

        //-------GETTER---------------//
        public static ICollection<Entities_ObjectFinder.Categoria.entCategoria> log_get_Categoria()
        {
            Dao_ObjectFinder.Categoria.daoCategoria objCategoria = new Dao_ObjectFinder.Categoria.daoCategoria();

            return objCategoria.dao_get_Categoria();
        }

        public static ICollection<Entities_ObjectFinder.Estado.entEstado> log_get_Estado()
        {
            Dao_ObjectFinder.Estado.daoEstado objEstado = new Dao_ObjectFinder.Estado.daoEstado();

            return objEstado.dao_get_Estado();
        }

        public static ICollection<Entities_ObjectFinder.Facultad.entFacultad> log_get_Facultad()
        {
            Dao_ObjectFinder.Facultad.daoFacultad objFacultad = new Dao_ObjectFinder.Facultad.daoFacultad();

            return objFacultad.dao_get_Facultad();
        }

        public static ICollection<Entities_ObjectFinder.Media.entMedia> log_Get_MediaxObjeto(int idObjeto)
        {
            Dao_ObjectFinder.Media.daoMedia objMedia = new Dao_ObjectFinder.Media.daoMedia();

            return objMedia.dao_Get_MediaxObjeto(idObjeto);
        }

        public static ICollection<Entities_ObjectFinder.Notificacion.entNotificacion> log_Get_Notificacion(int idObjeto)
        {
            Dao_ObjectFinder.Notificacion.daoNotificacion objNotificacion = new Dao_ObjectFinder.Notificacion.daoNotificacion();

            return objNotificacion.dao_Get_Notificacion(idObjeto);
        }

        public static ICollection<Entities_ObjectFinder.Objeto.entObjeto> log_Get_Objeto()
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            return objObjeto.dao_Get_Objeto();
        }

        public static ICollection<Entities_ObjectFinder.Media.entMedia> log_Get_Media_All()
        {
            Dao_ObjectFinder.Media.daoMedia objMedia = new Dao_ObjectFinder.Media.daoMedia();

            return objMedia.dao_Get_Media_All();
        }

        public static ICollection<Entities_ObjectFinder.Usuario.entUsuario> log_Get_Usuario()
        {
            Dao_ObjectFinder.Usuario.daoUsuario objUsuario = new Dao_ObjectFinder.Usuario.daoUsuario();

            return objUsuario.dao_Get_Usuario();
        }

        public static ICollection<Entities_ObjectFinder.Objeto.entObjeto> log_Get_ObjetoxUsuario(int idUsuario)
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            return objObjeto.dao_Get_ObjetoxUsuario(idUsuario);
        }

        public static Int32 dao_Get_Nro_Objetos()
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            return objObjeto.dao_Get_Nro_Objetos();
        }

        public static Int32 dao_Get_Nro_Objetos(int idEstado)
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            return objObjeto.dao_Get_Nro_Objetos(idEstado);
        }

        public static ICollection<Entities_ObjectFinder.Objeto.entObjeto> dao_Get_Objeto(int idEstado)
        {
            Dao_ObjectFinder.Objeto.daoObjeto objObjeto = new Dao_ObjectFinder.Objeto.daoObjeto();

            return objObjeto.dao_Get_Objeto(idEstado);
        }
    }
}
