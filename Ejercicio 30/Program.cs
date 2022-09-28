int a = 0, b = 0, suma = 0;

Console.WriteLine("Ingrese el primer valor");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo valor");
b = int.Parse(Console.ReadLine());

while (true)
{
    suma = suma + a;
    b--;
    if (b == 0) { break; }
}
Console.WriteLine($"El producto es: {suma}");


