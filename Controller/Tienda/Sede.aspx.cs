using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Inventario_AgregarSede : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataBind();
    }
    
    protected void B_AgregarSede_Click(object sender, EventArgs e)
    {
        Sede sede = new Sede();
        DAOUsuario dAO = new DAOUsuario();
        sede.IdSede = Convert.ToInt32(DL_Ciudad.SelectedValue);
        sede.NombreSede = TB_NombreSede.Text;
        sede.Ciudad = Convert.ToString(DL_Ciudad.SelectedItem);
        sede.Direccion = TB_Direccion.Text;

        dAO.crearSede(sede);

        DL_Ciudad.SelectedIndex = 0;
        TB_NombreSede.Text = "";
        TB_Direccion.Text = "";
        GridView1.DataBind();

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Delete"))
        {
            DAOUsuario dAO = new DAOUsuario();
            int id = Convert.ToInt32(e.CommandArgument);
            dAO.eliminarSede(id);
        }
    }

    
}