﻿using System;
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

    public void editarCantidadVenta(int cantidad)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_actualizar_cantidad_venta", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = cantidad;

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

    public void editarSaldo(int id, double saldo)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_editar_pabono", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Integer).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_saldo", NpgsqlDbType.Double).Value = saldo;



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

    public void CrearAbono(string Nombre, string Apellido, string Producto, string Vendedor, string Sede, DateTime Fecha, double abono, double saldo)
    {
        //string nombre, string apellido, string producto, string vendedor, string sede, DateTime fecha
        DataTable Venta = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_insertar_venta", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = Apellido;
            dataAdapter.SelectCommand.Parameters.Add("_productos", NpgsqlDbType.Json).Value = Producto;
            dataAdapter.SelectCommand.Parameters.Add("_vendedor", NpgsqlDbType.Text).Value = Vendedor;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = Sede;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Timestamp).Value = Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Double).Value = abono;
            dataAdapter.SelectCommand.Parameters.Add("_saldo", NpgsqlDbType.Double).Value = saldo;

            conection.Open();
            dataAdapter.Fill(Venta);
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

    public void CrearVenta(string Nombre, string Apellido, string Producto, string Vendedor, string Sede, DateTime Fecha, double precio)
    {
        //string nombre, string apellido, string producto, string vendedor, string sede, DateTime fecha
        DataTable Venta = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_insertar_venta", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = Apellido;
            dataAdapter.SelectCommand.Parameters.Add("_productos", NpgsqlDbType.Json).Value = Producto;
            dataAdapter.SelectCommand.Parameters.Add("_vendedor", NpgsqlDbType.Text).Value = Vendedor;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = Sede;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Timestamp).Value = Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Double).Value = precio;


            conection.Open();
            dataAdapter.Fill(Venta);
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

    public void CrearCliente(Cliente cliente)
    {
        DataTable Cliente = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_insertar_cliente", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = cliente.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = cliente.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = cliente.Apellido;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = cliente.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Integer).Value = cliente.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Text).Value = cliente.Sexo;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = cliente.Estado;


            conection.Open();
            dataAdapter.Fill(Cliente);
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

    public void actualizarCliente(Cliente cliente)
    {
        DataTable Cliente = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_editar_cliente", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = cliente.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = cliente.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = cliente.Apellido;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = cliente.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Integer).Value = cliente.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Text).Value = cliente.Sexo;
            
            conection.Open();
            dataAdapter.Fill(Cliente);
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

    public void eliminarCliente(int cedula)
    {
        DataTable Cliente = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_editar_eliminacion_cliente", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = cedula;


            conection.Open();
            dataAdapter.Fill(Cliente);
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

    public void eliminarUsuario(string cedula)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_editar_eliminacion", conection);
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
    }

    public void CrearUsuario(Usuario usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = usuario.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = usuario.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = usuario.Clave;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = usuario.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Integer).Value = usuario.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Text).Value = usuario.Sexo;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = usuario.Sede;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = usuario.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = usuario.Estado;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = usuario.Session;
            dataAdapter.SelectCommand.Parameters.Add("_rol_id", NpgsqlDbType.Integer).Value = usuario.RolId;
            dataAdapter.SelectCommand.Parameters.Add("_last_modified", NpgsqlDbType.Timestamp).Value = usuario.LastModified;
            
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
    }

    public void actualizarUsuario(Usuario usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_editar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = usuario.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = usuario.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = usuario.Clave;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = usuario.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Integer).Value = usuario.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Text).Value = usuario.Sexo;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = usuario.Sede;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = usuario.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Integer).Value = usuario.Estado;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = usuario.Session;
            dataAdapter.SelectCommand.Parameters.Add("_rol_id", NpgsqlDbType.Integer).Value = usuario.RolId;
            dataAdapter.SelectCommand.Parameters.Add("_last_modified", NpgsqlDbType.Timestamp).Value = usuario.LastModified;
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
        
    }

    public DataTable loggin(String cedula, String clave)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_loggin", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Integer).Value = Convert.ToInt32(cedula);
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

    public bool crearSede(Sede sede)
    {
        DataTable sedes = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        bool re = false;
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearsede", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
           
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
        if(sedes.Rows.Count > 0)
        {
            foreach(DataRow row in sedes.Rows)
            {
                re = Convert.ToBoolean(row["f_crearsede"]);
            }
        }
        return re;
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

    public void crearAsignaciones(Asignacion asignacion, int id)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearasignaciones", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            dataAdapter.SelectCommand.Parameters.Add("_referencia", NpgsqlDbType.Text).Value = asignacion.Referencia;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = asignacion.Talla;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = asignacion.Cantidad;
            dataAdapter.SelectCommand.Parameters.Add("_idasignacion", NpgsqlDbType.Integer).Value = id;


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

    public void crearAsignacion(Asignacion asignacion)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearasignacion", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = asignacion.Sede;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Text).Value = asignacion.Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Boolean).Value = asignacion.Estado;


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

    public DataTable verAsignaciones(int id)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verasignaciones", conection);
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
        return productos;

    }

    public DataTable verAsignacion(string a)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verasignacion", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = a;

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

    public void crearPedido(Pedido pedido)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearpedido", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = pedido.Sede;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Text).Value = pedido.Fecha;
            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Boolean).Value = pedido.Estado;


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

    public DataTable verPedido()
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verpedido", conection);
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

    public void eliminarPedidos(int id)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_eliminarpedidos", conection);
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

    public DataTable verUltimoId()
    {
        DataTable a = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verultimoid", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


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
        return a;

    }

    public DataTable verUltimoId2()
    {
        DataTable a = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verultimoid2", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


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
        return a;

    }

    public void crearPedidos(Asignacion asignacion, int id)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearpedidos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            dataAdapter.SelectCommand.Parameters.Add("_referencia", NpgsqlDbType.Text).Value = asignacion.Referencia;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = asignacion.Talla;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = asignacion.Cantidad;
            dataAdapter.SelectCommand.Parameters.Add("_idpedido", NpgsqlDbType.Integer).Value = id;



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

    public DataTable verPedidos(int id)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verpedidos", conection);
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
        return productos;

    }

    public DataTable actualizarPedido(bool estado, int idpedido)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_actualizarpedido", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Boolean).Value = estado;
            dataAdapter.SelectCommand.Parameters.Add("_idpedido", NpgsqlDbType.Integer).Value = idpedido;

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

    public void crearInventario(Inventario inventario)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_crearinventario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            dataAdapter.SelectCommand.Parameters.Add("_referencia", NpgsqlDbType.Text).Value = inventario.Referencia;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = inventario.Talla;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = inventario.Cantidad;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = inventario.Sede;
                       
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

    public DataTable actualizarAsignacion(bool estado, int idpedido)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_actualizarasignacion", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            dataAdapter.SelectCommand.Parameters.Add("_estado", NpgsqlDbType.Boolean).Value = estado;
            dataAdapter.SelectCommand.Parameters.Add("_idasignacion", NpgsqlDbType.Integer).Value = idpedido;

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

    public DataTable verInventario(string sede)
    {
        DataTable productos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_verinventario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = sede;

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

    public DataTable traerUsuarios()
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarios_solo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(usuario);
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
        return usuario;
    }

    public DataTable traerClientes()
    {
        DataTable cliente = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_obtener_cliente_solo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(cliente);
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
        return cliente;
    }

    public DataTable traerProductos()
    {
        DataTable producto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_obtener_productos_solo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(producto);
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
        return producto;
    }

    public DataTable traerProductoss(string sede)
    {
        DataTable producto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_obtener_productoss_solo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = sede;

            conection.Open();
            dataAdapter.Fill(producto);
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
        return producto;
    }

    public DataTable traerAbonos()
    {
        DataTable cliente = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_obtener_abonos_solo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(cliente);
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
        return cliente;
    }

    public double traerPrecio(string refe, double talla)
    {
        DataTable cliente = new DataTable();
        double pe = 0;
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_precioproducto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_referencia", NpgsqlDbType.Text).Value = refe;
            dataAdapter.SelectCommand.Parameters.Add("_talla", NpgsqlDbType.Double).Value = talla;

            conection.Open();
            dataAdapter.Fill(cliente);
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
        if(cliente.Rows.Count > 0)
        {
            foreach (DataRow ff in cliente.Rows)
            {
               pe = Convert.ToDouble(ff["f_precioproducto"]);
            }

        }
        else
        {
            pe = 0;
        }
        return pe;
            
    }

    public DataTable traerSedes()
    {
        DataTable sedes = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_obtener_sedes_solo", conection);
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

    public int Notificacion_Asignaciones()
    {
        DataTable sedes = new DataTable();
        int cantidad = 0;
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_notificarasignaciones", conection);
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
        if(sedes.Rows.Count == 0)
        {
            cantidad = 0;
        }
        else
        {
            foreach(DataRow row in sedes.Rows)
            {
                cantidad = Convert.ToInt32(row["f_notificarasignaciones"]);
            }
            
        }
        return cantidad;
    }

    public DataTable traerUsuarios2(string sede)
    {
        DataTable cliente = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarios_solos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Text).Value = sede;

            conection.Open();
            dataAdapter.Fill(cliente);
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
        return cliente;
    }

    public void agregarUsuarioNuevamente(string cedula)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_editar_reingresar", conection);
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
    }

    public void agregarClienteNuevamente(string cedula)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_editar_reingresar_cliente", conection);
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
    }

    public DataTable traerCLientes2()
    {
        DataTable cliente = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("tienda.f_obtener_clientes_solos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(cliente);
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
        return cliente;
    }
}