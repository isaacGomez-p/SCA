using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Venta
/// </summary>
public class Venta
{
    public Venta()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

   
    private string nombre;
    private string apellido;
    private List<ProductoV> producto;
    private string vendedor;
    private string sede;
    private DateTime fecha;
    private double precio;

    
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public List<ProductoV> Producto { get => producto; set => producto = value; }
    public string Vendedor { get => vendedor; set => vendedor = value; }
    public string Sede { get => sede; set => sede = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public double Precio { get => precio; set => precio = value; }
}