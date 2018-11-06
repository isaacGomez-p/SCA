using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Producto
/// </summary>
public class Producto: IEquatable<Producto>
{
    public Producto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public Producto(string _ref, double _talla)
    {
        this.ReferenciaProducto = _ref;
        
        this.Talla = _talla;
    }
    private int idproducto;
    private string referenciaProducto;
    private long cantidad;
    private double talla;
    private double precio;
    private double valorTotal;
    private int entregado;


    public string ReferenciaProducto { get => referenciaProducto; set => referenciaProducto = value; }
    public long Cantidad { get => cantidad; set => cantidad = value; }
    public double Talla { get => talla; set => talla = value; }
    public double Precio { get => precio; set => precio = value; }
    public int Idproducto { get => idproducto; set => idproducto = value; }
    public int Entregado { get => entregado; set => entregado = value; }
    
    public double ValorTotal { get => valorTotal; set => valorTotal = value; }

    bool IEquatable<Producto>.Equals(Producto other)
    {
        if(this.ReferenciaProducto == other.ReferenciaProducto && this.Talla == other.Talla 
            && this.Idproducto == other.Idproducto)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}