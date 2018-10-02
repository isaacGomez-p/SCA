using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_Producto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_AgregarProducto_Click(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        Producto producto = new Producto();
        producto.NombreProducto = TB_NombreProducto.Text;
        producto.Precio = Convert.ToDouble(TB_Precio.Text);
        producto.IdSede = Convert.ToInt32(DL_Sedes.SelectedValue);

        dAO.crearProducto(producto);
        GV_Productos.DataBind();
        TB_NombreProducto.Text = "";
        TB_Precio.Text = "";


    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GV_Productos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
            if (e.CommandName.Equals("Delete"))
            {
                DAOUsuario dAO = new DAOUsuario();
                int id = Convert.ToInt32(e.CommandArgument);
                dAO.eliminarProducto(id);
           }
        
    }
}