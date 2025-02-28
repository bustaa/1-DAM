using System;

namespace Ej02
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] nombreFunciones = new string[4];

            nombreFunciones[0] = "Funcion1";
            nombreFunciones[1] = "Funcion2";
            nombreFunciones[2] = "Funcion3";
            nombreFunciones[3] = "Funcion4";

            Double[] preciosFunciones = new double[4];

            preciosFunciones[0] = 10;
            preciosFunciones[1] = 12.4;
            preciosFunciones[2] = 34.12;
            preciosFunciones[3] = 5.6;

            Teatro teatro = new Teatro("TAC", "Catarroja", nombreFunciones, preciosFunciones);

            Console.WriteLine(teatro.DevuelveNombreFuncion(2));
            teatro.ActualizarNombreFuncion(2, "FuncionAct");
            Console.WriteLine(teatro.DevuelveNombreFuncion(2));

            teatro.MostrarInfoLetra('F');
        }
    }
}
