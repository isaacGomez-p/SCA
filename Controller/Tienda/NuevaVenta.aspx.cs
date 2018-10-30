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
    DAOUsuario dao = new DAOUsuario();
    Cliente cliente = new Cliente();
    DataTable cli = new DataTable();
    Producto producto = new Producto();
    DataTable cli2 = new DataTable();
    DataTable cli3 = new DataTable();

    double precioFin = 0;

    private List<ProductoV> productos1
    {
        get { return Session["lista"] as List<ProductoV>; }
        set { Session["lista"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        L_Vendedor.Text = Session["nombre"].ToString();
        L_Sede.Text = Session["sede"].ToString();
        L_Rol.Text = Session["rol_id"].ToString();

        cli = dao.traerProductoss(L_Sede.Text);
        GV_Productos.DataSource = cli;
        GV_Productos.DataBind();
        if (!IsPostBack)
        {
            for (int i = 0; i < cli.Rows.Count; i++)
            {
                D_IdAsig.Items.Add(cli.Rows[i]["idasignaciones"].ToString());
            }
        }
        cli2 = dao.traerClientes();
        if (!IsPostBack)
        {
            for (int i = 0; i < cli2.Rows.Count; i++)
            {
                D_Clientes.Items.Add(cli2.Rows[i]["cedula"].ToString());
            }
        }
    }

    protected void GV_Productos_SelectedIndexChanged(object sender, GridViewPageEventArgs e)
    {
        
    }

    protected void B_BuscarCliente_Click(object sender, EventArgs e)
    {
        for(int i=0; i<cli2.Rows.Count; i++)
        {
            if(D_Clientes.SelectedItem.ToString() == cli2.Rows[i]["cedula"].ToString())
            {
                TB_Nombre.Text = cli2.Rows[i]["nombre"].ToString();
                TB_Apellido.Text = cli2.Rows[i]["apellido"].ToString();
            }
        }
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        List<Producto> listProducto = new List<Producto>();
        listProducto = dao.Productos();

    }

    protected void GV_Productos_SelectedIndexChanged1(object sender, EventArgs e, GridViewPageEventArgs a)
    {
        GV_Productos.PageIndex = a.NewPageIndex;
        GV_Productos.DataSource = (DataTable)Session["paginar"];
        GV_Productos.DataBind();
    }

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < cli.Rows.Count; i++)
        {
            if (D_IdAsig.SelectedItem.ToString() == cli.Rows[i]["idasignacion"].ToString())
            {
                TB_refe.Text = cli.Rows[i]["referencia"].ToString();
                TB_Talla.Text = cli.Rows[i]["talla"].ToString();
                L_Precio.Text = cli.Rows[i]["cantidad"].ToString();
                TB_Precio.Text = cli.Rows[i]["precio"].ToString();

            }
        }
    }

    protected void B_AgregarProducto_Click(object sender, EventArgs e)
    {
        int cantidad = 0;
        if (validarLleno() == true)
        {
            if (validarNumeros(TB_Cantidad.Text) == true)
            {
                double pre = 0;
                ProductoV producto = new ProductoV();
                producto.Referencia = TB_refe.Text;
                producto.Talla = Convert.ToDouble(TB_Talla.Text);
                producto.Cantidad = Convert.ToInt32(TB_Cantidad.Text);
                producto.Precio = dao.traerPrecio(producto.Referencia, producto.Talla);
                cantidad = producto.Cantidad;
                dao.editarCantidadVenta(cantidad);

                pre = producto.Precio * producto.Cantidad;
                precioFin = precioFin + pre;

                if (Session["lista"] == null)
                {
                    productos1 = new List<ProductoV>();
                    productos1.Add(producto);
                    Session["lista"] = productos1;
                }
                else
                {
                    productos1 = (Session["lista"] as List<ProductoV>);
                    productos1.Add(producto);
                }
                TB_refe.Text = "";
                TB_Talla.Text = "";
                TB_Cantidad.Text = "";
                TB_Precio.Text = "";
                pre = 0;

                GV_Venta.DataSource = productos1;
                GV_Venta.DataBind();
            }
            else
            {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ingrese la cantidad del producto correctamente.');</script>");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
            }
        }
        else
        {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ingrese todos los datos. ');</script>");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        }

    }

    protected void B_Facturar_Click(object sender, EventArgs e)
    {
        Venta venta = new Venta();
       
        ProductoV venta1 = new ProductoV();

        venta.Nombre = TB_Nombre.Text;
        venta.Apellido = TB_Apellido.Text;
        venta.Producto = this.productos1;
        venta.Vendedor = L_Vendedor.Text;
        venta.Sede = L_Sede.Text;
        venta.Fecha = DateTime.Now;
        venta.Precio = precioFin;
        

        dao.CrearVenta(venta.Nombre, venta.Apellido, JsonConvert.SerializeObject(venta.Producto), venta.Vendedor, venta.Sede, venta.Fecha, venta.Precio);

        TB_Nombre.Text = "";
        TB_Apellido.Text = "";
        //pre1 = 0;
        precioFin = 0;
    }

    bool validarLleno()
    {
        if (TB_Cantidad.Text == "")
        {
            return false;
        }
        else
        {
            return true;
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
}