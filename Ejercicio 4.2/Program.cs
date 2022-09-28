int qAutos = 49;
string[] modelosAutos = new string[qAutos];
float[] sumasVentas = new float[qAutos];
int CodigoModeloMayorVenta = 0;
int CodigoModeloMenorVenta = 0;
int codigoAuto = 0;
float valorVenta = 0;
float precioMaximo = 0;
float precioMinimo = 0;
Boolean bPrimeraVez = true;

for (int i = 0; i <= modelosAutos.Length - 1; i++)
{
    Console.Write($"Ingrese la descripcion del modelo {i + 1}: ");
    modelosAutos[i] = Console.ReadLine();
}

Console.Write("Ingrese el codigo del vehiculo vendido: ");
codigoAuto = int.Parse(Console.ReadLine());
codigoAuto = codigoAuto - 1;

while (codigoAuto >= 0 && codigoAuto <= qAutos - 1)
{
    Console.Write($"Ingrese el valor de la venta del modelo {modelosAutos[codigoAuto]}: ");
    valorVenta = float.Parse(Console.ReadLine());
    sumasVentas[codigoAuto] = sumasVentas[codigoAuto] + valorVenta;

    Console.Write("Ingrese el codigo del vehiculo vendido: ");
    codigoAuto = int.Parse(Console.ReadLine());
    codigoAuto = codigoAuto - 1;
}

precioMinimo = sumasVentas[0];
precioMaximo = sumasVentas[0];
CodigoModeloMenorVenta = 0;
CodigoModeloMayorVenta = 0;

for (int i = 1; i < sumasVentas.Length - 1; i++)
{
    if (precioMaximo < sumasVentas[i])
    {
        precioMaximo = sumasVentas[i];
        CodigoModeloMayorVenta = i;
    }
    if (precioMinimo > sumasVentas[i] && sumasVentas[i] != 0)
    {
        precioMinimo = sumasVentas[i];
        CodigoModeloMenorVenta = i;
    }
}

for (int k = sumasVentas.Length - 1; k >= 0; k--)
{
    if (sumasVentas[k] != 0 && bPrimeraVez)
    {
        Console.WriteLine("Codigo \t modelo \t total vendido: ");
        Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        bPrimeraVez = false;
    }
    else
    {
        if (sumasVentas[k] != 0)
        {
            Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        }
    }
}

bPrimeraVez = true;
for (int k = sumasVentas.Length - 1; k >= 0; k--)
{
    if (sumasVentas[k] != 0 && sumasVentas[k] == precioMaximo && bPrimeraVez)
    {
        Console.WriteLine("Listado de Modelos que registraron la mejor venta");
        Console.WriteLine("Codigo \t modelo \t total vendido: ");
        Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        bPrimeraVez = false;
    }
    else
    {
        if (sumasVentas[k] == precioMaximo)
        {
            Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        }
    }
}

bPrimeraVez = true;
for (int k = sumasVentas.Length - 1; k >= 0; k--)
{
    if (sumasVentas[k] != 0 && sumasVentas[k] == precioMinimo && bPrimeraVez)
    {
        Console.WriteLine("Listado de Modelos que registraron la menor venta");
        Console.WriteLine("Codigo \t modelo \t total vendido: ");
        Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        bPrimeraVez = false;
    }
    else
    {
        if (sumasVentas[k] == precioMinimo)
        {
            Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        }
    }
}

bPrimeraVez = true;
for (int k = sumasVentas.Length - 1; k >= 0; k--)
{
    if (sumasVentas[k] == 0 && bPrimeraVez)
    {
        Console.WriteLine("Listado de Modelos que NO registraron ventas");
        Console.WriteLine("Codigo \t modelo \t total vendido: ");
        Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        bPrimeraVez = false;
    }
    else
    {
        if (sumasVentas[k] == 0)
        {
            Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t\t {sumasVentas[k]}");
        }
    }
}