using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_MasterAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label_usuario.Text = Session["nombre"].ToString();
        Label_Sede.Text = Session["sede"].ToString();
        L_Rol.Text = Session["rol_id"].ToString();
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("PedirProductos.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("RecibirPedido.aspx");

    }

    protected void LinkBodega_Click(object sender, EventArgs e)
    {
        Response.Redirect("Bodega.aspx");

    }

    protected void LinkVendedor_Click(object sender, EventArgs e)
    {
        Response.Redirect("CRUDAdmin.aspx");
    }
}
