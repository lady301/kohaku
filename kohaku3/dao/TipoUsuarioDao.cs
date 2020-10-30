using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kohaku3.dao
{
    public class TipoUsuarioDao
    {

        //objeto para interactuar con la base de datos
        kohakuEntities3 db = new kohakuEntities3();

        /**
        * retorna todos los tipos de usuario existentes en la base de datos
        */
        public List<tipo_usuario> obtenerTiposUserDB()
        {
            var datos = from cli in db.tipo_usuario select cli;
            List<tipo_usuario> tipos = datos.ToList();
            return tipos;
        }
    }
}