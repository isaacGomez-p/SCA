using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Administrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {

            Response.Redirect("NuevoLogin.aspx");
        }          

    }

    protected void B_Cierre_Click(object sender, EventArgs e)
    {
        Session["user_id"] = null;
        Session["nombre"] = null;

        DAOUsuario user = new DAOUsuario();
        EUsuario datos = new EUsuario();
        datos.Session = Session.SessionID;
        user.cerrarSession(datos);

        Response.Redirect("NuevoLogin.aspx");



    }

    protected void B_Consultar_Click(object sender, EventArgs e)
    {
        if(C_dia.SelectedDate.Year == 1)
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('La fecha esta vacia');window.location=\"Administrador.aspx\"</script>");
    }

    protected void GV_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GV_Usuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }

    protected void GV_Usuarios_RowEditing(object sender, GridViewEditEventArgs e)
    {

    }
}