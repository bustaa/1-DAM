using System;

namespace Ejercicio06;

class ClientePreferente : Cliente
{
    private Fondo[] producto;

    public ClientePreferente(string nif, int ncuenta, double saldo, Fondo[] producto) : base(nif, ncuenta, saldo)
    {
        this.producto = producto;
    }

    public Fondo[] Producto
    {
        get => producto;
    }

    public List<int> NumeroDeFondos()
    {
        List<int> numeros = new List<int>();
        foreach (Fondo f in producto)
        {
            numeros.Add(f.Numero);
        }

        return numeros;
    }

    public List<double> CantidadEnFondo()
    {
        List<double> cantidades = new List<double>();
        foreach (Fondo f in producto)
        {
            cantidades.Add(f.CantidadMes);
        }

        return cantidades;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();
        foreach (Fondo f in producto)
        {
            f.VerDatos();
        }
    }
}