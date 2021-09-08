/*
Create by: Maria Camila Morales Galeano, 
           Maria Paula Leiva Agudelo,
           Juan David Ropero Prieto,
           John Fredy Marciales Morales.
Group: 239-2A
Shift: day
*/

using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1,n2,n3,n4,n5,n6,año,mes,dia=0;
            List<int> Lista=new List<int>();
          
            Console.WriteLine("Ingrese el año actual: ");
            n1=int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el mes(numero) actual: ");
            n2=int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el dia actual: : ");
            n3=int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el año de la fecha que quiere (menor al actual): ");
            n4=int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el mes(en numero) de la fecha anterior: ");
            n5=int.Parse(System.Console.ReadLine());

            Console.WriteLine("Ingrese el dia de la fecha anterior: ");
            n6=int.Parse(System.Console.ReadLine());

            año=n1-n4;
            mes=n2-n5;
            if (mes<0){
                mes=mes*-1;
                año=año-1;
            }
            
            

            if(mes==1 || mes==3 || mes==5 || mes==7 ||mes==8 || mes== 10 || mes==12){
                dia=(n3-n6+31);
                if(dia<0){
                    dia=dia*-1;
                    mes=mes-1;
                }
            }
            else if(mes==2) {
                dia=(n3-n6+28);
                if(dia<0){
                    dia=dia*-1;
                    mes=mes-1;
                }

            }
            else if (mes==4 || mes==6 || mes==9 || mes==11){
                dia=(n3-n6+30);
                if(dia<0){
                    dia=dia*-1;
                    mes=mes-1;
                }
            }

            Console.WriteLine("han pasado "+año+" años, "+mes+" meses y "+dia+" dias");

            


        }
    }
}

