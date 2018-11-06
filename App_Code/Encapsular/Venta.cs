﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Venta
/// </summary>
[Serializable]
public class Venta
{
    public Venta()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int idventa;
    private int idcliente;
    private int idvendedor;
    private List<Producto> producto;
    private string fecha;
    private double precio;

    public int Idventa { get => idventa; set => idventa = value; }
    public int Idcliente { get => idcliente; set => idcliente = value; }
    public int Idvendedor { get => idvendedor; set => idvendedor = value; }
    public List<Producto> Producto { get => producto; set => producto = value; }
    public string Fecha { get => fecha; set => fecha = value; }
    public double Precio { get => precio; set => precio = value; }
}