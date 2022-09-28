string codSucursal = "", tiendaMayorVenta = "", codAnt = "";
int cantVend = 0, cantTotVend = 0, maxVenta = 0;
bool primero = true;

Console.WriteLine("Ingrese el codigo de sucursal\n Digite 000 para salir");
codSucursal = Console.ReadLine();
codAnt = codSucursal;

while (!codSucursal.Equals("000"))
{
    while(codSucursal.Equals(codAnt) && !codSucursal.Equals("000"))
    {
        Console.WriteLine($"Ingrese la cantidad vendida de la sucursal: {codAnt}");
        cantVend = int.Parse(Console.ReadLine());
        cantTotVend += cantVend;
        Console.WriteLine("Ingrese el producto vendido");
        Console.ReadLine();
        Console.WriteLine("Ingrese el codigo de sucursal\n Digite 000 para salir");
        codSucursal = Console.ReadLine();
    }
    Console.WriteLine($"La sucursal {codAnt} vendio {cantTotVend} productos");

    if (primero)
    {
        maxVenta = cantTotVend;
        tiendaMayorVenta = codAnt;
        primero = false;
    }
    else
    {
        if (maxVenta < cantTotVend)
        {
            maxVenta = cantTotVend;
            tiendaMayorVenta = codAnt;

        }
    }
    codAnt = codSucursal;
    cantTotVend = 0;
} 
Console.WriteLine($"La sucursal con mayor venta es {tiendaMayorVenta} y vendio {maxVenta}");
