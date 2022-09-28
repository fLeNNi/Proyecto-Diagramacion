int notaParcial = 0, notaTp = 0, notaIntegrador = 0, notaFinal = 0;

Console.WriteLine("Ingrese la nota del parcial");
notaParcial = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota del tp");
notaTp = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota del examen integrador");
notaIntegrador = int.Parse(Console.ReadLine());

Console.WriteLine($"La nota final es {0.30 * notaParcial + 0.20 * notaTp + 0.50 * notaIntegrador}");