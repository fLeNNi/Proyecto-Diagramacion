int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;

Console.WriteLine("Ingrese el primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
num3 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el cuarto numero");
num4 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el quinto numero");
num5 = int.Parse(Console.ReadLine());

if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
{
    Console.WriteLine($"El menor es: {num1}");
}
else if (num2 < num1 && num2 < num3 && num2 < num4 && num2 < num5)
{
    Console.WriteLine($"El menor es: {num2}");
}
else if (num4 < num1 && num4 < num3 && num4 < num2 && num4 < num5)
{
    Console.WriteLine($"El menor es: {num4}");
}
else if (num3 < num1 && num3 < num2 && num3 < num3 && num3 < num5)
{
    Console.WriteLine($"El menor es: {num3}");
}
else
{
    Console.WriteLine($"El menor es: {num5}");
}