string[] modeloAutos = new string[49];
float[] sumasVentas = new float[49];
int codigoAuto = 0, codigoMayorVenta = 0;
float precioMax = 0, valorVenta = 0;
bool bPrimeraVez = true;
int qAutos = 49;

for(int i = 0; i < modeloAutos.Length - 1; i++)
{
    Console.WriteLine($"Ingrese la descripcion del modelo {i + 1}");
    modeloAutos[i] = Console.ReadLine();
}

Console.WriteLine("Digite el codigo del auto");
codigoAuto = int.Parse(Console.ReadLine());
codigoAuto = codigoAuto - 1;

while (codigoAuto >= 0 && codigoAuto < qAutos -1)
{
    Console.ReadLine("Ingrese el valor de venta del modelo ")
}


