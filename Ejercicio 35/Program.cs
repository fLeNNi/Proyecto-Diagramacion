int num = 0, maximo = 0, veces = 0;

Console.WriteLine("Ingrese un numero");
num = int.Parse(Console.ReadLine());
maximo = num;

while (num != 0)
{
    if (num > maximo)
    {
        maximo = num;
    }
    else if(num == maximo)
    {
        veces++;
    }
    Console.WriteLine("Ingrese otro numero o {0} para finalizar");
    num = int.Parse(Console.ReadLine());
}

Console.WriteLine($"El maximo numero es {maximo}");
Console.WriteLine($"La cantidad de veces que se repitio son {veces}");

