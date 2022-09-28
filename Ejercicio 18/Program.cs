string apellido = "", nombre = "";
float sueldoBasico = 0;
int antiguedad = 0;

Console.WriteLine("Ingrese el sueldo basico");
sueldoBasico = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la antiguedad");
antiguedad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese el apellido");
apellido = Console.ReadLine();

if(antiguedad > 9)
{
    Console.WriteLine($"El sueldo de: {nombre} es de: {(sueldoBasico * 40) + sueldoBasico}");

}
else
{
    Console.WriteLine($"El sueldo de: {nombre} es de: {sueldoBasico}");
}