int qAutos = 3; 
string[] modelosAutos = new string[qAutos];
float[] sumasVentas = new float[qAutos];
int CodigoModeloMayorVenta = 0;                   // declaramos slos tring y varialbles
int codigoAuto = 0;
float valorVenta = 0;                       
float precioMaximo = 0;
Boolean bPrimeraVez = true;


for (int i = 0; i <= modelosAutos.Length -1; i++)      // ciclo for para inicializar los modelos 
{
    Console.Write($"Ingrese la descripcion del modelo {i + 1}: ");
    modelosAutos[i] = Console.ReadLine();
}

Console.Write("Ingrese el codigo del vehiculo vendido: ");
codigoAuto = int.Parse(Console.ReadLine());                   //lecturas y parseo
codigoAuto = codigoAuto -1;                                 // decremento en 1

while (codigoAuto >= 0 && codigoAuto <= qAutos - 1)     // evaluo la expresion     
{
    Console.Write($"Ingrese el valor de la venta del modelo {modelosAutos[codigoAuto]}: ");
    valorVenta = float.Parse(Console.ReadLine());

    sumasVentas[codigoAuto] = sumasVentas[codigoAuto] + valorVenta;  // acumulo 

    if (bPrimeraVez)    // evaluacion para el maximo venta 
    {
        precioMaximo = valorVenta;

        CodigoModeloMayorVenta = codigoAuto;

        bPrimeraVez = false;
    }

    else if (precioMaximo < valorVenta)   // evalucion para precio maximo luego
    {
        precioMaximo = valorVenta;
        CodigoModeloMayorVenta = codigoAuto;
    }

    Console.Write("Ingrese el codigo del siguiente modelo que se vendio: "); // solicito nuevo auto
    codigoAuto = int.Parse(Console.ReadLine());
    codigoAuto = codigoAuto - 1;
}

bPrimeraVez = true;

for (int k = 0; k < sumasVentas.Length; k++)
{
    if (sumasVentas[k] != 0 && bPrimeraVez)
    {
        Console.WriteLine("Codigo \t modelo \t total vendido: ");
        Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t {sumasVentas[k]}");
        bPrimeraVez = false;
    }

    else if (sumasVentas[k] != 0)
    {
        Console.WriteLine($"{k + 1} \t {modelosAutos[k]} \t {sumasVentas[k]}");
    }
}

Console.WriteLine($"El modelo que registro la mejor venta fue {modelosAutos[CodigoModeloMayorVenta]} por {precioMaximo} pesos");