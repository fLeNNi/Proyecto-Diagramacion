int total = 0, maximo = 0, numero = 0, contador = 1;

Console.WriteLine("Escriba la cantidad total de numeros");
total = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba un numero");
numero = int.Parse(Console.ReadLine());
maximo = numero;

while (contador < total)
{
    contador++;
    Console.WriteLine("Escriba un numero");
    numero = int.Parse(Console.ReadLine());
    if (numero > maximo)
    {
        maximo = numero;
    }
}
Console.WriteLine($"El numero maximo es {maximo}");