using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kohaku3.dao
{
    public class UsuarioDao
    {
        //objeto para interactuar con la base de datos
        kohakuEntities3 db = new kohakuEntities3();

        /**
         * guarda el usuario pasado por parametro en la base de datos
         */
        public Boolean crearUsuarioDB(usuario usuario)
        {
            long maxId;
            try
            {
                maxId = db.usuario.OrderByDescending(u => u.id_usuario).FirstOrDefault().id_usuario;
            }
            catch (Exception)
            {
                maxId = 0;
            }
           
            usuario.id_usuario= maxId + 1;
            db.usuario.Add(usuario);
            db.SaveChanges();
            return true;
        }

        /**
         * retorna todos los usuarios existentes en la base de datos
         */
        public List<usuario> obtenerUsuariosDB()
        {
            var datos = from cli in db.usuario select cli;
            List<usuario> users = datos.ToList();
            return users;
        }
    }
}