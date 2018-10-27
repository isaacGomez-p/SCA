using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    public Usuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    int cedula;
    string nombre;
    string clave;
    string direccion;
    int telefono;
    string sexo;
    string sede;
    string correo;
    int estado;
    string session;
    int rolId;
    DateTime lastModified;

    public int Cedula { get => cedula; set => cedula = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Clave { get => clave; set => clave = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public string Sexo { get => sexo; set => sexo = value; }
    public string Sede { get => sede; set => sede = value; }
    public string Correo { get => correo; set => correo = value; }
    public int Estado { get => estado; set => estado = value; }
    public string Session { get => session; set => session = value; }
    public int RolId { get => rolId; set => rolId = value; }
    public DateTime LastModified { get => lastModified; set => lastModified = value; }
}