using System;

namespace Proyecto_Diagramacion_U1_EJ1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.	Leer 4 números enteros, calcular la suma e informar el resultado.


            int numero1 = 0;
            int numero2 = 0, numero3 = 0, numero4 = 0;
            int resultado = 0;

            //utilizo el metodo Console.WriteLine para visualizar datos y generar luego de la visualizacion un retorno de carro

            Console.WriteLine("Ingrese el primer numero a sumar");
            numero1 = int.Parse(Console.ReadLine() );
            Console.WriteLine("Ingrese el segundo numero a sumar");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero a sumar");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto numero a sumar");
            numero4 = int.Parse(Console.ReadLine());

            resultado = numero1 + numero2 + numero3 + numero4;
            Console.WriteLine("El resultado de la suma de los cuatro numeros es:");
            Console.WriteLine(resultado);






        }
    }
}