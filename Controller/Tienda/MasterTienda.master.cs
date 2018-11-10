using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_MasterTienda : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label_Usuario.Text = Session["user_id"].ToString();
        DAOUsuario dao = new DAOUsuario();
        DataTable d3 = new DataTable();

        string cedula = Session["user_id"].ToString();
        d3=dao.ObtenerDatos(cedula);

        Session["nombre"] = d3.Rows[0]["nombre"].ToString();
        Session["sede"] = d3.Rows[0]["sede"].ToString();
        L_Nombre.Text = Session["nombre"].ToString();
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
}
