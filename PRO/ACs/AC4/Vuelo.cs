using System;
using System.Collections.Generic;

namespace AC4;

class Vuelo
{
    private int codigoVuelo;
    private DateTime fechaVuelo;
    private DateTime horaVuelo;
    private string ciudadOrigen;
    private string ciudadDestino;
    private int plazasVuelo;
    private List<Pasajero> pasajeros;

    public Vuelo(int codigoVuelo, DateTime fechaVuelo, DateTime horaVuelo, string ciudadOrigen, string ciudadDestino, int plazasVuelo)
    {
        this.codigoVuelo = codigoVuelo;
        this.fechaVuelo = fechaVuelo;
        this.horaVuelo = horaVuelo;
        this.ciudadOrigen = ciudadOrigen;
        this.ciudadDestino = ciudadDestino;
        this.plazasVuelo = plazasVuelo;
        pasajeros = new List<Pasajero>();
    }
    
    public int CodigoVuelo
    {
        get => codigoVuelo;
    }
    
    public DateTime FechaVuelo
    {
        get => fechaVuelo;
    }

    public DateTime HoraVuelo
    {
        get => horaVuelo;
    }

    public string CiudadOrigen
    {
        get => ciudadOrigen;
    }

    public string CiudadDestino
    {
        get => ciudadDestino;
    }

    public int PlazasVuelo
    {
        get => plazasVuelo;
    }

    public List<Pasajero> Pasajeros
    {
        get => pasajeros;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Codigo de vuelo: {codigoVuelo}");
        Console.WriteLine($"Fecha de vuelo: {fechaVuelo.Date}");
        Console.WriteLine($"Hora de vuelo: {horaVuelo.Hour}:{horaVuelo.Minute}");
        Console.WriteLine($"Ciudad origen: {ciudadOrigen}");
        Console.WriteLine($"Ciudad destino: {ciudadDestino}");
        Console.WriteLine($"Plazas disponibles: {plazasVuelo - pasajeros.Count}");
    }
}