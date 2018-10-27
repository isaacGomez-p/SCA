using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ProductoV
/// </summary>
public class ProductoV
{
    public ProductoV()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    private string referencia;
    private double talla;
    private int cantidad;
    private double precio;

    public string Referencia { get => referencia; set => referencia = value; }
    public double Talla { get => talla; set => talla = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
    public double Precio { get => precio; set => precio = value; }
}