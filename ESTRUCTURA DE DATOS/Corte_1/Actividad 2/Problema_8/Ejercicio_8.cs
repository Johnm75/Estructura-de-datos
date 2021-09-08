using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenido a conocelosdíasdelmes.com, Por favor introduzca el número de mes del cual desea conocer sus días:");
            string numeroMes=Console.ReadLine();

            switch(numeroMes)
            {
                case "1": Console.WriteLine("Haz elegido el mes número 1 del año, es decir Enero con 31 días.");break;
                case "2": Console.WriteLine("Haz elegido el mes número 2 del año, es decir Febrero con 28 días.");break;
                case "3": Console.WriteLine("Haz elegido el mes número 3 del año, es decir Marzo con 31 días.");break;
                case "4": Console.WriteLine("Haz elegido el mes número 4 del año, es decir Abril con 3 días.");break;
                case "5": Console.WriteLine("Haz elegido el mes número 5 del año, es decir Mayo con 31 días");break;
                case "6": Console.WriteLine("Haz elegido el mes número 6 del año, es decir Junio con 30 días.");break;
                case "7": Console.WriteLine("Haz elegido el mes número 7 del año, es decir Julio con 31 días.");break;
                case "8": Console.WriteLine("Haz elegido el mes número 8 del año, es decir Agosto con 31 dias.");break;
                case "9": Console.WriteLine("Haz elegido el mes número 9 del año, es decir Septiembre con 30 días.");break;
                case "10": Console.WriteLine("Haz elegido el mes número 10 del año, es decir Octubre con 31 días.");break;
                case "11": Console.WriteLine("Haz elegido el mes número 11 del año, es decir Noviembre con 30 días.");break;
                case "12": Console.WriteLine("Haz elegido el mes número 12 del año, es decir Diciembre con 31 días.");break;

                default:Console.WriteLine("Factor incorrecto, debe elegir un número entre 1 y 12");break;
                
            }
        }
    }
}
