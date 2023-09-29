using Repasoxdxdxdxd.clases;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Repasoxdxdxdxd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Recursividad recursivo = new Recursividad();
            //Console.Write("Introduce un número entero positivo: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int resta = numero;
            //for (int x = numero-1; x >= 0; x--) 
            //{
            //    resta -= x; 

            //}
            //Console.WriteLine("La resta recursiva da un total de: ");
            //Console.WriteLine(resta);

            //Console.WriteLine("Ingresa un numero para la resta recursiva");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int resultado = recursivo.RestaRecursiva(numero);
            //Console.WriteLine(resultado);
            //Console.WriteLine("Ingresa un numero para saber si es palindromo");
            //int numero = Convert.ToInt32(Console.ReadLine()); // Este es el número que deseas verificar
            //int copia = numero; // Hacemos una copia del número

            //int invertido = 0; // Aquí almacenaremos el número invertido

            //while (copia > 0)
            //{
            //    int digito = copia % 10; // Obtenemos el último dígito del número
            //    invertido = invertido * 10 + digito; // Agregamos el dígito al número invertido
            //    copia = copia / 10; // Quitamos el último dígito de la copia
            //}

            //// Ahora, invertido contiene el número invertido

            //if (invertido == numero)
            //{
            //    Console.WriteLine("Es un palíndromo");
            //}
            //else
            //{
            //    Console.WriteLine("No es un palíndromo");
            //}


            //Console.WriteLine("Ingresa un numero pa ver si es palindromo o no putito");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //int copia = numero;
            //int palindromo = 0;

            //while (copia != 0)
            //{
            //    int digito = copia % 10;
            //    palindromo = palindromo * 10 + digito;
            //    copia = copia / 10;
            //}

            //if (numero == palindromo)
            //{
            //    Console.WriteLine("Si es palindromo putito");
            //}
            //else
            //{
            //    Console.WriteLine("Sorry no es");
            //}


            Console.WriteLine("Ingresa un numero pa ver si es palindromo o no putito");
            int numero = Convert.ToInt32(Console.ReadLine());
            int palindromo = 0;
            for (int copia = numero; copia != 0; copia = copia / 10)
            {
                int digito = copia % 10;
                palindromo = palindromo * 10 + digito;


            }

            if (numero == palindromo)
            {
                Console.WriteLine("Si es palindromo a la verga la verga");
            }
            else
            {
                Console.WriteLine("No es a la verga, ignoren al eloy a la verga");
            }

        }
    }
}