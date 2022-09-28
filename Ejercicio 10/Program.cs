int autosVendidos = 0;
float valorUnidad = 0, salarioTotal = 0;

Console.WriteLine("Ingrese la cantidad de autos vendidos");
autosVendidos = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor por unidad");
valorUnidad = float.Parse(Console.ReadLine());

salarioTotal = 5500 + (200 * autosVendidos) + ((valorUnidad * autosVendidos) * 5 / 100);
Console.WriteLine($"El salario total es {salarioTotal}");
