int dia = 0, mes = 0, anio = 0, fechaIngresada = 0;

Console.WriteLine("Ingrese el dia");
dia = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el mes");
mes = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el anio");
anio = int.Parse(Console.ReadLine());

if(dia > 31 || dia <= 0)
{
    Console.WriteLine("El dia es incorrecto");
}else if(mes > 12 || mes <= 0){
    Console.WriteLine("El mes es incorrecto");
}else if(anio <= 0)
{
    Console.WriteLine("El anio es incorrecto");
}
else
{
    Console.WriteLine("La fecha ingresada es correcta");
}