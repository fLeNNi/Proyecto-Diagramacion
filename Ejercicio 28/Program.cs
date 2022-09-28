int x = 0, suma = 0, par = 0, contador = 0, promedio = 0, i = 0;

Console.WriteLine("Defina el numero");
x = int.Parse(Console.ReadLine());

for (i = 0; i < x; i++)
{
    par = i % 2;
    if (par == 0)
    {
        suma = suma + i;
        contador++;
    }
}

if (contador > 0)
{
    promedio = suma / contador;
}

Console.WriteLine($"El promedio es: {promedio} ");