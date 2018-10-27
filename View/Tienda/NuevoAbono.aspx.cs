using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_NuevoAbono : System.Web.UI.Page
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

        cli = dao.traerProductoss("Faca");
        GV_Productos.DataSource = cli;
        GV_Productos.DataBind();
        if (!IsPostBack)
        {
            for (int i = 0; i < cli.Rows.Count; i++)
            {
                D_Productos.Items.Add(cli.Rows[i]["idasignaciones"].ToString());
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

        cli3 = dao.traerAbonos();//Traer todos los abonos
        GV_Abonos.DataSource = cli3;
        GV_Abonos.DataBind();
        if (!IsPostBack)
        {
            for (int i = 0; i < cli3.Rows.Count; i++)
            {
                D_BuscarAbono.Items.Add(cli3.Rows[i]["id"].ToString());
            }
        }
    }

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < cli2.Rows.Count; i++)
        {
            if (D_Clientes.SelectedItem.ToString() == cli2.Rows[i]["cedula"].ToString())
            {
                TB_Nombre.Text = cli2.Rows[i]["nombre"].ToString();
                TB_Apellido.Text = cli2.Rows[i]["apellido"].ToString();
            }
        }
    }

    protected void B_Seleccionarid_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < cli.Rows.Count; i++)
        {
            if (D_Productos.SelectedItem.ToString() == cli.Rows[i]["idasignacion"].ToString())
            {
                TB_Refe.Text = cli.Rows[i]["referencia"].ToString();
                TB_Talla.Text = cli.Rows[i]["talla"].ToString();
                TB_Cantidad.Text = cli.Rows[i]["cantidad"].ToString();
                TB_Precio.Text = cli.Rows[i]["precio"].ToString();

            }
        }
    }

    protected void B_SeleccionarAbono_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < cli3.Rows.Count; i++)
        {
            if (D_BuscarAbono.SelectedItem.ToString() == cli3.Rows[i]["id"].ToString())
            {
                TB_ID.Text = cli3.Rows[i]["id"].ToString();
                TB_Nab.Text = cli3.Rows[i]["nombre"].ToString();
                TB_VenAbo.Text = cli3.Rows[i]["vendedor"].ToString();
                TB_Abono.Text = cli3.Rows[i]["abono"].ToString();
                TB_Saldo.Text = cli3.Rows[i]["saldo"].ToString();
            }
        }
    }

    protected void B_AgregarProducto_Click(object sender, EventArgs e)
    {
        double sal = 0;
        ProductoV producto = new ProductoV();
        producto.Referencia = TB_Refe.Text;
        producto.Talla = Convert.ToDouble(TB_Talla.Text);
        producto.Cantidad = Convert.ToInt32(TB_Cantidad.Text);
        producto.Precio = Convert.ToDouble(TB_Precio.Text);

        sal = Convert.ToDouble(TB_Precio.Text);
        sal = sal * Convert.ToInt32(TB_Cantidad.Text);
        precioFin = precioFin + sal;

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
        TB_Refe.Text = "";
        TB_Talla.Text = "";
        TB_Cantidad.Text = "";
        TB_Precio.Text = "";
        sal = 0;

        GV_Venta.DataSource = productos1;
        GV_Venta.DataBind();
    }

    protected void B_Facturar_Click(object sender, EventArgs e)
    {
        Abono abono = new Abono();

        abono.Nombre = TB_Nombre.Text;
        abono.Apellido = TB_Apellido.Text;
        abono.Producto = this.productos1;
        abono.Vendedor = "Brayangarciaxd";
        abono.Sede = "Faca";
        abono.Fecha = DateTime.Now;
        abono.Abono1 = Convert.ToDouble(TB_Precio.Text);
        abono.Saldo = precioFin - abono.Abono1;

        dao.CrearAbono(abono.Nombre, abono.Apellido, JsonConvert.SerializeObject(abono.Producto), abono.Vendedor, abono.Sede, abono.Fecha, abono.Abono1, abono.Saldo);

        TB_Nombre.Text = "";
        TB_Apellido.Text = "";
        precioFin = 0;

    }

    protected void B_Abono_Click(object sender, EventArgs e)
    {
        Abono abono2 = new Abono();
        double sal2 = 0, sal3 = 0;
        int idx;

        abono2.Abono1 = Convert.ToDouble(TB_Abono.Text);
        sal2 = Convert.ToDouble(TB_Saldo);
        sal3 = sal2 - abono2.Abono1;
        idx = Convert.ToInt32(TB_ID.Text);

        dao.editarSaldo(idx, sal3);

        TB_Nab.Text = "";
        TB_VenAbo.Text = "";
        TB_Abono.Text = "";
        TB_Saldo.Text = "";
        TB_ID.Text = "";
    }
}