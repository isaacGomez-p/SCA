using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Producto
/// </summary>
public class Producto
{
    public Producto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private string nombreProducto;
    private double precio;
    private int idSede;

    public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
    public double Precio { get => precio; set => precio = value; }
    public int IdSede { get => idSede; set => idSede = value; }
}