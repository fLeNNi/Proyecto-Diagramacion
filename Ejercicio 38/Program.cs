int nota = 0, nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0, nota5 = 0, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, aprobados = 0, desaprobados = 0, materia = 0, examen = 0;
string curso = "", cursoAnt = "";
Console.WriteLine("Introduzca el numero del curso \n Digite 000 para salir ");
curso = Console.ReadLine();
cursoAnt = curso;

while (!curso.Equals("000"))
{
    while (cursoAnt.Equals(curso) && !curso.Equals("000"))
    {
        Console.WriteLine("Ingrese el numero de materia");
        materia = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la nota del examen");
        examen = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduzca el numero del curso \n Digite 000 para salir");
        curso = Console.ReadLine();
    }
    if (nota >= 6)
    {
        aprobados++;

    }
    else
    {
        desaprobados++;
    }


    switch (materia)
    {
        case 1:
            nota1 = nota1 + nota;
            cont1 = cont1 + 1;
            break;
        case 2:
            nota2 = nota2 + nota;
            cont2 = cont2 + 1;
            break;
        case 3:
            nota3 = nota3 + nota;
            cont3 = cont3 + 1;
            break;
        case 4:
            nota4 = nota4 + nota;
            cont4 = cont4 + 1;
            break;
        case 5:
            nota5 = nota5 + nota;
            cont5 = cont5 + 1;
            break;
    }
    cursoAnt = curso;

}
if (cont1 != 0)
{
    Console.WriteLine($"Promedio de materia nro1:, {nota1 / cont1}");
}
if (cont2 != 0)
{
    Console.WriteLine($"Promedio de materia nro2:, {nota2 / cont2}");
}
if (cont3 != 0)
{
    Console.WriteLine($"Promedio de materia nro3:, {nota3 / cont3}");
}
if (cont4 != 0)
{
    Console.WriteLine($"Promedio de materia nro4, {nota4 / cont4}");
}
if (cont5 != 0)
{
    Console.WriteLine($"Promedio de materia nro5:, {nota5 / cont5}");
}
Console.WriteLine($"Cantidad de alumnos aprobados:, {aprobados}, \nCantidad de alumnos desaprobados:, {desaprobados}");

