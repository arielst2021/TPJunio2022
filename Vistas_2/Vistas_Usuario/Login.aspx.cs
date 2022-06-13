using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


namespace Vistas_2.Vistas_Usuario
{
    public partial class Login : System.Web.UI.Page
    {
        NegocioUsuario neg = new NegocioUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack==false)
            {
                

            }
            // aca recibo los datos nombre de usuario y pass
            // ir a negocio--->
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {

        }
    }
}