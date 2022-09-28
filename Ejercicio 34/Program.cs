///*34.	Dado un listado con los nombres y las 4 notas obtenidas por los alumnos de un curso, 
// * calcular e informar el promedio de cada uno y una leyenda que indique si está o no aprobado. 
// * No se conoce la cantidad total de alumnos a procesar. De acuerdo a cada versión utilice la estructura de repetición más adecuada.
//•	Versión con listado de alumnos de 1 a n
//•	Versión con listado de 50 alumnos
//•	Versión con listado de 0 o n alumnos*\ 


string nombre = "";
int nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, promedio = 0, contador = 1;
Boolean seguir = true;
Console.WriteLine("Escriba el nombre del alumno");
nombre = Console.ReadLine();
Console.WriteLine("Digite la primer nota");
nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite la segunda nota");
nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite la ptercer nota");
nota3 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite la cuarta nota");
nota4 = int.Parse(Console.ReadLine());

promedio = (nota1 + nota2 + nota3 + nota4) / 4;
// PARA EL DE 50 ALUMNOS
//do
//{
//    contador++;

//    if(promedio >= 6)
//    {
//        Console.WriteLine($"El alumno esta aprobado, su promedio es {promedio}");
//    } else
//    {
//        Console.WriteLine($"El alumno esta desaprobado, su promedio es {promedio}");
//    }
//    Console.WriteLine("Escriba el nombre del alumno");
//    nombre = Console.ReadLine();
//    Console.WriteLine("Digite la primer nota");
//    nota1 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Digite la segunda nota");
//    nota2 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Digite la ptercer nota");
//    nota3 = int.Parse(Console.ReadLine());
//    Console.WriteLine("Digite la cuarta nota");
//    nota4 = int.Parse(Console.ReadLine());

//    promedio = (nota1 + nota2 + nota3 + nota4) / 4;

//} while (contador++ < 50);


// PARA EL DE 1 A N
//do
//   {
//       contador++;

//       if (promedio >= 6)
//       {
//           Console.WriteLine($"El alumno esta aprobado, su promedio es {promedio}");
//       }
//       else
//       {
//           Console.WriteLine($"El alumno esta desaprobado, su promedio es {promedio}");
//       }
//       Console.WriteLine("Digite 0 para salir o 1 para continuar");
//       int verificacion = int.Parse(Console.ReadLine());
//       if (verificacion == 0)
//       {
//           seguir = false;
//       }
//       if (verificacion == 1)
//       {
//           Console.WriteLine("Escriba el nombre del alumno");
//           nombre = Console.ReadLine();
//           Console.WriteLine("Digite la primer nota");
//           nota1 = int.Parse(Console.ReadLine());
//           Console.WriteLine("Digite la segunda nota");
//           nota2 = int.Parse(Console.ReadLine());
//           Console.WriteLine("Digite la ptercer nota");
//           nota3 = int.Parse(Console.ReadLine());
//           Console.WriteLine("Digite la cuarta nota");
//           nota4 = int.Parse(Console.ReadLine());
//           promedio = (nota1 + nota2 + nota3 + nota4) / 4;
//       }

//   } while (contador++ < 50 && seguir == true);

// DE 0 A N 
while (seguir == true)
{
    contador++;

    if (promedio >= 6)
    {
        Console.WriteLine($"El alumno esta aprobado, su promedio es {promedio}");
    }
    else
    {
        Console.WriteLine($"El alumno esta desaprobado, su promedio es {promedio}");
    }
    Console.WriteLine("Digite 0 para salir o 1 para continuar");
    int verificacion = int.Parse(Console.ReadLine());
    if (verificacion == 0)
    {
        seguir = false;
    }
    if (verificacion == 1)
    {
        Console.WriteLine("Escriba el nombre del alumno");
        nombre = Console.ReadLine();
        Console.WriteLine("Digite la primer nota");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la segunda nota");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la ptercer nota");
        nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite la cuarta nota");
        nota4 = int.Parse(Console.ReadLine());
        promedio = (nota1 + nota2 + nota3 + nota4) / 4;

    }
}