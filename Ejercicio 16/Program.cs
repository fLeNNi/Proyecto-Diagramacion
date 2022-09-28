int num1 = 0, num2 = 0, num3 = 0;

Console.WriteLine("Ingrese el primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
num3 = int.Parse(Console.ReadLine());

if(num1 < num2 && num1 < num3)
{
    Console.WriteLine($"El menor es: {num1}");
}else if(num2 < num1 && num2 < num3)
{
    Console.WriteLine($"El menor es: {num2}");
}
else
{
    Console.WriteLine($"El menor es: {num3}");
}