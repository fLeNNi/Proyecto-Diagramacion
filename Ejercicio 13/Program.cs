int iFecha1 = 0, iFecha2 = 0, iAnio1 = 0, iAnio2 = 0, iMes1 = 0, iMes2 = 0, iDia1 = 0, iDia2 = 0;

Console.WriteLine("Ingrese la primer fecha");
iFecha1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la segunda fecha");
iFecha2 = int.Parse(Console.ReadLine());

iAnio1 = iFecha1 % 10000;
iAnio2 = iFecha2 % 10000;

if(iAnio1 < iAnio2)
{
    Console.WriteLine($"{iFecha1} es la menor fecha");
} else if(iAnio1 > iAnio2)
{
    Console.WriteLine($"{iFecha2} es la menor fecha");
}
else
{
    iMes1 = (iFecha1 % 1000000) / 10000;
    iMes2 = (iFecha2 % 1000000) / 10000;
    if(iMes1 < iMes2)
    {
        Console.WriteLine($"{iFecha2} es la menor fecha");
    }
    else
    {
        iDia1 = iFecha1 / 1000000;
        iDia2 = iFecha2 / 1000000;
        if( iDia1 < iDia2)
        {
            Console.WriteLine($"{iFecha1} es la menor fecha");
        }else if(iDia1 > iDia2)
        {
            Console.WriteLine($"{iFecha2} es la menor fecha");
        }
        else
        {
            Console.WriteLine("Las fechas son iguales");
        }
    }
}

