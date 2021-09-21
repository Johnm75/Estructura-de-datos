//Authors:María Camila Morales Galeano,María Paula Leiva Agudelo,Jhon Fredy Marciales Morales,Juandavid Ropero Prieto.
//Working day: Morning
//Group:239-2ª
using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ESTRUCTURA_DE_DATOS
{
    class Problema8
    {
        static void Main(string[] args)
        {
            
            
            int[,] matriz = new int[5,15];
            
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    for (int c = 0; c < matriz.GetLength(1); c++)
                    {
                        if(f==0||f==4||c==14||c==0)
                        {
                            matriz[f,c]=1;

                        }
                        Console.Write($"{matriz[f,c]}");
                    }
                
                    Console.WriteLine();
                }

            }
            
        }    
    }



            


            


            


            

            


            

            

            
       
            

