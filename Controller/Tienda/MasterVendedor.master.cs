using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_MasterVendedor : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null || Session["clave"] == null || Convert.ToInt32(Session["rol_id"]) != 3)
        {
            Response.Redirect("../Login-Rec/NuevoLogin.aspx");
        }
        else
        {
            Label_usuario.Text = Session["nombre"].ToString();
            Label_Sede.Text = Session["sede"].ToString();
        }

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevaVenta.aspx");
    }

    protected void LinkBodega_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevoAbono.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("CRUDCliente.aspx");
    }

   

    void cerrarSesion()
    {
        Session["clave"] = null;
        Session["user_id"] = null;
        Session["nombre_rol"] = null;
        Session["nombre"] = null;
        Session["sede"] = null;
        Session["rol_id"] = null;
        Response.Redirect("../Login-Rec/NuevoLogin.aspx");
    }

    protected void B_CerrarSesion_Click(object sender, EventArgs e)
    {
        this.cerrarSesion();
    }
}
