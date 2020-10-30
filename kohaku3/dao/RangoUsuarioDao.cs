using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kohaku3.dao
{
    public class RangoUsuarioDao
    {

        //objeto para interactuar con la base de datos
        kohakuEntities3 db = new kohakuEntities3();

        /**
        * retorna todos los rangos existentes en la base de datos
        */
        public List<rango_usuario> obtenerRangosDB()
        {
            var datos = from cli in db.rango_usuario select cli;
            List<rango_usuario> rangos = datos.ToList();
            return rangos;
        }
    }
}