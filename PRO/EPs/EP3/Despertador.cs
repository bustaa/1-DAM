using System;

namespace EP3
{
    class Despertador
    {
        private int horaHora;
        private int minutosHora;
        private int horaAlarma;
        private int minutosAlarma;
        private bool alarma;

        public Despertador(int hora, int minutos, int horaAlarma, int minutosAlarma, bool alarma)
        {
            horaHora = hora;
            minutosHora = minutos;
            this.horaAlarma = horaAlarma;
            this.minutosAlarma = minutosAlarma;
            this.alarma = alarma;
        }

        public int Hora{ set => horaHora = value; }

        public int Minuto { set => minutosHora = value; }


        public int HoraAlarma { set => horaAlarma = value; }

        public int MinutoAlarma { set => minutosAlarma = value; }

        public void ActivarAlarma(bool activar)
        {
            if (activar) alarma = true;
            else alarma = false;
        }

        public bool EstaAlarmaActiva()
        {
            return alarma;
        }

        public void MostrarAlarma()
        {
            Console.WriteLine($"La alarma está activa para las {horaAlarma}:{minutosAlarma}");
        }

        public void MostrarHora()
        {
            Console.WriteLine($"Hora actual: {horaHora}:{minutosHora}");
        }
    }
}
