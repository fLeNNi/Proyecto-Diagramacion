int num = 0, maximo = 0;

Console.WriteLine("Ingrese un numero");
num = int.Parse(Console.ReadLine());
maximo = num;

while(num != 0)
{
    if (num > maximo)
    {
        maximo = num;
    }
    Console.WriteLine("Ingrese otro numero o {0} para finalizar");
    num = int.Parse(Console.ReadLine());
}

Console.WriteLine($"El maximo numero es {maximo}");

