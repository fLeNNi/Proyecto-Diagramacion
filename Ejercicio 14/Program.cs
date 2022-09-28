int diaPersona1 = 0, mesPersona1 = 0, anioPersona1 = 0, anioPersona2 = 0, mesPersona2 = 0, diaPersona2 = 0;

Console.WriteLine("Ingrese el dia de la primera persona");
diaPersona1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el mes de la primera persona");
mesPersona1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el anio de la primera persona");
anioPersona1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el dia de la segunda persona");
diaPersona2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el mes de la segunda persona");
mesPersona2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el anio de la segunda persona");
anioPersona2 = int.Parse(Console.ReadLine());

if(diaPersona1 == diaPersona2 && mesPersona1 == mesPersona2 && anioPersona1 == anioPersona2)
{
    Console.WriteLine("Error: los 2 tienen la misma edad");
} else if(anioPersona1 > anioPersona2 || anioPersona1 == anioPersona2 && mesPersona1 > mesPersona2 || anioPersona1 == anioPersona2 && mesPersona1 == mesPersona2 && diaPersona1 > diaPersona2)
{
    Console.WriteLine("La segunda persona es mas grande y le corresponde el primer lugar de la fila");
}
else
{
    Console.WriteLine("La primera persona es mas grande y le corresponde el primer lugar de la fila");
}

