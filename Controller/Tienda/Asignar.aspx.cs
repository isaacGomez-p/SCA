using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_Asignar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    String compara
    {
        get { return Session["compara"] as String; }
        set { Session["compara"] = value; }
    }

    protected void B_Asignar_Click(object sender, EventArgs e)
    {
        DAOUsuario d = new DAOUsuario();
        Asignacion asignacion = new Asignacion();
        List<Producto> productos = new List<Producto>();
        Producto producto = new Producto();
        int id;
        int cantBodega = 0;
        id = Convert.ToInt32(DL_ReferenciaProducto.SelectedValue);
        productos = d.Productos();
        //Session["compara"] = Convert.ToString(id);

        asignacion.Referencia = Convert.ToString(DL_ReferenciaProducto.SelectedItem);
        asignacion.Cantidad = Convert.ToInt32(TB_Cantidad.Text);
        asignacion.Talla = Convert.ToDouble(DL_Tallas.SelectedValue);
        asignacion.Sede = Convert.ToInt32(DL_Sedes.SelectedValue);

        DataTable r = d.validarAsignacion(asignacion.Referencia, asignacion.Talla);
        if (r.Rows.Count == 1)
        {
            foreach (DataRow row in r.Rows)
            {
                cantBodega = Convert.ToInt32(row["cantidad"]);
                producto.Entregado = Convert.ToInt32(row["entregado"]);
                producto.Idproducto = Convert.ToInt32(row["idproducto"]);
                cantBodega = cantBodega - producto.Entregado;
            }
            if (asignacion.Cantidad < cantBodega)
            {
                
                Response.Write("esto da" + (cantBodega - asignacion.Cantidad));
                if((cantBodega - asignacion.Cantidad) > 5)
                {
                    //if (productos.Contains<Producto>(new Producto(asignacion.Referencia, asignacion.Talla)))
                    //{
                      
                        d.crearAsignacion(asignacion);
                        d.editarCantidad(producto.Idproducto, asignacion.Cantidad);
                        GV_Asignaciones.DataBind();
                        GV_ProductosBodega.DataBind();
                        DL_ReferenciaProducto.SelectedIndex = 0;
                        TB_Cantidad.Text = "";
                        DL_Tallas.SelectedIndex = 0;
                        DL_Sedes.SelectedIndex = 0;
#pragma warning disable CS0618 // Type or member is obsolete
                        RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Asignación completada.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                    //}
                    //else
                    //{
#pragma warning disable CS0618 // Type or member is obsolete
                    //    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos con esta descripcion en la bodega. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                     //   return;
                    //}
                }
                else
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('En la sede principal deben quedar al menos 5 productos.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                    return;
                }
            }
            else
            {
#pragma warning disable CS0618 // Type or member is obsolete
                RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('La cantidad de productos a asignar debe ser menor a la que esta e bodega. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete


            }
        }
        else
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos con esta descripción en la bodega validar. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
            return;
        }



    }

    protected void GV_Asignaciones_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    protected void GV_Asignaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Delete"))
        {
            DAOUsuario dAO = new DAOUsuario();
            dAO.eliminarAsignacion(Convert.ToInt32(e.CommandArgument));
            GV_Asignaciones.DataBind();
        }
    }
}