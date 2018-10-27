using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_MasterTienda : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label_Usuario.Text = Session["nombre"].ToString();
        L_Sede.Text = Session["sede"].ToString();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("AgregarSede.aspx");
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("CRUDProducto.aspx");
    }

    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Asignar.aspx");
    }

    protected void B_CerrarSesion_Click(object sender, EventArgs e)
    {

    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("CRUDAdmin.aspx");
    }
}
