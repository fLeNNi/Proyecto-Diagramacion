string codProd = "", codProdAnt = "", codMaxVend = "", codMinVend = "";
int cantVend = 0, cantTotVend = 0, maxVend = 0, minVend = 0;
bool primero = true, segundo = true;
Console.WriteLine("Digite el codigo del producto\nDigite 000 si quiere salir");
codProd = Console.ReadLine();
codProdAnt = codProd;

while (!codProd.Equals("000"))
{
    while (codProd.Equals(codProdAnt))
    {
        Console.WriteLine($"Ingrese la cantidad vendida del producto: {codProd} ");
        cantVend = int.Parse(Console.ReadLine());
        cantTotVend = cantVend + cantTotVend;
        Console.WriteLine("Digite el codigo del producto\nDigite 000 si quiere salir");
        codProd = Console.ReadLine();
    }
    if (primero)
    {
        maxVend = cantTotVend;
        codMaxVend = codProdAnt;
        primero = false;
    }
    else
    {
        if (maxVend < cantTotVend)
        {
            maxVend = cantTotVend;
            codMaxVend = codProdAnt;

        }
    }
    if (segundo)
    {
        minVend = cantTotVend;
        codMinVend = codProdAnt;
        segundo = false;
    }
    else
    {
        if (minVend > cantTotVend)
        {
            minVend = cantTotVend;
            codMinVend = codProdAnt;
        }
    }
    codProdAnt = codProd;
    cantTotVend = 0;
}
Console.WriteLine($"El producto {codMaxVend} fue el mas vendido con {maxVend} cantidades");
Console.WriteLine($"El producto {codMinVend} fue el menos vendido con {minVend} cantidades");