using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_NuevaVenta : System.Web.UI.Page
{

    Cliente cliente = new Cliente();
    DataTable cli = new DataTable();
    Producto producto = new Producto();
    DataTable cli2 = new DataTable();
    DataTable cli3 = new DataTable();



    private List<Producto> listaVenta
    {
        get { return Session["l"] as List<Producto>; }
        set { Session["l"] = value; }
    }

    private string valorVenta
    {
        get { return Session["valorVenta"] as string; }
        set { Session["valorVenta"] = value; }
    }

    private string idCliente
    {
        get { return Session["idCliente"] as string; }
        set { Session["idCliente"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {


        if (!IsPostBack)
        {
            llenarGridView();
        }

    }

    void llenarGridView()
    {
        DAOUsuario dao = new DAOUsuario();
        DataTable gri = new DataTable();
        gri = dao.verInventario(Convert.ToString(Session["sede"]));

        GV_VentaPedido.DataSource = gri;
        GV_VentaPedido.DataBind();

    }

    protected void GV_Productos_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
    {

    }

    protected void B_BuscarCliente_Click(object sender, EventArgs e)
    {
        DAOUsuario dao = new DAOUsuario();
        DataTable cliente = new DataTable();
        cliente = dao.buscarCliente(Convert.ToInt32(TB_BuscarCliente.Text));
        if (cliente.Rows.Count > 0)
        {
            L_InfoCliente.Text = "Se ha encontrado el cliente";
            foreach (DataRow row in cliente.Rows)
            {
                TB_Nombre.Text = Convert.ToString(row["nombre"]);
                TB_Apellido.Text = Convert.ToString(row["apellido"]);
            }
            Session["idCliente"] = TB_BuscarCliente.Text;
        }
        else
        {
            L_InfoCliente.Text = "El cliente no se encuentra en la base de datos";
        }

    }


    protected void Button1_Click(object sender, EventArgs e)
    {


    }



    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        Session["l"] = null;
        DAOUsuario dAO = new DAOUsuario();
        int cont = 0;
        foreach (GridViewRow row in GV_VentaPedido.Rows)
        {
            Producto producto = new Producto();
            if (((TextBox)row.Cells[2].FindControl("TB_Cantidad")).Text == "")
            {
                producto.Cantidad = 0;
            }
            else
            {
                producto.Cantidad = Convert.ToInt64(((TextBox)row.Cells[2].FindControl("TB_Cantidad")).Text);
            }
            producto.ReferenciaProducto = Convert.ToString(((Label)row.Cells[0].FindControl("L_Referencia")).Text);
            producto.Talla = Convert.ToDouble(((Label)row.Cells[1].FindControl("L_Talla")).Text);


            if (producto.Cantidad > 0)
            {
                bool vof;
                cont++;
                vof = dAO.validarCantidad(producto, Convert.ToString(Session["sede"]));
                if (vof == false)
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('La cantidad de productos para la referencia " + producto.ReferenciaProducto + " con talla " + producto.Talla + " es inferior a la de la venta. Escriba otra cantidad');</script>");
                    return;
#pragma warning restore CS0618 // Type or member is obsolete
                }
                else
                {
                    producto.Precio = dAO.traePrecio(producto.ReferenciaProducto, producto.Talla);
                    producto.ValorTotal = producto.Precio * producto.Cantidad;
                    producto.Idproducto = cont;
                    if (Session["l"] == null)
                    {
                        listaVenta = new List<Producto>();
                        listaVenta.Add(producto);
                        Session["l"] = listaVenta;
                    }
                    else
                    {
                        listaVenta = (Session["l"] as List<Producto>);
                        if (listaVenta.Contains(producto))
                        {
#pragma warning disable CS0618 // Type or member is obsolete
                            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ya ha agregado este poducto a la venta. Elimine el producto de la venta para añadir mas cantidad.');</script>");
                            return;
#pragma warning restore CS0618 // Type or member is obsolete
                        }
                        else
                        {

                            listaVenta.Add(producto);
                            Session["l"] = listaVenta;
                        }
                    }
                }
            }
        }
        if (cont == 0)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos para añadir a la venta.');</script>");
            return;
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Se han añadido " + cont + " productos a la venta.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete


        }
        llenarVenta();
        actualizarGV_Venta();

    }

    void llenarVenta()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Entra a llenar venta.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        //Session["l"] = null;
        if (Session["l"] == null)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos para añadir a la venta.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {
            double precioTotal = 0;
            List<Producto> listaV = new List<Producto>();
            listaV = (Session["l"] as List<Producto>);
            foreach (Producto p in listaV)
            {
                precioTotal = precioTotal + p.ValorTotal;
            }
            Response.Write("El valor de esta venta es de:" + precioTotal);
            Session["valorVenta"] = Convert.ToString(precioTotal);

        }


    }

    void actualizarGV_Venta()
    {
        List<Producto> listaV = new List<Producto>();
        listaV = (Session["l"] as List<Producto>);
        GV_Venta.DataSource = listaV;
        GV_Venta.DataBind();
        if (Session["valorVenta"] != null)
        {
            //TextBox total = new TextBox();
            /*total =*/
            ((TextBox)GV_Venta.FooterRow.FindControl("TB_TotalVenta")).Text = Session["valorVenta"].ToString();
            //total.Text = Session["valorVenta"].ToString();
        }
    }

    void irAFactura()
    {
        Response.Redirect("../Tienda/VistaFactura.aspx");
    }

    protected void B_Facturar_Click(object sender, EventArgs e)
    {
        if (Session["idCliente"] == null)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Elija un cliente para la venta.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {
            if (Session["l"] != null && Session["valorVenta"] != null)
            {
                DAOUsuario dAO = new DAOUsuario();
                Venta venta = new Venta();
                DateTime fechaHoy = DateTime.Now;
                venta.Idcliente = Convert.ToInt32(Session["idCliente"]);
                venta.Idvendedor = Convert.ToInt32(Session["user_id"]);
                venta.Producto = (Session["l"] as List<Producto>);
                venta.Fecha = fechaHoy.ToString("d");
                venta.Precio = Convert.ToDouble(Session["valorVenta"]);
                venta.Sede = Convert.ToString(Session["sede"]);
                dAO.crearVenta(venta, JsonConvert.SerializeObject(venta.Producto));
                actualizarInventario();
                reiniciar();
                this.irAFactura();

            }
        }
    }

    void actualizarInventario()
    {
        List<Producto> refresh = new List<Producto>();
        DAOUsuario dAO = new DAOUsuario();

        refresh = (Session["l"] as List<Producto>);
        foreach(Producto p in refresh)
        {
            dAO.actualizarInventario(p, Convert.ToString(Session["sede"]));
        }

    }

    public bool validarNumeros(string num)
    {
        try
        {
            double x = Convert.ToDouble(num);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected void GV_Productos_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GV_VentaPedido.PageIndex = e.NewPageIndex;
        this.llenarGridView();
    }

    protected void GV_Venta_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Delete"))
        {
            List<Producto> pventa = new List<Producto>();
            pventa = (Session["l"] as List<Producto>);
            if (pventa.Count.Equals(0) != false)
            {
                foreach(Producto p in pventa)
                {
                    if(p.Idproducto == Convert.ToInt32(e.CommandArgument))
                    {
                        pventa.RemoveAt(Convert.ToInt32(e.CommandArgument) - 1);
                        Session["l"] = pventa;
                        actualizarGV_Venta();
                    }
                    else
                    {
#pragma warning disable CS0618 // Type or member is obsolete
                        RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No se que pasa.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                    }
                }
            }            
        }
    }

    protected void GV_Venta_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void GV_Venta_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }

    void reiniciar()
    {
        Session["l"] = null;
        llenarGridView();
        actualizarGV_Venta();
        TB_Nombre.Text = "";
        TB_Apellido.Text = "";
        L_InfoCliente.Text = "";

    }

    protected void B_Abono_Click(object sender, EventArgs e)
    {
        
        if (Session["idCliente"] == null)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Elija un cliente para la venta.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {
            if (Session["l"] != null && Session["valorVenta"] != null)
            {
                DAOUsuario dAO = new DAOUsuario();
                Abono venta = new Abono();
                DateTime fechaHoy = DateTime.Now;
                venta.Idcliente = Convert.ToInt32(Session["idCliente"]);
                venta.Producto = (Session["l"] as List<Producto>);
                venta.Fecha = fechaHoy.ToString("d");
                venta.Precio = Convert.ToDouble(Session["valorVenta"]);
                venta.Sede = Convert.ToString(Session["sede"]);
                dAO.crearAbono(venta, JsonConvert.SerializeObject(venta.Producto));
                actualizarInventario();
                reiniciar();

            }
        }
    }
}