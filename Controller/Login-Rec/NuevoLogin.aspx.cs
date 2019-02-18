using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_NuevoLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LB_Recuperar_Click(object sender, EventArgs e)
    {
        Response.Redirect("GenerarToken.aspx");
    }
    protected void B_Login_Click(object sender, EventArgs e)
    {
        if (validarNumeros(TB_Cedula.Text) == true)
        {
            MAC a = new MAC();

            UUsuario user = new UUsuario();
            user.Usuario = TB_Cedula.Text.ToString();
            user.Clave = TB_Clave.Text.ToString();
            user.Ip = HttpContext.Current.Request.UserHostAddress;
            user.Mac = a.traerMac();

            DAOUsuario guardarUsuario = new DAOUsuario();
            DataTable data = guardarUsuario.loggin(user.Usuario, user.Clave);

            user = new CoreUser().autenticar(user);


            Session["clave"] = user.Clave;
            Session["user_id"] = user.Usuario;
            Session["nombre_rol"] = user.Nombre_rol;
            Session["rol_id"] = user.Rol_id;
            Session["nombre"] = user.Nombre;
            Session["sede"] = user.Sede;

            Response.Write("<script>window.alert('" + user.Mensaje + "');</script>");

            if (user.Rol_id == 1)
            {
                Response.Redirect("~/View/Tienda/AgregarSede.aspx");
            }

            if (user.Rol_id == 2)
            {
                Response.Redirect("~/View/Tienda/CRUDVendedor.aspx");
            }

            if (user.Rol_id == 3)
            {
                Response.Redirect("~/View/Tienda/CRUDCliente.aspx");
            }


            

        }
    }



        protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("GenerarToken.aspx");
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