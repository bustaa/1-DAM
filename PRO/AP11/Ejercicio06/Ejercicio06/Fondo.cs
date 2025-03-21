using System;

namespace Ejercicio06;

class Fondo
{
    private int numero;
    private double cantidadMes;

    public Fondo(int numero, double cantidadMes)
    {
        this.numero = numero;
        this.cantidadMes = cantidadMes;
    }

    public int Numero
    {
        get => numero;
    }

    public double CantidadMes
    {
        get => cantidadMes;
    }

    public void VerDatos()
    {
        Console.WriteLine($"Numero: {numero}");
        Console.WriteLine($"Cantidad al mes: {cantidadMes}");
    }
}