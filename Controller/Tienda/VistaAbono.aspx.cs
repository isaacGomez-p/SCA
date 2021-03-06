﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using Datos;
using System.Web.UI.WebControls;

public partial class View_Tienda_VistaAbono : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DAOUsuario dAO = new DAOUsuario();
        DataTable idd = new DataTable();
        idd = dAO.verUltimoId4();
        if (idd.Rows.Count > 0)
        {
            foreach (DataRow row in idd.Rows)
            {
                if (Session["idVenta1"] == null)
                {
                    Session["idVenta1"] = Convert.ToString(row["f_verultimoid4"]);
                }
            }
        }
        else
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay ventas registradas.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }

        try
        {
            DS_Abono ds = ObtenerInforme();
            CrystalReportSource1.ReportDocument.SetDataSource(ds);
            CrystalReportViewer1.ReportSource = CrystalReportSource1;
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected DS_Abono ObtenerInforme()
    {
        DataRow fila;
        DataTable multasInformacion = new DataTable();
        DS_Abono datos = new DS_Abono();

        multasInformacion = datos.Tables["Abono"];
        DAOUsuario dao = new DAOUsuario();
        if (Session["idVenta1"] == null)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No hay id en la variable de sesion.');</script>");
#pragma warning restore CS0618 // Type or member is obsolete
        }
        else
        {
            DataTable intermedio = dao.verReporteAbonos(Convert.ToInt32(Session["idVenta1"]));
            DataTable data = dao.verDescripcionAbono(Convert.ToInt32(Session["idVenta1"]));

            for (int i = 0; i < data.Rows.Count; i++)
            {
                fila = multasInformacion.NewRow();
                if (i == 0)
                {
                    fila["nombre_c"] = intermedio.Rows[i]["nombre_c"].ToString();
                    fila["apellido_c"] = intermedio.Rows[i]["apellido_c"].ToString();
                    fila["id_cliente"] = Convert.ToInt32(intermedio.Rows[i]["id_cliente"].ToString());
                    fila["nombre_v"] = intermedio.Rows[i]["nombre_v"].ToString();
                    fila["fecha"] = DateTime.Parse(intermedio.Rows[i]["fecha"].ToString());
                    fila["valor_total"] = Convert.ToDouble(intermedio.Rows[i]["precio"].ToString());
                }
                fila["referencia"] = data.Rows[i]["ReferenciaProducto"].ToString();
                fila["talla"] = Convert.ToDouble(data.Rows[i]["Talla"].ToString());
                fila["cantidad"] = Convert.ToInt32(data.Rows[i]["Cantidad"].ToString());
                fila["valor_uni"] = Convert.ToDouble(data.Rows[i]["Precio"].ToString());
                fila["valor_uni_uni"] = Convert.ToDouble(data.Rows[i]["ValorTotal"].ToString());

                multasInformacion.Rows.Add(fila);
            }
        }
        Session["idVenta1"] = null;
        return datos;
    }
}