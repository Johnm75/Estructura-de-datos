using System;
//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
namespace Problema12
{
    class Program
    {
        static void Main(string[] args)
        {
            int votantes = 0;
            int cand1 = 0;
            int cand2 = 0;
            int cand3 = 0;
            int voto = 0;
           
            Console.Write("Ingrese el numero de votantes ");
            votantes = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;  i < votantes; i++)
                {
                  Console.Write("Ingrese el numero del candidato por el que desea votar (1, 2 ,3)");
                  voto = int.Parse(Console.ReadLine());

                   if (voto == 1)
                       {
                          cand1= cand1+ 1;
                       }

                   if (voto == 2)
                        {
                           cand2 = cand2+1;
                        } 
                    if (voto == 3)
                        {
                            cand3=cand3+1;
                        }
                   
                 }
                  if (cand1>cand2 && cand1>cand3)
                        {
                            Console.WriteLine(" el candidato con mas votos fue el numero 1 con un total de votos:");
                            Console.WriteLine(cand1);
                        }
                    if (cand2>cand1 && cand2>cand3)
                        {
                            Console.WriteLine(" el candidato con mas votos fue el numero 2 con untotal de votos:");
                            Console.WriteLine(cand2);
                        }
                     if (cand3>cand1 && cand3>cand2)
                        {
                            Console.WriteLine(" el candidato con mas votos fue el numero 3 con untotal de votos:");
                            Console.WriteLine(cand3);
                        }
        }
    }
}