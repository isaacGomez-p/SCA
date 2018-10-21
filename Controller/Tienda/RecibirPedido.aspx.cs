using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_RecibirPedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["paginar"] = null;
            Session["paginar2"] = null;
        }
    }

    String idAsig
    {
        get { return Session["idAsig"] as String; }
        set { Session["idAsig"] = value; }
    }

    DataTable compara
    {
        get { return Session["paginar"] as DataTable; }
        set { Session["paginar"] = value; }
    }
    DataTable compara2
    {
        get { return Session["paginar2"] as DataTable; }
        set { Session["paginar2"] = value; }
    }

    protected void B_ActualizarAsignaciones_Click(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        DataTable datosAsignacion = new DataTable();
        Session["paginar"] = null;
        datosAsignacion = dAO.verAsignacion("Faca");
        if (datosAsignacion.Rows.Count == 0)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos pendientes para asignar al inventario.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {


            GV_Asignacion.DataSource = datosAsignacion;
            GV_Asignacion.DataBind();
            if (Session["paginar"] == null)
            {
                compara = new DataTable();
                compara = datosAsignacion;
                Session["paginar"] = compara;
            }
        }
    }



    protected void GV_Asignacion_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Select"))
        {
            DAOUsuario dAO = new DAOUsuario();
            Session["paginar2"] = null;
            Session["idAsig"] = null;
            DataTable datosAsignaciones = dAO.verAsignaciones(Convert.ToInt32(e.CommandArgument));
            GV_Asignaciones.DataSource = datosAsignaciones;
            GV_Asignaciones.DataBind();
            if (Session["paginar2"] == null)
            {
                compara2 = new DataTable();
                compara2 = datosAsignaciones;
                Session["paginar2"] = compara2;
            }
            if(Session["idAsig"] == null)
            {
                idAsig = Convert.ToString(e.CommandArgument);
                Session["idAsig"] = idAsig;
            }



        }
    }

    protected void GV_Asignacion_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GV_Asignacion.PageIndex = e.NewPageIndex;
        GV_Asignacion.DataSource = (DataTable) Session["paginar"];
        GV_Asignacion.DataBind();
    }

    protected void GV_Asignaciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GV_Asignaciones.PageIndex = e.NewPageIndex;
        GV_Asignaciones.DataSource = (DataTable)Session["paginar2"];
        GV_Asignaciones.DataBind();
    }

    protected void B_AgregarInventario_Click(object sender, EventArgs e)
    {
        DAOUsuario da = new DAOUsuario();
        int idAsignacion = Convert.ToInt32(Session["idAsig"]);

        da.actualizarAsignacion(true, idAsignacion);
        if (GV_Asignaciones.Rows.Count == 0)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos pendientes para asignar al inventario.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {


            foreach (GridViewRow fila in GV_Asignaciones.Rows)
            {
                Inventario inventario = new Inventario();
                inventario.Referencia = Convert.ToString(((Label)fila.Cells[1].FindControl("L_Referencia")).Text);
                inventario.Talla = Convert.ToDouble(((Label)fila.Cells[2].FindControl("L_Talla")).Text);
                inventario.Cantidad = Convert.ToInt32(((Label)fila.Cells[3].FindControl("L_Cantidad")).Text);
                if (inventario.Referencia != null)
                {
                    inventario.Sede = "Faca";

                    da.crearInventario(inventario);
#pragma warning disable CS0618 // Type or member is obsolete
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Se han añadido los productos al inventario.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                }
                else
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos pendientes para agregar al inventario de la sede.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                }

            }

            GV_Asignacion.DataBind();
            GV_Asignaciones.DataBind();


        }
    }
}