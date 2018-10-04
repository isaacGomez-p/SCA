using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Asignacion
/// </summary>
public class Asignacion
{
    public Asignacion()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private int idAsignacion;
    private string referencia;
    private int cantidad;
    private double talla;
    private int sede;

    public string Referencia { get => referencia; set => referencia = value; }
    public int Cantidad { get => cantidad; set => cantidad = value; }
    public double Talla { get => talla; set => talla = value; }
    public int Sede { get => sede; set => sede = value; }
    public int IdAsignacion { get => idAsignacion; set => idAsignacion = value; }
}