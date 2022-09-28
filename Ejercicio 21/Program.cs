int anio = 0;

Console.WriteLine("Ingrese el anio");
anio = int.Parse(Console.ReadLine());

if((anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0)){
    Console.WriteLine($"{anio} es/fue/sera bisiesto");
}
else
{
    Console.WriteLine($"{anio} no es/fue/sera bisiesto");
}