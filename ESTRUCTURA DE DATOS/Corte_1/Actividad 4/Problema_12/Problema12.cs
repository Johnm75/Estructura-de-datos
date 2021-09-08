using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace C_
{
    class Problema12
    {
        static void Main(string[] args)
        {
            int año,mes,dia;
            string hora="";
            string[] actividad = new string[24];
            Console.WriteLine("ingrese el año: ");
            año=int.Parse(System.Console.ReadLine());
            Console.WriteLine("ingrese el mes: ");
            mes=int.Parse(System.Console.ReadLine());
            Console.WriteLine("ingrese el dia: ");
            dia=int.Parse(System.Console.ReadLine());
            for (int i = 0; i < 24; i++)
            {
                if(i==0)
                {
                    hora="00:00";
                }
                else if (i==1)
                {
                    hora="01:00";
                }
                else if (i==2)
                {
                    hora="02:00";
                }
                else if (i==3)
                {
                    hora="03:00";
                }
                else if (i==4)
                {
                    hora="04:00";
                }
                else if (i==5)
                {
                    hora="05:00";
                }
                else if (i==6)
                {
                    hora="06:00";
                }
                else if (i==7)
                {
                    hora="07:00";
                }
                else if (i==8)
                {
                    hora="08:00";
                }
                else if (i==9)
                {
                    hora="09:00";
                }
                else if (i==10)
                {
                    hora="10:00";
                }
                else if (i==11)
                {
                    hora="11:00";
                }
                else if (i==12)
                {
                    hora="12:00";
                }
                else if (i==13)
                {
                    hora="13:00";
                }
                else if (i==14)
                {
                    hora="14:00";
                }
                else if (i==15)
                {
                    hora="15:00";
                }
                else if (i==16)
                {
                    hora="16:00";
                }
                else if (i==17)
                {
                    hora="17:00";
                }
                else if (i==18)
                {
                    hora="18:00";
                }
                else if (i==19)
                {
                    hora="19:00";
                }
                else if (i==20)
                {
                    hora="20:00";
                }
                else if (i==21)
                {
                    hora="21:00";
                }
                else if (i==22)
                {
                    hora="22:00";
                }
                else if (i==23)
                {
                    hora="23:00";
                }
                else if (i==24)
                {
                    hora="24:00";
                }

                Console.WriteLine("actividades para las "+hora+" horas");
                actividad[i]=Console.ReadLine();
            }
            Console.WriteLine("para el año: "+año+"  el mes: "+mes+" y el dia: "+dia+" su agenda es: ");
            for (int i = 0; i < 24; i++)
            {
                if(i==0)
                {
                    hora="00:00";
                }
                else if (i==1)
                {
                    hora="01:00";
                }
                else if (i==2)
                {
                    hora="02:00";
                }
                else if (i==3)
                {
                    hora="03:00";
                }
                else if (i==4)
                {
                    hora="04:00";
                }
                else if (i==5)
                {
                    hora="05:00";
                }
                else if (i==6)
                {
                    hora="06:00";
                }
                else if (i==7)
                {
                    hora="07:00";
                }
                else if (i==8)
                {
                    hora="08:00";
                }
                else if (i==9)
                {
                    hora="09:00";
                }
                else if (i==10)
                {
                    hora="10:00";
                }
                else if (i==11)
                {
                    hora="11:00";
                }
                else if (i==12)
                {
                    hora="12:00";
                }
                else if (i==13)
                {
                    hora="13:00";
                }
                else if (i==14)
                {
                    hora="14:00";
                }
                else if (i==15)
                {
                    hora="15:00";
                }
                else if (i==16)
                {
                    hora="16:00";
                }
                else if (i==17)
                {
                    hora="17:00";
                }
                else if (i==18)
                {
                    hora="18:00";
                }
                else if (i==19)
                {
                    hora="19:00";
                }
                else if (i==20)
                {
                    hora="20:00";
                }
                else if (i==21)
                {
                    hora="21:00";
                }
                else if (i==22)
                {
                    hora="22:00";
                }
                else if (i==23)
                {
                    hora="23:00";
                }
                else if (i==24)
                {
                    hora="24:00";
                }
                Console.WriteLine(hora+":   "+actividad[i]);
            }




            


            


            


            


            

            


            

            

            
       
            


        }
    }
}

