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
        llenarGridView();

        if (!IsPostBack)
        {
            
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
        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        List<Producto> listProducto = new List<Producto>();
        listProducto = dao.Productos();

    }

    

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        
    }

   protected void B_Facturar_Click(object sender, EventArgs e)
    {
        Venta venta = new Venta();
       
        ProductoV venta1 = new ProductoV();

        venta.Nombre = TB_Nombre.Text;
        venta.Apellido = TB_Apellido.Text;
        venta.Producto = this.productos1;
        //venta.Vendedor = L_Vendedor.Text;
        //venta.Sede = L_Sede.Text;
        venta.Fecha = DateTime.Now;
        venta.Precio = precioFin;
        

        dao.CrearVenta(venta.Nombre, venta.Apellido, JsonConvert.SerializeObject(venta.Producto), venta.Vendedor, venta.Sede, venta.Fecha, venta.Precio);

        TB_Nombre.Text = "";
        TB_Apellido.Text = "";
        //pre1 = 0;
        precioFin = 0;
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
}