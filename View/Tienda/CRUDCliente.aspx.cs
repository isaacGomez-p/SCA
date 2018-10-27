using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_CRUDCliente : System.Web.UI.Page
{
    DAOUsuario dao = new DAOUsuario();
    Cliente cliente = new Cliente();
    DataTable cli = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        cli = dao.traerClientes();
        GV_Clientes.DataSource = cli;
        GV_Clientes.DataBind();

        if (!IsPostBack)
        {
            for (int i = 0; i < cli.Rows.Count; i++)
            {
                DropDownList1.Items.Add(cli.Rows[i]["cedula"].ToString());
            }
        }
    }

    protected void B_Agregar_Click(object sender, EventArgs e)
    {
        cliente.Cedula = int.Parse(TB_Cedula.Text);
        cliente.Nombre = TB_Nombre.Text;
        cliente.Apellido = TB_Apellido.Text;
        cliente.Direccion = TB_Direccion.Text;
        cliente.Telefono = int.Parse(TB_Telefono.Text);
        cliente.Sexo = TB_Sexo.Text;

        dao.CrearCliente(cliente);

        cli = dao.traerClientes();
        GV_Clientes.DataSource = cli;
        GV_Clientes.DataBind();
        DropDownList1.Items.Add(TB_Cedula.Text);
    }

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < cli.Rows.Count; i++)
        {
            if (DropDownList1.SelectedItem.ToString() == cli.Rows[i]["cedula"].ToString())
            {
                TB_Cedula0.Text = cli.Rows[i]["cedula"].ToString();
                TB_Nombre0.Text = cli.Rows[i]["nombre"].ToString();
                TB_Apellido0.Text = cli.Rows[i]["apellido"].ToString();
                TB_Direccion0.Text = cli.Rows[i]["direccion"].ToString();
                TB_Telefono0.Text = cli.Rows[i]["telefono"].ToString();
                TB_Sexo0.Text = cli.Rows[i]["sexo"].ToString();
                
            }
        }
    }

    protected void B_Actualizar_Click(object sender, EventArgs e)
    {
        Cliente cliente2 = new Cliente();

        cliente2.Cedula = int.Parse(TB_Cedula0.Text);
        cliente2.Nombre = TB_Nombre0.Text;
        cliente2.Apellido = TB_Apellido0.Text;
        cliente2.Direccion = TB_Direccion0.Text;
        cliente2.Telefono = int.Parse(TB_Telefono0.Text);
        cliente2.Sexo = TB_Sexo0.Text;

        dao.actualizarCliente(cliente2);

        cli = dao.traerClientes();
        GV_Clientes.DataSource = cli;
        GV_Clientes.DataBind();
        DropDownList1.Items.Add(TB_Cedula.Text);
    }

    protected void B_Eliminar_Click(object sender, EventArgs e)
    {
        Cliente cliente3 = new Cliente();
        cliente3.Cedula = int.Parse(DropDownList1.SelectedItem.ToString());
        dao.eliminarCliente(cliente3);

        cli = dao.traerClientes();
        GV_Clientes.DataSource = cli;
        GV_Clientes.DataBind();
        DropDownList1.Items.Remove(DropDownList1.SelectedItem.ToString());
    }
}