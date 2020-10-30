using kohaku3.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kohaku3.app
{
    public partial class crear_usuario : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                TipoDocumentoDao tipo = new TipoDocumentoDao();
                List<tipo_documento> documentos = tipo.obtenerTiposDocumentoDB();
                ListItemCollection items = new ListItemCollection();
                items.Add(new ListItem("", "" ));
                foreach (var documento in documentos)
                {
                    items.Add(new ListItem(documento.nombre, ""+documento.idtipo_documento));
                }
                ddTipoDocumento.DataSource = items;
                ddTipoDocumento.DataValueField = "Value";
                ddTipoDocumento.DataTextField = "Text";
                ddTipoDocumento.DataBind();

                RangoUsuarioDao rango = new RangoUsuarioDao();
                List<rango_usuario> rangos = rango.obtenerRangosDB();
                ListItemCollection items2 = new ListItemCollection();
                items2.Add(new ListItem("", ""));
                foreach (var ran in rangos)
                {
                    items2.Add(new ListItem(ran.nombre, "" + ran.idrango_usuario));
                }
                ddRango.DataSource = items2;
                ddRango.DataValueField = "Value";
                ddRango.DataTextField = "Text";
                ddRango.DataBind();

                TipoUsuarioDao tipoU = new TipoUsuarioDao();
                List<tipo_usuario> tiposUser = tipoU.obtenerTiposUserDB();
                ListItemCollection items3 = new ListItemCollection();
                items3.Add(new ListItem("", ""));
                foreach (var tip in tiposUser)
                {
                    items3.Add(new ListItem(tip.nombre, "" + tip.id_tipo_usuario));
                }
                ddTipoUsuario.DataSource = items3;
                ddTipoUsuario.DataValueField = "Value";
                ddTipoUsuario.DataTextField = "Text";
                ddTipoUsuario.DataBind();
            }
        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (txPassword.Text.Equals(txRepetirPasssword.Text)) { 
            usuario user = new usuario();
            user.nombre = txNombre.Text;
            user.apellido = txApellido.Text;
            user.numero_identificacion = txDocumento.Text;
            user.telefono_fijo = txTelefonoFijo.Text;
            user.telefono_movil = txTelefonoMovil.Text;
            user.direccion = txDireccion.Text;
            user.correo_electronico = txCorreo.Text;
            user.clases_restantes = 0;
            user.clave = txPassword.Text;
            user.tipo_documento_idtipo_documento = Int64.Parse(ddTipoDocumento.SelectedItem.Value);
            user.rango_usuario_idrango_usuario = Int64.Parse(ddRango.SelectedItem.Value);
            user.tipo_usuario_id_tipo_usuario = Int64.Parse(ddTipoUsuario.SelectedItem.Value);
            user.estado_usuario_idestado_usuario = 1;
            UsuarioDao usDB = new UsuarioDao();
            usDB.crearUsuarioDB(user);
            limpiarCampos();
            Response.Write("<script>alert('Cliente creado exitosamente')</script>");
            }
            else
            {
                Response.Write("<script>alert('Las contraseñas no son iguales')</script>");
            }
        }

        public void limpiarCampos()
        {
           txNombre.Text="";
             txApellido.Text = "";
             txDocumento.Text = "";
            txTelefonoFijo.Text = "";
           txTelefonoMovil.Text = "";
             txDireccion.Text = "";
            txCorreo.Text = "";
             txPassword.Text = "";
            txRepetirPasssword.Text = "";
            ddTipoDocumento.SelectedValue = "";
            ddRango.SelectedValue = "";
            ddTipoUsuario.SelectedValue = "";
        }
    }
}