using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Tienda_Asignar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        DataTable cantidadPendiente = new DataTable();
        cantidadPendiente = dAO.verPedido();
        L_CantidadPendientes.Text = Convert.ToString(cantidadPendiente.Rows.Count);
    }

    String compara
    {
        get { return Session["compara"] as String; }
        set { Session["compara"] = value; }
    }
    String idPed
    {
        get { return Session["idPed"] as String; }
        set { Session["idPed"] = value; }
    }

    protected void B_Asignar_Click(object sender, EventArgs e)
    {
        DAOUsuario d = new DAOUsuario();
        Asignacion asignacion = new Asignacion();
        List<Producto> productos = new List<Producto>();
        Producto producto = new Producto();
        Pedido pedido = new Pedido();
        int cont = 0;
        int cantBodega = 0;
        //id = Convert.ToInt32(DL_ReferenciaProducto.SelectedValue);
        productos = d.Productos();
        //Session["compara"] = Convert.ToString(id);

        foreach (GridViewRow fila in GV_AsignarSinPedido.Rows)
        {
            cont++;
            asignacion.Referencia = Convert.ToString(((Label)fila.Cells[0].FindControl("L_Referencia")).Text);
            asignacion.Talla = Convert.ToDouble(((Label)fila.Cells[1].FindControl("L_Talla")).Text);

            if (((TextBox)fila.Cells[2].FindControl("TB_Cantidad")).Text == "")
            {
                asignacion.Cantidad = 0;
            }
            else
            {
                asignacion.Cantidad = Convert.ToInt32(((TextBox)fila.Cells[2].FindControl("TB_Cantidad")).Text);
            }



            if (asignacion.Cantidad > 0)
            {


                DataTable r = d.validarAsignacion(asignacion.Referencia, asignacion.Talla);
                if (r.Rows.Count == 1)
                {
                    foreach (DataRow row in r.Rows)
                    {
                        cantBodega = Convert.ToInt32(row["cantidad"]);
                        producto.Entregado = Convert.ToInt32(row["entregado"]);
                        producto.Idproducto = Convert.ToInt32(row["idproducto"]);
                        cantBodega = cantBodega - producto.Entregado;
                    }
                    if (asignacion.Cantidad < cantBodega)
                    {

                        Response.Write("esto da" + (cantBodega - asignacion.Cantidad));
                        if ((cantBodega - asignacion.Cantidad) >= 5)
                        {
                            DateTime fechaHoy = DateTime.Now;
                            asignacion.Fecha = fechaHoy.ToString("d");
                            asignacion.Estado = false;
                            //aqui agrega la sede
                            asignacion.Sede = "Faca";
                            if (cont == 1)
                            {
                                d.crearAsignacion(asignacion);
                            }

                            DataTable id = new DataTable();
                            id = d.verUltimoId2();
                            if (id.Rows.Count > 0)
                            {
                                foreach (DataRow ff in id.Rows)
                                {
                                    pedido.Idpedido = Convert.ToInt32(ff["f_verultimoid2"]);
                                }
                                d.crearAsignaciones(asignacion, pedido.Idpedido);
                                d.editarCantidad(producto.Idproducto, (asignacion.Cantidad + producto.Entregado));
                                


#pragma warning disable CS0618 // Type or member is obsolete
                                RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Asignación completada.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                            }



                        }
                        else
                        {
#pragma warning disable CS0618 // Type or member is obsolete
                            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('En la sede principal deben quedar al menos 5 productos.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                            return;
                        }
                    }
                    else
                    {
#pragma warning disable CS0618 // Type or member is obsolete
                        RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('La cantidad de productos a asignar debe ser menor a la que esta e bodega. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete


                    }
                }
                else
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos con esta descripción en la bodega validar. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                    return;
                }
            }
            
        }
        GV_ProductosBodega.DataBind();

    }

    protected void GV_Asignaciones_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    
    protected void GV_Pedido_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
       
    protected void GV_Pedido_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("Select"))
        {
            DAOUsuario dAO = new DAOUsuario();
            DataTable detalle = new DataTable();
            detalle = dAO.verPedidos(Convert.ToInt32(e.CommandArgument));
            Session["idPed"] = Convert.ToString(e.CommandArgument);
            GV_Pedidos.DataSource = detalle;
            GV_Pedidos.DataBind();
            
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Asignacion asignacion = new Asignacion();
        DAOUsuario d = new DAOUsuario();
        Producto producto = new Producto();
        Pedido pedido = new Pedido();

        int cantBodega = 0;
        int idPedi = Convert.ToInt32(Session["idPed"]);
        int cont = 0;
        if (GV_Pedidos.Rows.Count > 0)
        {


            foreach (GridViewRow row in GV_Pedidos.Rows)
            {
                cont++;
                asignacion.Referencia = Convert.ToString(((Label)row.Cells[0].FindControl("L_Referencia")).Text);
                asignacion.Talla = Convert.ToDouble(((Label)row.Cells[1].FindControl("L_Talla")).Text);
                asignacion.Cantidad = Convert.ToInt32(((Label)row.Cells[2].FindControl("L_Cantidad")).Text);

                DataTable r = d.validarAsignacion(asignacion.Referencia, asignacion.Talla);

                if (r.Rows.Count == 1)
                {
                    foreach (DataRow ro in r.Rows)
                    {
                        cantBodega = Convert.ToInt32(ro["cantidad"]);
                        producto.Entregado = Convert.ToInt32(ro["entregado"]);
                        producto.Idproducto = Convert.ToInt32(ro["idproducto"]);
                        cantBodega = cantBodega - producto.Entregado;
                    }
                    if (asignacion.Cantidad < cantBodega)
                    {
                        Response.Write("esto da" + (cantBodega - asignacion.Cantidad));
                        if ((cantBodega - asignacion.Cantidad) >= 5)
                        {
                            DateTime fechaHoy = DateTime.Now;
                            asignacion.Fecha = fechaHoy.ToString("d");
                            asignacion.Estado = false;
                            //aqui agrega la sede
                            asignacion.Sede = "Faca";
                            if (cont == 1)
                            {
                                d.crearAsignacion(asignacion);
                            }

                            DataTable id = new DataTable();
                            id = d.verUltimoId2();
                            if (id.Rows.Count > 0)
                            {
                                foreach (DataRow ff in id.Rows)
                                {
                                    pedido.Idpedido = Convert.ToInt32(ff["f_verultimoid2"]);
                                }
                                d.crearAsignaciones(asignacion, pedido.Idpedido);
                                d.editarCantidad(producto.Idproducto, (asignacion.Cantidad + producto.Entregado));
                                d.actualizarPedido(true, idPedi);
                                

#pragma warning disable CS0618 // Type or member is obsolete
                                RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Pedido Asignado.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                            }
                        }
                        else
                        {
#pragma warning disable CS0618 // Type or member is obsolete
                            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('En la sede principal deben quedar al menos 5 productos.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                            return;
                        }
                    }
                    else
                    {
#pragma warning disable CS0618 // Type or member is obsolete
                        RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('La cantidad de productos a asignar debe ser menor a la que esta en bodega. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete


                    }
                }
                else
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay productos con esta descripción en la bodega validar. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
                    return;
                }
                
            }
            GV_Pedido.DataBind();
            GV_Pedidos.DataBind();
            GV_ProductosBodega.DataBind();
        }
        else
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Seleccione un pedido para asignar. ');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
            return;
        }
        GV_Pedido.DataBind();
        GV_Pedidos.DataBind();
        GV_ProductosBodega.DataBind();

    }




   
}