int hora = 0, minuto = 0, segundo = 0, resultado = 0;

Console.WriteLine("Ingrese la hora");
hora = int.Parse(Console.ReadLine());   
Console.WriteLine("Ingrese los minutos");
minuto = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese los segundos");        
segundo = int.Parse(Console.ReadLine());      

resultado = (hora * 3600) + (minuto * 60) + segundo;
Console.WriteLine($"Los segundos son: {resultado}");
