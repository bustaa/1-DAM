using System;

namespace EjercicioAP13
{
    class Presupuesto
    {
        private string nombre;
        private int tipoSeguro;
        private bool aireAcondicionado;
        private bool sistemaAudio;
        private double valor;
        private double total;
        static private int seguroBasico = 500;
        static private int seguroTerceros = 750;
        static private int seguroTodoRiesgo = 1000;
        static private int incrementoAire = 100;
        static private int incrementoAudio = 120;

        public Presupuesto(string nombre, int tipoSeguro, bool aireAcondicionado, bool sistemaAudio, double valor)
        {
            this.nombre = nombre;
            this.tipoSeguro = tipoSeguro;
            this.aireAcondicionado = aireAcondicionado;
            this.sistemaAudio = sistemaAudio;
            this.valor = valor;
            total = 0;
        }
        public string CalcularSeguro() 
        {
            CalcularTotal();
            return MostrarInformacion();
        }

        private void CalcularTotal()
        {
            if (tipoSeguro == 1) total += seguroBasico;
            if (tipoSeguro == 2) total += seguroTerceros;
            if (tipoSeguro == 3) total += seguroTodoRiesgo;
            if (aireAcondicionado) total += incrementoAire;
            if (sistemaAudio) total += incrementoAudio;
        }

        private string MostrarInformacion()
        {
            string mensaje = "";
            mensaje += $"Valor del Vehículo: {valor} Euros\r\n";
            mensaje += $"Presupuesto de seguros para {nombre}\r\n";
            
            if (tipoSeguro == 1) mensaje += $"Seguro Básico: {seguroBasico} Euros\r\n";
            if (tipoSeguro == 2) mensaje += $"Seguro a Terceros: {seguroTerceros} Euros\r\n";
            if (tipoSeguro == 3) mensaje += $"Seguro a Todo Riesgo: {seguroTodoRiesgo} Euros\r\n";
            if (aireAcondicionado) mensaje += $"Seguro (Incremento -- Aire Acondicionado): {incrementoAire} Euros\r\n";
            if (sistemaAudio) mensaje += $"Seguro (Incremento -- Sistema de Audio): {incrementoAudio} Euros\r\n";

            mensaje += $"Total Seguro: {total} Euros";

            return mensaje;
        }
    }
}
