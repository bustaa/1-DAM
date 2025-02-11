using System;

namespace UsoTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso básico de un intervalo de tiempo (TimeSpan).
            TimeSpan intervalo = new TimeSpan();
            intervalo = TimeSpan.Zero;       // Representa el valor cero.
            intervalo = TimeSpan.MinValue;  // Representa el valor mínimo de un intervalo.
            intervalo = TimeSpan.MaxValue; // Representa el valor máximo de un intervalo.

            Console.WriteLine(intervalo.ToString());
            Console.ReadKey();

            // Creamos un intervalo con una cantidad de horas, minutos y segundos.
            TimeSpan tiempo = new TimeSpan(2, 14, 36);
            Console.WriteLine($"\nDuración: {tiempo.ToString(),20}");
            Console.WriteLine($"Horas: {tiempo.Hours,10:00}");
            Console.WriteLine($"Horas: {tiempo.Minutes,10:00}");
            Console.WriteLine($"Segundos: {tiempo.Seconds,10:00}");
            Console.WriteLine($"Duración: {tiempo.TotalMinutes}");
            Console.ReadKey();

            // Podemos usarlo para crear intervalos que representan diferencias entre fechas/horas
            DateTime entrada = new DateTime(2025, 2, 5, 14, 30, 15);
            DateTime salida = new DateTime(2025, 2, 11, 11, 0, 0);
            Console.WriteLine($"\nEntrada: {entrada}");
            Console.WriteLine($"Entrada: {salida}");

            TimeSpan diferencia = salida - entrada;
            Console.WriteLine($"Diferencia: {diferencia}");
            Console.WriteLine($"Diferencia en minutos: {diferencia.TotalMinutes}");
            Console.WriteLine($"Diferencia en minutos: {diferencia.TotalSeconds}");
            Console.ReadKey();
        }
    }
}
