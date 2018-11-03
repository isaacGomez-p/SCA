using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_CRUDVendedor : System.Web.UI.Page
{
    DAOUsuario dao = new DAOUsuario();
    Usuario usuario = new Usuario();
    DataTable usu = new DataTable();
    DataTable sedess = new DataTable();

    protected void Page_Load(object sender, EventArgs e)
    {
        usu = dao.traerUsuarios();
        GV_Productos.DataSource = usu;
        GV_Productos.DataBind();
        sedess = dao.traerSedes();

        if (!IsPostBack)
        {
            for (int i = 0; i < sedess.Rows.Count; i++)
            {
                D_Sedes.Items.Add(sedess.Rows[i]["nombresede"].ToString());
            }
        }

        if (!IsPostBack)
        {
            for (int i = 0; i < sedess.Rows.Count; i++)
            {
                D_Sedes0.Items.Add(sedess.Rows[i]["nombresede"].ToString());
            }
        }

        if (!IsPostBack)
        {
            for (int i = 0; i < usu.Rows.Count; i++)
            {
                DropDownList1.Items.Add(usu.Rows[i]["cedula"].ToString());
            }
        }
        TB_Rol.Text = "2";
    }

    protected void B_Agregar_Click(object sender, EventArgs e)
    {
        bool resultadoNombre = Regex.IsMatch(TB_Nombre.Text, @"^[a-zA-Z]+$");

        if (validarLlenoAgregar() == true)
        {
            if (resultadoNombre == true)
            {
                if (validarNumeros(TB_Telefono.Text) == true)
                {
                    if (validarNumeros(TB_Cedula.Text) == true)
                    {
                        usuario.Cedula = int.Parse(TB_Cedula.Text);
                        usuario.Nombre = TB_Nombre.Text;
                        usuario.Clave = TB_Clave.Text;
                        usuario.Direccion = TB_Direccion.Text;
                        usuario.Telefono = int.Parse(TB_Telefono.Text);
                        usuario.Sexo = TB_Sexo.Text;
                        usuario.Sede = D_Sedes.SelectedValue;
                        usuario.Correo = TB_Correo.Text;
                        usuario.Estado = 1;
                        usuario.Session = "hola";
                        usuario.RolId = int.Parse(TB_Rol.Text);
                        usuario.LastModified = DateTime.Now;

                        dao.CrearUsuario(usuario);

                        TB_Cedula.Text = "";
                        TB_Nombre.Text = "";
                        TB_Clave.Text = "";
                        TB_Direccion.Text = "";
                        TB_Telefono.Text = "";
                        TB_Correo.Text = "";

                        usu = dao.traerUsuarios();
                        GV_Productos.DataSource = usu;
                        GV_Productos.DataBind();
                        DropDownList1.Items.Add(TB_Cedula.Text);
                    }
                    else
                    {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                        RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ingrese la cedula del Admin correctamente.');</script>");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                    }
                }
                else
                {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ingrese el telefono del Admin correctamente.');</script>");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                }
            }
            else
            {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ingrese el nombre del Admin correctamente.');</script>");
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

    protected void B_Seleccionar_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < usu.Rows.Count; i++)
        {
            if (DropDownList1.SelectedItem.ToString() == usu.Rows[i]["cedula"].ToString())
            {
                TB_Cedula0.Text = usu.Rows[i]["cedula"].ToString();
                TB_Nombre0.Text = usu.Rows[i]["nombre"].ToString();
                TB_Clave0.Text = usu.Rows[i]["clave"].ToString();
                TB_Direccion0.Text = usu.Rows[i]["direccion"].ToString();
                TB_Telefono0.Text = usu.Rows[i]["telefono"].ToString();
                TB_Sexo0.Text = usu.Rows[i]["sexo"].ToString();

                TB_Correo0.Text = usu.Rows[i]["correo"].ToString();
                TB_Rol0.Text = usu.Rows[i]["rol_id"].ToString();
            }
        }
    }

    protected void B_Actualizar_Click(object sender, EventArgs e)
    {
        bool resultadoNombre = Regex.IsMatch(TB_Nombre0.Text, @"^[a-zA-Z]+$");

        if (validarLlenoEditar() == true)
        {
            if (resultadoNombre == true)
            {
                if (validarNumeros(TB_Telefono0.Text) == true)
                {
                    Usuario usuario2 = new Usuario();

                    usuario2.Cedula = int.Parse(TB_Cedula0.Text);
                    usuario2.Nombre = TB_Nombre0.Text;
                    usuario2.Clave = TB_Clave0.Text;
                    usuario2.Direccion = TB_Direccion0.Text;        usuario2.Estado = 1;

                    usuario2.Telefono = int.Parse(TB_Telefono0.Text);
                    usuario2.Sexo = TB_Sexo0.Text;
                    usuario2.Sede = D_Sedes0.SelectedValue;
                    usuario2.Correo = TB_Correo0.Text;
                    usuario2.Session = "hola";
                    usuario2.RolId = int.Parse(TB_Rol0.Text);
                    usuario2.LastModified = DateTime.Now;

                    dao.actualizarUsuario(usuario2);

                    TB_Cedula0.Text = "";
                    TB_Nombre0.Text = "";
                    TB_Clave0.Text = "";
                    TB_Direccion0.Text = "";
                    TB_Telefono0.Text = "";
                    TB_Correo0.Text = "";

                    usu = dao.traerUsuarios();
                    GV_Productos.DataSource = usu;
                    GV_Productos.DataBind();
                    DropDownList1.Items.Add(TB_Cedula.Text);
                }
                else
                {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ingrese el telefono del Admin correctamente.');</script>");
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
                }
            }
            else
            {
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
                RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Ingrese el nombre del Admin correctamente.');</script>");
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

    bool validarLlenoAgregar()
    {
        if (TB_Cedula.Text == "" || TB_Nombre.Text == "" || TB_Clave.Text == "" || TB_Direccion.Text == "" || TB_Telefono.Text == "" || TB_Sexo.Text == "" || TB_Correo.Text == "")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    bool validarLlenoEditar()
    {
        if (TB_Cedula0.Text == "" || TB_Nombre0.Text == "" || TB_Clave0.Text == "" || TB_Direccion0.Text == "" || TB_Telefono0.Text == "" || TB_Sexo0.Text == "" || TB_Correo0.Text == "")
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