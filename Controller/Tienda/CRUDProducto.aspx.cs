    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_CRUDProducto : System.Web.UI.Page
{
    String compara
    {
        get { return Session["compara"] as String ; }
        set { Session["compara"] = value;  }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_AgregarProducto_Click(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        Producto producto = new Producto();
        Producto producto2 = new Producto();
        producto.ReferenciaProducto = TB_ReferenciaProducto.Text;
        producto.Cantidad = Convert.ToInt64(TB_Cantidad.Text);
        producto.Precio = Convert.ToDouble(TB_Precio.Text);
        producto.Talla = Convert.ToDouble(DL_Tallas.SelectedValue);

        producto2.ReferenciaProducto = TB_ReferenciaProducto.Text;
        producto2.Precio = Convert.ToDouble(TB_Precio.Text);
        producto2.Talla = Convert.ToDouble(DL_Tallas.SelectedValue);
        List<string> referencias = dAO.ReferenciasProducto();
        List<Producto> referencias2 = new List<Producto>();
        referencias2 = dAO.pruebaaa();

        if (referencias2.Contains(producto2))
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Este producto ya esta registrado. Si desea añadir mas elementos de este producto, dirijase a la seccion de actualizar un producto.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {
            //-------------------VALIDACIONES AQUI ANTES DE ENVIARLO------------------------//
            //if (referencias.Contains(producto.ReferenciaProducto))
            //{
                dAO.crearProducto(producto);
                DL_ReferenciaProducto.DataBind();
                GV_Productos.DataBind();
                TB_ReferenciaProducto.Text = "";
                TB_Precio.Text = "";
                TB_Cantidad.Text = "";
                DL_Tallas.SelectedIndex = 0;
#pragma warning disable CS0618 // Type or member is obsolete
                RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Producto registrado exitosamente.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete

            //}

        }
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

    protected void B_SeleccionarProducto_Click(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        Producto producto = new Producto();
        int refe = Convert.ToInt32(DL_ReferenciaProducto.SelectedValue);
        DataTable productos = dAO.verProductosEditar(refe);
        if(productos != null) { 
        foreach(DataRow row in productos.Rows)
        {
            producto.ReferenciaProducto = Convert.ToString(row["referenciaproducto"]);
            producto.Cantidad = Convert.ToInt64(row["cantidad"]);
            producto.Talla = Convert.ToDouble(row["talla"]);
            producto.Precio = Convert.ToDouble(row["precio"]);

        }
        }
        Session["compara"] = Convert.ToString(producto.Cantidad);
        TB_EditarReferencia.Text = producto.ReferenciaProducto;
        TB_EditarCantidad.Text = Convert.ToString(producto.Cantidad);
        TB_EditarPrecio.Text = Convert.ToString(producto.Precio);
        DL_EditarTallas.SelectedValue = Convert.ToString(producto.Talla);
        B_EditarProducto.Enabled = true;
        B_Cancelar.Enabled = true;

    }


    protected void B_EditarProducto_Click(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        Producto producto = new Producto();
        string comp;
        producto.Idproducto = Convert.ToInt32(DL_ReferenciaProducto.SelectedValue);
        producto.ReferenciaProducto = TB_EditarReferencia.Text;
        producto.Cantidad = Convert.ToInt64(TB_EditarCantidad.Text);
        producto.Precio = Convert.ToDouble(TB_EditarPrecio.Text);
        producto.Talla = Convert.ToDouble(DL_EditarTallas.SelectedValue);
        //VALIDACIONES //
        comp = Convert.ToString(Session["compara"]);
        if (Convert.ToInt32(producto.Cantidad) < Convert.ToInt32(comp))
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El numero de elementos de esta referencia debe ser mayor o igual a los ya existente.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {
            dAO.editarProducto(producto);
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Producto editado exitosamente.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
            DL_ReferenciaProducto.DataBind();
            GV_Productos.DataBind();
            TB_EditarReferencia.Text = "";
            TB_EditarCantidad.Text = "";
            TB_EditarPrecio.Text = "";
            DL_EditarTallas.SelectedIndex = 0;
            B_EditarProducto.Enabled = false;
            B_Cancelar.Enabled = false;
            Session["compara"] = null;
        }
    }

    protected void B_Cancelar_Click(object sender, EventArgs e)
    {
        TB_EditarReferencia.Text = "";
        TB_EditarReferencia.Text = "";
        TB_EditarPrecio.Text = "";
        DL_EditarTallas.SelectedIndex = 0;
        B_EditarProducto.Enabled = false;
        B_Cancelar.Enabled = false;
    }

    protected void DL_ReferenciaProducto_SelectedIndexChanged(object sender, EventArgs e)
    {
        B_EditarProducto.Enabled = false;
        B_Cancelar.Enabled = false;
    }
}