using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>
public class DAOUsuario
{
    public DAOUsuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //


    }

    public DataTable loggin(String cedula, String clave)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_loggin", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = cedula;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 100).Value = clave;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable guardadoSession(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_guardado_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_ip", NpgsqlDbType.Varchar, 100).Value = datos.Ip;
            dataAdapter.SelectCommand.Parameters.Add("_mac", NpgsqlDbType.Varchar, 100).Value = datos.Mac;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable actualziarContrasena(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_contrasena", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = datos.Clave;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable cerrarSession(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_cerrar_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerUsuarios(String filtro)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_filtro", NpgsqlDbType.Text).Value = filtro;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable generarToken(int cedula)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = cedula;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable almacenarToken(String token, Int32 cedula)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_almacenar_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = cedula;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerUsusarioToken(String token)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuario_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public void crearSede(Sede sede)
    {
        DataTable sedes = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearsede", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = sede.IdSede;
            dataAdapter.SelectCommand.Parameters.Add("_nombresede", NpgsqlDbType.Text).Value = sede.NombreSede;
            dataAdapter.SelectCommand.Parameters.Add("_ciudad", NpgsqlDbType.Text).Value = sede.Ciudad;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = sede.Direccion;

            conection.Open();
            dataAdapter.Fill(sedes);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    
    public DataTable verSedes()
    {
        DataTable sedes = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_versedes", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            

            conection.Open();
            dataAdapter.Fill(sedes);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return sedes;

    }

    public List<Sede> Sedes()
    {
        List <Sede> sedes= new List<Sede>();
        DataTable a = this.verSedes();
        
        foreach (DataRow r in a.Rows)
        {
            Sede sede = new Sede();
            sede.IdSede = Convert.ToInt32(r["idsede"]);
            sede.NombreSede = Convert.ToString(r["nombresede"]);
            sede.Direccion = Convert.ToString(r["direccion"]);
            sede.Ciudad = Convert.ToString(r["ciudad"]);

            sedes.Add(sede);
        }
        return sedes;
    }

    public List<Producto> Productos()
    {
        DataTable productos = verProductos();
        List<Producto> referencias = new List<Producto>();

        foreach (DataRow row in productos.Rows)
        {
            Producto producto = new Producto();
            producto.Idproducto = Convert.ToInt32(row["idproducto"]);
            producto.ReferenciaProducto = Convert.ToString(row["referenciaproducto"]);
            producto.Cantidad = Convert.ToInt64(row["cantidad"]);
            producto.Talla = Convert.ToDouble(row["talla"]);
            producto.Precio = Convert.ToDouble(row["precio"]);
            producto.Entregado = Convert.ToInt32(row["entregado"]);
            referencias.Add(producto);
        }
        return referencias;
    }

    public List<Producto> pruebaaa()
    {
        DataTable productos = verProductos();

        List<Producto> referencias = new List<Producto>();
        foreach (DataRow row in productos.Rows)
        {
            Producto producto = new Producto();
            
            producto.ReferenciaProducto = Convert.ToString(row["referenciaproducto"]);
            producto.Talla = Convert.ToDouble(row["talla"]);
            producto.Precio = Convert.ToDouble(row["precio"]);
            referencias.Add(producto);
        }
        return referencias;
    }

    public List<string> ReferenciasProducto()
    {
        DataTable productos = verProductos();
        List<string> referencias = new List<string>();
        foreach(DataRow row in productos.Rows)
        {
            string temp = Convert.ToString(row["referenciaproducto"]);
            referencias.Add(temp);
        }
        return referencias;
    }

    public void eliminarSede(int idsede)
    {
        DataTable a = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_eliminarsede", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = idsede; 

            conection.Open();
            dataAdapter.Fill(a);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void crearProducto(Producto producto)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearproducto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            dataAdapter.SelectCommand.Parameters.Add("_referenciaproducto", NpgsqlDbType.Text).Value = producto.ReferenciaProducto;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Bigint).Value = producto.Cantidad;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = producto.Talla;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Double).Value = producto.Precio;
            

            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public DataTable verProductos()
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verproductos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productos;

    }

    public DataTable verProductosEditar(int refe)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verproductoseditar", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = refe;

            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productos;

    }

    public void editarProducto(Producto producto)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_editarproducto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_idproducto", NpgsqlDbType.Integer).Value = producto.Idproducto;
            dataAdapter.SelectCommand.Parameters.Add("_referenciaproducto", NpgsqlDbType.Text).Value = producto.ReferenciaProducto;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Bigint).Value = producto.Cantidad;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = producto.Talla;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Double).Value = producto.Precio;


            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void eliminarProducto(int idproducto)
    {
        DataTable a = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_eliminarproducto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = idproducto;

            conection.Open();
            dataAdapter.Fill(a);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void crearAsignacion(Asignacion asignacion)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearasignacion", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            dataAdapter.SelectCommand.Parameters.Add("_referencia", NpgsqlDbType.Text).Value = asignacion.Referencia;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Bigint).Value = asignacion.Cantidad;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = asignacion.Talla;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Integer).Value = asignacion.Sede;


            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public DataTable verAsignaciones()
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verasignaciones", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            

            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productos;

    }

    public void eliminarAsignacion(int id)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_eliminarasignacion", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;

            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public DataTable validarAsignacion(string a, double b)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_validarasignar", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_referencia", NpgsqlDbType.Text).Value = a;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = b;

            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return productos;

    }

    public void editarCantidad(int id, int entre)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_editarcantidad", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_idproducto", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_entregado", NpgsqlDbType.Bigint).Value = entre;
            


            conection.Open();
            dataAdapter.Fill(productos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
}