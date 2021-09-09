using System;

namespace RecursividadNombre
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escriba una palabra: ");
            string palabra = Console.ReadLine();
            Console.WriteLine("Su palabra invertida es: ");
            Console.WriteLine(Invertir(palabra));
        }
        public static string Invertir(string palabra)
        {
            if(palabra.Length<= 1)
            {
                return palabra;
            }
            //la primera letra del array
            char primeraLetra = palabra[0];
            //substring--> empieza por la posicion especificada y acaba cuando termina la string.
            string total = palabra.Substring(1);
            return Invertir(total) + primeraLetra;
        }
    }
       
    }
        

