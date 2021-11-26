using System;

namespace IMC.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            float Peso;
            double Cuadrado, Altura, Resultado;
            Console.WriteLine("Ingrese su Peso: ");
            Peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su altura: ");
            Altura = double.Parse(Console.ReadLine());
            Cuadrado = (Math.Pow(Altura,2));

            Resultado = Peso / Cuadrado;
            //Console.WriteLine("Su peso es: "+ Resultado + "  " + "Kg/m2");
            //Console.ReadLine();

            if(Resultado <16)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Delgadez severa");
                 Console.ReadLine();
            }
            else if(Resultado <= 16.99)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Delgadez moderada");
                 Console.ReadLine();

            }
            else if(Resultado <= 18.49 || Resultado == 17)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Delgadez aceptable");
                 Console.ReadLine();

            }
            else if(Resultado <= 24.99 || Resultado == 18.5)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Peso normal");
                 Console.ReadLine();

            }
            else if(Resultado == 25 || Resultado <=29.99)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Sobrepeso");
                 Console.ReadLine();

            }
            else if(Resultado == 35 || Resultado <=39.99)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Obesidad tipo II");
                 Console.ReadLine();

            }
            else if(Resultado == 40 || Resultado <=49.99)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Obesidad tipo III o mórbida");
                 Console.ReadLine();

            }
            else if(Resultado >50)
            {
                Console.WriteLine("Su peso es: "+ Resultado + " " + "Kg/m2 y esta dentro de la Categoria: Obesidad tipo IV o extrema");
                 Console.ReadLine();

            }
        }
    }
}
