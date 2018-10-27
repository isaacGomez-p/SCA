using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_CRUDAdmin : System.Web.UI.Page
{
    DAOUsuario dao = new DAOUsuario();
    Usuario usuario = new Usuario();
    DataTable usu = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        usu = dao.traerUsuarios();
        GV_Productos.DataSource = usu;
        GV_Productos.DataBind();

        if (!IsPostBack)
        {
            for (int i = 0; i < usu.Rows.Count; i++)
            {
                DropDownList1.Items.Add(usu.Rows[i]["cedula"].ToString());
            }
        }
    }

    protected void B_Agregar_Click(object sender, EventArgs e)
    {
        

        usuario.Cedula = int.Parse(TB_Cedula.Text);
        usuario.Nombre = TB_Nombre.Text;
        usuario.Clave = TB_Clave.Text;
        usuario.Direccion = TB_Direccion.Text;
        usuario.Telefono = int.Parse(TB_Telefono.Text);
        usuario.Sexo = TB_Sexo.Text;
        usuario.Sede = DL_Sedes.SelectedValue;
        usuario.Correo = TB_Correo.Text;
        usuario.Estado = 1;
        usuario.Session = "hola";
        usuario.RolId = int.Parse(TB_Rol.Text);
        usuario.LastModified = DateTime.Now;

        dao.CrearUsuario(usuario);

        usu = dao.traerUsuarios();
        GV_Productos.DataSource = usu;
        GV_Productos.DataBind();
        DropDownList1.Items.Add(TB_Cedula.Text);
    }

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        for(int i =0; i< usu.Rows.Count; i++)
        {
            if (DropDownList1.SelectedItem.ToString() == usu.Rows[i]["cedula"].ToString())
            {
                TB_Cedula0.Text = usu.Rows[i]["cedula"].ToString();
                TB_Nombre0.Text = usu.Rows[i]["nombre"].ToString();
                TB_Clave0.Text = usu.Rows[i]["clave"].ToString();
                TB_Direccion0.Text = usu.Rows[i]["direccion"].ToString();
                TB_Telefono0.Text = usu.Rows[i]["telefono"].ToString();
                TB_Sexo0.Text = usu.Rows[i]["sexo"].ToString();
                TB_Sede0.Text = usu.Rows[i]["sede"].ToString();
                TB_Correo0.Text = usu.Rows[i]["correo"].ToString();
                TB_Rol0.Text = usu.Rows[i]["rol_id"].ToString();
            }
        }
        
    }

    protected void B_Actualizar_Click(object sender, EventArgs e)
    {
        Usuario usuario2 = new Usuario();

        usuario2.Cedula = int.Parse(TB_Cedula0.Text);
        usuario2.Nombre = TB_Nombre0.Text;
        usuario2.Clave = TB_Clave0.Text;
        usuario2.Direccion = TB_Direccion0.Text;
        usuario2.Telefono = int.Parse(TB_Telefono0.Text);
        usuario2.Sexo = TB_Sexo0.Text;
        usuario2.Sede = TB_Sede0.Text;
        usuario2.Correo = TB_Correo0.Text;
        usuario2.Estado = 1;
        usuario2.Session = "hola";
        usuario2.RolId = int.Parse(TB_Rol0.Text);
        usuario2.LastModified = DateTime.Now;

        dao.actualizarUsuario(usuario2);

        usu = dao.traerUsuarios();
        GV_Productos.DataSource = usu;
        GV_Productos.DataBind();
        DropDownList1.Items.Add(TB_Cedula.Text);
    }

    protected void B_Eliminar_Click(object sender, EventArgs e)
    {
        Usuario usuario3 = new Usuario();
        usuario3.Cedula = int.Parse(DropDownList1.SelectedItem.ToString());
        dao.eliminarUsuario(usuario3);

        usu = dao.traerUsuarios();
        GV_Productos.DataSource = usu;
        GV_Productos.DataBind();
        DropDownList1.Items.Remove(DropDownList1.SelectedItem.ToString());

    }
}