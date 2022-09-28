float num1 = 0, num2 = 0;

Console.WriteLine("Ingrese el primer numero");
num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = float.Parse(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Orden ascendente: {num2}, {num1}");
}
else
{
    Console.WriteLine($"Orden ascendente: {num1}, {num2}");
}
