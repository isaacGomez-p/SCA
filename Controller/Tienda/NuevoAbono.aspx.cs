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

    private List<Producto> productos1
    {
        get { return Session["lista"] as List<Producto>; }
        set { Session["lista"] = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        

        cli3 = dao.traerAbonos();//Traer todos los abonos
        
    }

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        
    }

    protected void B_Seleccionarid_Click(object sender, EventArgs e)
    {
        
    }

    protected void B_SeleccionarAbono_Click(object sender, EventArgs e)
    {
       
    }

    protected void B_AgregarProducto_Click(object sender, EventArgs e)
    {
        
    }

    protected void B_Facturar_Click(object sender, EventArgs e)
    {
        

    }

    protected void B_Abono_Click(object sender, EventArgs e)
    {
        
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