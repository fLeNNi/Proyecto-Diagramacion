float basee = 0;
float altura = 0;
float superficie = 0;       

Console.WriteLine("Ingrese la base");
basee = float.Parse(Console.ReadLine());  
Console.WriteLine("Ingrese la altura");
altura = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la superficie");
superficie = float.Parse(Console.ReadLine());

superficie = (basee * altura) / 2;

Console.WriteLine(superficie);