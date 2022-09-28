string[] vDesc = { "televisor", "radio", "notebook", "celular", "ipod" };
string[] vCod = { "001", "002", "003", "004", "005" };
int[] vQPer = new int[5];
float[] vVTotProd = new float[5];
Boolean bPrimero = true;
string codProd = "";
float valoracion = 0, maxValoracion = 0;
int indiceMaxValoracion = 0;
const float VALORACIONSTD = 5;

Console.WriteLine("Ingrese codigo de producto 000 para terminar");
codProd = Console.ReadLine();

while (!codProd.Equals("000"))
{
    Console.WriteLine("Ingrese la valoración del producto");
    valoracion = float.Parse(Console.ReadLine());
    switch (codProd)
    {
        case "001":
            vQPer[0] = vQPer[0] + 1;
            vVTotProd[0] = (vVTotProd[0] + valoracion);
            break;
        case "002":
            vQPer[1] = vQPer[1] + 1;
            vVTotProd[1] = (vVTotProd[1] + valoracion);
            break;
        case "003":
            vQPer[2] = vQPer[2] + 1;
            vVTotProd[2] = (vVTotProd[2] + valoracion);
            break;
        case "004":
            vQPer[3] = vQPer[3] + 1;
            vVTotProd[3] = (vVTotProd[3] + valoracion);
            break;
        case "005":
            vQPer[4] = vQPer[4] + 1;
            vVTotProd[4] = (vVTotProd[4] + valoracion);
            break;
        default:
            Console.WriteLine("Código de producto inexistente, ingrese nuevamente, 000 para terminar.");
            break;
    }
    Console.WriteLine("Ingrese codigo de producto 000 para terminar");
    codProd = Console.ReadLine();
}

// INFORME 1
for (int i = 0; i < vQPer.Length; i++)
{
    if (vQPer[i] > 0)
    {
        if (bPrimero)
        {
            Console.WriteLine("Valoración de productos según encuesta de clientes");
            Console.WriteLine("Código de producto\tDescripción\tPromedio");
            Console.WriteLine($"{vCod[i]}\t{vDesc[i]}\t{vVTotProd[i] / vQPer[i]}");
        }
        else
        {
            Console.WriteLine($"{vCod[i]}\t{vDesc[i]}\t{vVTotProd[i] / vQPer[i]}");
        }
    }
}
// INFORME 2
for (int i = vVTotProd.Length - 1; i >= 0; i--)
{
    if (vVTotProd[i] / vQPer[i] > VALORACIONSTD)
    {
        if (bPrimero)
        {
            Console.WriteLine($"\n\nProductos que superaron la valoracion {VALORACIONSTD}");
            Console.WriteLine("Código de producto\tDescripción");
            Console.WriteLine($"{vCod[i]}\t{vDesc[i]}");
            bPrimero = false;
        }
        else
        {
            Console.WriteLine($"{vCod[i]}\t{vDesc[i]}");
        }
    }
}
//INFORME 3

bPrimero = true;
for (int i = 0; i < vVTotProd.Length; i++)
{
    if (bPrimero)
    {
        indiceMaxValoracion = i;
        maxValoracion = vVTotProd[i] / vQPer[i];
        bPrimero = false;
    }
    else
    {
        if (vVTotProd[i] / vQPer[i] > maxValoracion)
        {
            indiceMaxValoracion = i;
            maxValoracion = vVTotProd[i] / vQPer[i];
        }
    }
}

Console.WriteLine($"\n\nEl producto con mayor valoración es el {vDesc[indiceMaxValoracion]} con valoración {maxValoracion}, {vQPer[indiceMaxValoracion]} personas participaron de la encuesta\n\n");
