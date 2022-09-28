/* 29.Se leen 300 datos que representan el peso y la edad  de los niños atendidos en un hospital, se pide informar el peso promedio según el siguiente rango de edades:
•	De 0 a 1 año inclusive  / De 1 año a 3 inclusive / De 3 años a 5 inclusive

Las edades de los niños atendidos en el hospital van desde los 0 a los 14 años.
Informar la cantidad total de niños que no fueron contabilizados en el rango de edades.
Informar cuál fue el peso mínimo de todos los niños
Informar cual fue el peso máximo de todos los niños*/

int peso = 0, edad = 0, promedio1 = 0, promedio2 = 0, promedio3 = 0, maximoPeso = 0, minimoPeso = 0, contador0 = 0, contador1 = 0, contador2 = 0, contador3 = 0;

Console.WriteLine("Ingrese el peso del nino");
peso = int.Parse(Console.ReadLine());
maximoPeso = peso;
minimoPeso= peso;
Console.WriteLine("Ingrese la edad del nino");
edad = int.Parse(Console.ReadLine());

while (edad >= 0 && edad <= 14)
{
    if (peso > maximoPeso)
    {
        maximoPeso = peso;
    }
    if(peso < minimoPeso)
    {
        minimoPeso = peso;
    }
    if(edad > 5)
    {
        contador0++;
    }
    if(edad >= 0 && edad <= 1)
    {
        contador1++;
        promedio1 += peso;
    }
    if (edad > 1 && edad <= 3)
    {
        contador2++;
        promedio2 += peso;
    }
    if (edad > 3 && edad <= 5)
    {
        contador3++;
        promedio3 += peso;
    }
    Console.WriteLine("Ingrese el peso del nino");
    peso = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la edad del nino");
    edad = int.Parse(Console.ReadLine());
}
if (contador1 > 0)
{
    promedio1 = promedio1 / contador1;
}
if (contador2 > 0)
{
    promedio2 = promedio2 / contador2;
}
if (contador3 > 0)
{
    promedio3 = promedio3 / contador3;
}

Console.WriteLine($"El maximo peso es {maximoPeso}");
Console.WriteLine($"El minimo peso es {minimoPeso}");
Console.WriteLine($"Los ninos no contabilizados fueron {contador0}");
Console.WriteLine($"El peso promedio de 0 a 1 es {promedio1}");
Console.WriteLine($"El peso promedio de 1 a 3 es {promedio2}");
Console.WriteLine($"El peso promedio de 3 a 5 es {promedio3}");





