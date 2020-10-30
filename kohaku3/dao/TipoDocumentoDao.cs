using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kohaku3.dao
{
    public class TipoDocumentoDao
    {

        //objeto para interactuar con la base de datos
        kohakuEntities3 db = new kohakuEntities3();

        /**
        * retorna todos los tipos de documento existentes en la base de datos
        */
        public List<tipo_documento> obtenerTiposDocumentoDB()
        {
            var datos = from cli in db.tipo_documento select cli;
            List<tipo_documento> tipos = datos.ToList();
            return tipos;
        }
    }
}