/*
-Authors:
    María Camila Morales Galeano,
    María Paula Leiva Agudelo,
    Jhon Fredy Marciales Morales,
    Juan david Ropero Prieto.
-Working day: Morning
-Group:239-2ª
*/

using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine();
string menu = @"                 # # # # # # # # # # # - M E N Ú - # # # # # # # # # # # 
                |  1. ToString     11. LastIndexOf     21.TrimEnd       | 
                |  2. DateTime     12. PadLeft         22.Capacity      |  
                |  3. Contcat      13. PadRight        23.Chart         | 
                |  4. Compare      14. Remove          24.Length        | 
                |  5. Equals       15. Replace         25.Append        |  
                |  6. Contains     16. Split           26.WriteLine     |  
                |  7. Substring    17. ToLower         27.AppendFormat  |  
                |  8. EndsWith     18.ToUppert         28.ToString      |
                |  9. CopyTo       19.Trim                              |
                |  10. Insert      20.TrimStart                         |
                # # # # # # # # # # # # # # # # # # # # # # # # # # # # #";                      
  
            Console.WriteLine(menu);

            Console.Write("\nIngrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    metodoToString();
                    break;
                case 2:
                    metodoDateTime();
                    break;
                case 3:
                    metodoConcat();
                    break;
                case 4:
                    metodoCompare();
                    break;
                case 5:
                    metodoEquals();
                    break;
                case 6:
                    metodoContains();
                    break;
                case 7:
                    metodoSubstring();
                    break;
               case 8:
                    MetodoEndsWith();
                    break;
                case 9:
                    MetodoCopyto();
                    break;
                case 10:
                    MetodoInsert();
                    break;
                case 11:
                    MetodoLastIndexOf();
                    break;
                case 12:
                    MetodoPadLeft();
                    break;
                case 13:
                    MetodoPadRight();
                    break;
                case 14:
                    MetodoRemove();
                    break;
                case 15:
                    metodoReplace();
                    break;
                case 16:
                    metodoSplit();
                    break;
                case 17:
                    metodoToLower();
                    break;
                case 18:
                    metodoToUppert();
                    break;
                case 19:
                    metodoTrim();
                    break;
                case 20:
                    metodoTrimStart();
                    break;
                case 21:
                    metodoTrimEnd();
                    break;
                case 22:
                    propiedadCapacity();
                    break;
                case 23:
                    propiedadChart();
                    break;
                case 24:
                    propiedadLength();
                    break;
                case 25:
                    metodoAppend();
                    break;
                case 26:
                    metodoAppendLine();
                    break;
                case 27:
                    metodoAppendFormat();
                    break;
                case 28:
                    metodoToStringB();
                    break;
                default:
                    Console.WriteLine("Opción invalida...");
                    break;
            }


        }
        static void metodoToString()
        {
            String str1 = "123";
            String str2 = "abc";

            Console.WriteLine("Original str1: {0}", str1);
            Console.WriteLine("Original str2: {0}", str2);
            Console.WriteLine("str1 same as str2?: {0}", Object.ReferenceEquals(str1, str2));

            str2 = str1.ToString();
            Console.WriteLine();
            Console.WriteLine("New str2:      {0}", str2);
            Console.WriteLine("str1 same as str2?: {0}", Object.ReferenceEquals(str1, str2));
        }
        static void metodoDateTime()
        {
            var dat1 = new DateTime();
            Console.WriteLine(dat1.ToString(System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine(dat1.Equals(DateTime.MinValue));

        }
        static void metodoConcat()
        {
            String s1 = "We went to a bookstore, ";
            String s2 = "a movie, ";
            String s3 = "and a restaurant.";

            var s = String.Concat(s1, s2, s3);
            Console.WriteLine(s);

        }
        static void metodoCompare()
        {
            String str1 = "machine";
            String str2 = "device";
            String str;
            int result;

            Console.WriteLine();
            Console.WriteLine("str1 = '{0}', str2 = '{1}'", str1, str2);
            result = String.Compare(str1, 2, str2, 0, 2);
            str = ((result < 0) ? "less than" : ((result > 0) ? "greater than" : "equal to"));
            Console.Write("Substring '{0}' in '{1}' is ", str1.Substring(2, 2), str1);
            Console.Write("{0} ", str);
            Console.WriteLine("substring '{0}' in '{1}'.", str2.Substring(0, 2), str2);

        }
        static void metodoEquals()
        {
            byte value1 = 12;
            int value2 = 12;
            object object1 = value1;
            object object2 = value2;
            Console.WriteLine("{0} ({1}) = {2} ({3}): {4}",
                  object1, object1.GetType().Name,
                  object2, object2.GetType().Name,
                  object1.Equals(object2));

        }
        static void metodoContains()
        {
            string s1 = "The quick brown fox jumps over the lazy dog";
            string s2 = "fox";
            bool b = s1.Contains(s2);
            Console.WriteLine("'{0}' is in the string '{1}': {2}", s2, s1, b);
            if (b)
            {
                int index = s1.IndexOf(s2);
                if (index >= 0)
                {
                    Console.WriteLine("'{0} begins at character position {1}", s2, index + 1);
                }
            }

        }
        public static void metodoSubstring()
        {
            String[] pairs = { "Color1=red", "Color2=green", "Color3=blue", "Title=Code Repository" };
            foreach (var pair in pairs)
            {
                int position = pair.IndexOf("=");
                if (position < 0)
                {
                    continue;
                }

                Console.WriteLine("Key: {0}, Value: '{1}'");
                pair.Substring(0, position);
                pair.Substring(position + 1);

            }

        }
        static void MetodoEndsWith()
        {
		    string saludo = "Hola Sheldon";
		        if(saludo.EndsWith("o"))
                {
			        System.Console.WriteLine("Termina con la letra o");
		        }          
                else
                {
			        System.Console.WriteLine("No termina con o");
		        }
	    }
        static void MetodoCopyto() 
        {
            string str = "Sheldon";
            Console.WriteLine("String = "+str);

            char[] gato = new char[20];

            str.CopyTo(1, gato, 0, 4);
            Console.Write(gato);
        }

        static void MetodoInsert()
        {

            String frase = "Arroz pollo";
            Console.WriteLine("frase actual: " + frase);
  
            Console.WriteLine("frase nueva: " + frase.Insert(5, " con"));
        }
        static void MetodoLastIndexOf()    
        {    
           string frase = "Hola Sheldon";  
           Console.WriteLine("frase actual: " + frase);
           int letra = frase.LastIndexOf('S');  
           Console.WriteLine("La posicion de la S esta en: " + letra);  
        }

        static void MetodoPadLeft()
        {
            string s1 = "ARROZCONPOLLO";
   
            Console.WriteLine("Cadena : " + s1);
            Console.WriteLine("Pad  5 :'{0}'", s1.PadLeft(5));
            Console.WriteLine("Pad 15 :'{0}'", s1.PadLeft(15));
   
        } 
        static void MetodoPadRight()
        {
            string s1 = "ARROZCONPOLLO";
   
            Console.WriteLine("Cadena : " + s1);
            Console.WriteLine("Pad  5 :'{0}'", s1.PadRight(5));
            Console.WriteLine("Pad 15 :'{0}'", s1.PadRight(15));
   
        } 
        static void MetodoRemove()
        {
            List <string> Estudiantes = new List<string>();
            Estudiantes.Add("Angela");
            Estudiantes.Add("Manuel");
            Estudiantes.Add("Jonathan");
            Estudiantes.Add("Jessica");
            Estudiantes.Add("Santiago");
            Console.WriteLine("Estudiantes en el año escolar:");
            foreach( string estudiante in Estudiantes)
                {
                    Console.WriteLine(estudiante);
                }
            Console.WriteLine();
            Estudiantes.Remove("Jonathan");
            Console.WriteLine("Estudiantes aprobados:");
            foreach( string estudiante in Estudiantes)
                {
                    Console.WriteLine(estudiante);
                }
        }
        static void metodoPadLeft()
        {
            string text1 = "esto es un metodo";
            Console.WriteLine(text1.PadLeft(20));
            Console.WriteLine(text1.PadLeft(5));

        }
        static void metodoPadRight()
        {
            string text2 = "esto es un metodo";
            Console.WriteLine(text2.PadRight(20));
            Console.WriteLine(text2.PadRight(5));
        }
        static void metodoRemove()
        {
            List<string> Flowers = new List<string>();
            Flowers.Add("Rose");
            Flowers.Add("Jasmine");
            Flowers.Add("Lili");
            Flowers.Add("Hibiscus");
            Flowers.Add("Daisy");
            Console.WriteLine("List Before Removal:");
            foreach (string flower in Flowers)
            {
                Console.WriteLine(flower);
            }
            Console.WriteLine();
            Flowers.Remove("Lili");
            Console.WriteLine("List After Removal:");
            foreach (string flower in Flowers)
            {
                Console.WriteLine(flower);
            }
        }
        static void metodoReplace()
        {
            String str = "1 2 3 4 5 6 7 8 9";
            Console.WriteLine("Original string: \"{0}\"", str);
            Console.WriteLine("CSV string:      \"{0}\"", str.Replace(' ', ','));
        }
        static void metodoSplit()
        {
            string ejemplo = "tamales empanadas changua";

            string[] subs = ejemplo.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
        }
        static void metodoToLower()
        {
            string cadena = "HOLA MUNDO";

            Console.WriteLine("Nuestra cadena es: " + cadena);

            Console.WriteLine("La cadena en minusculas es: {0}", cadena.ToLower());


        }
        static void metodoToUppert()
        {

            string cadena = "Hola Mundo";

            Console.WriteLine("Nuestra cadena es: " + cadena);

            Console.WriteLine("La cadena en mayusculas es: {0}", cadena.ToUpper());

        }
        static void metodoTrim()
        {
            string texto1 = "hola     ";
            Console.WriteLine(texto1.Trim());
            string texto2 = "                       hola     ";
            Console.WriteLine(texto2.Trim());
            string texto3 = "          hola";
            Console.WriteLine(texto3.Trim());

        }  
        static void metodoTrimStart(){
            string texto1="hola     ";
            Console.WriteLine(texto1.TrimStart());
            string texto2="                       hola     ";
            Console.WriteLine(texto2.TrimStart());
            string texto3="          hola";
            Console.WriteLine(texto3.TrimStart());
            
        }  
        static void metodoTrimEnd(){
            string texto1="hola     ";
            Console.WriteLine(texto1.TrimEnd());
            string texto2="                       hola     ";
            Console.WriteLine(texto2.TrimEnd());
            string texto3="          hola";
            Console.WriteLine(texto3.TrimEnd());
            
        }
        static void propiedadCapacity()
        {
            StringBuilder sb = new StringBuilder(5);
            Console.WriteLine("La capacidad actual de stringBuilder es de: " + sb.Capacity);
            Console.Write("Ingrese un texto: ");
            sb.Append(Console.ReadLine());
            Console.WriteLine("La capacidad actual de stringBuilder es de: " + sb.Capacity);
        }
        static void propiedadChart()
        {
            Console.Write("-ingrese su nombre: ");
            string texto = Console.ReadLine();
            StringBuilder sb = new StringBuilder(texto);
            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }
        }
        static void propiedadLength()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("La capacidad actual de stringBuilder es de: " + sb.Length);
            Console.Write("Ingrese un texto: ");
            sb.Append(Console.ReadLine());
            Console.WriteLine("La capacidad actual de stringBuilder es de: " + sb.Length);
        }
        static void metodoAppend()
        {
            Console.WriteLine("-ingrese un texto: ");
            string texto = Console.ReadLine();
            StringBuilder sb = new StringBuilder(texto);
            Console.WriteLine("-ingrese un texto para agregar al anterior: ");
            texto = Console.ReadLine();
            sb.Append(" " + texto);
            Console.WriteLine(sb);
        }
        static void metodoAppendLine()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("-ingrese su primer nombre: ");
            string texto = Console.ReadLine();
            sb.Append(texto);

            Console.WriteLine("-ingrese su segundo nombre: ");
            texto = Console.ReadLine();
            sb.AppendLine(" " + texto);

            Console.WriteLine("-ingrese sus apellidos: ");
            texto = Console.ReadLine();
            sb.Append(texto);

            Console.WriteLine(sb);
        }
        static void metodoAppendFormat()
        {

            int segundos, minutos, horas;
            Console.WriteLine("Ingrese la hora actual");
            Console.Write("Hora: ");
            horas = int.Parse(Console.ReadLine());
            Console.Write("Minutos: ");
            minutos = int.Parse(Console.ReadLine());
            Console.Write("Segundos: ");
            segundos = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("-> {0}:{1}:{2} ", horas, minutos, segundos);

            Console.WriteLine(sb);
        }
        static void metodoToStringB()
        {
            StringBuilder sb = new StringBuilder("ejemplo de cadenas");
            Console.WriteLine("\n--Imprimir con clase stringBuilder: ");
            Console.WriteLine(sb);
            Console.WriteLine("--Imprimir con clase String y en mayusculas: ");
            Console.WriteLine(sb.ToString().ToUpper() + "\n");
        }
    }
}
