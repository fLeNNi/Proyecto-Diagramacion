int dividendo = 0, divisor = 0;

Console.WriteLine("Ingrese el valor del dividendo");
dividendo = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor del divisor");
divisor = int.Parse(Console.ReadLine());

if(divisor != 0)
{
    Console.WriteLine($"El cociente de devidir {dividendo} sobre {divisor} es: {dividendo / divisor}");
}
else
{
    Console.WriteLine("No se puede dividir por cero");
}