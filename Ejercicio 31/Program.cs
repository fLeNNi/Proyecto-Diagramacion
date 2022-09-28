int dividendo = 0, divisor = 0, contador = 0;

Console.WriteLine("Ingrese el dividendo");
dividendo = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el divisor");
divisor = int.Parse(Console.ReadLine());    

while (dividendo >= divisor)
{
    dividendo = dividendo - divisor;
    contador++;
}
Console.WriteLine($"La division es igual a: {contador}");   