float notaDeAprobacion = 4, nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, promedio = 0;

Console.WriteLine("Ingrese el valor de la primer nota del alumno");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la segunda nota del alumno");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la tercer nota del alumno");
nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor de la cuarta nota del alumno");
nota4 = float.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3 + nota4) / 4;
Console.WriteLine($"El promedio de tus notas es {promedio}");

if (promedio >= notaDeAprobacion)
{
    Console.WriteLine("El alumno esta aprobado");
}
else
{

};
