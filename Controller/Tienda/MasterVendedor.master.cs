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
        Label_usuario.Text = Session["nombre"].ToString();
        Label_Sede.Text = Session["sede"].ToString();
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
}
