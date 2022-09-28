int preguntas = 0, respCorrectas = 0;
int porcentaje = 0;
Console.WriteLine("Ingrese la cantidad de preguntas");
preguntas = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de respuestas correctas");
respCorrectas = int.Parse(Console.ReadLine());

porcentaje = ((respCorrectas/preguntas) * 100);

if (porcentaje >= 89)
{
    Console.WriteLine("Nivel obtenido: 1");
}
if (porcentaje >= 75 && porcentaje < 89)
{
    Console.WriteLine("Nivel obtenido: 2");
}
if (porcentaje >= 50 && porcentaje < 70)
{
    Console.WriteLine("Nivel obtenido: 3");
}
if (porcentaje < 50)
{
    Console.WriteLine("Nivel obtenido: 4");
}