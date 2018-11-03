using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_NuevoLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LB_Recuperar_Click(object sender, EventArgs e)
    {
        Response.Redirect("GenerarToken.aspx");
    }

    /*protected void L_Autenticate_Authenticate(object sender, EventArgs e)
    {
        DAOUsuario guardarUsuario = new DAOUsuario();
        DataTable data = guardarUsuario.loggin(TB_Usuario.ToString(), TB_Contraseña.ToString());

        if (int.Parse(data.Rows[0]["user_id"].ToString()) > 0)
        {
            Session["nombre"] = data.Rows[0]["nombre"].ToString();
            Session["user_id"] = data.Rows[0]["user_id"].ToString();

            EUsuario datosUsuario = new EUsuario();
            MAC datosConexion = new MAC();

            /* ipAddress = HttpContext.Current.Request.UserHostAddress;
             mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

    /* datosUsuario.UserId = int.Parse(Session["user_id"].ToString());
     datosUsuario.Ip = datosConexion.ip();
     datosUsuario.Mac = datosConexion.mac();
     datosUsuario.Session = Session.SessionID;

     guardarUsuario.guardadoSession(datosUsuario);

     Response.Redirect("MenuAdmin.aspx");
 }
}*/

    protected void B_Login_Click(object sender, EventArgs e)
    {
        DAOUsuario guardarUsuario = new DAOUsuario();
        DataTable data = guardarUsuario.loggin(TB_Cedula.Text.ToString(), TB_Clave.Text.ToString());
        
        if (int.Parse(data.Rows[0]["cedula"].ToString()) > 0)
        {
            Session["clave"] = data.Rows[0]["clave"].ToString();
            Session["user_id"] = data.Rows[0]["cedula"].ToString();
            Session["nombre_rol"] = data.Rows[0]["rol_name"].ToString();
            Session["rol_id"] = data.Rows[0]["rol_id"].ToString();
            Session["nombre"] = data.Rows[0]["nombre"].ToString();
            Session["sede"] = data.Rows[0]["sede"].ToString();
            Session["rol_id"] = data.Rows[0]["rol_id"].ToString();


            EUsuario datosUsuario = new EUsuario();
            MAC datosConexion = new MAC();

            /* ipAddress = HttpContext.Current.Request.UserHostAddress;
             mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

            datosUsuario.UserId = int.Parse(Session["user_id"].ToString());
            datosUsuario.Ip = datosConexion.ip();
            datosUsuario.Mac = datosConexion.mac();
            datosUsuario.Session = Session.SessionID;
            datosUsuario.RolId = int.Parse(data.Rows[0]["rol_id"].ToString());
            Session["user"] = datosUsuario;
            guardarUsuario.guardadoSession(datosUsuario);
            if (datosUsuario.RolId == 1)
            {
                Response.Redirect("~/View/Tienda/AgregarSede.aspx");
            }

            if (datosUsuario.RolId == 2)
            {
                Response.Redirect("~/View/Tienda/CRUDVendedor.aspx");
            }

            if (datosUsuario.RolId == 3)
            {
                Response.Redirect("~/View/Tienda/CRUDCliente.aspx");
            }

        }
        else
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario no está registrado o no esta activo. Consulte con el administrador.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete

        }
    }


        protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("GenerarToken.aspx");
    }
}