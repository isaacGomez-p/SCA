using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_MenuAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();
        if (Session["user"] == null)
            Response.Redirect("Loggin.aspx");
        else
        {
            EUsuario user = (EUsuario)Session["user"];
            string url;
            if (user.RolId != 1)
            {
                switch (user.RolId)
                {
                    case 1:
                        url = "MenuAdmin.aspx";
                        break;
                    case 2:
                        url = "MenuOperario.aspx";
                        break;
                    default:
                        url = "Loggin.aspx";
                        break;
                }
                Response.Redirect(url);
            }

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

        Response.Redirect("Loggin.aspx");



    }
}