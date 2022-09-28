float num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, resultado = 0;

Console.WriteLine("Ingrese el primer numero");
    num1 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
    num2 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer numero");
    num3 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el cuarto numero");
    num4 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el quinto numero");
    num5 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el sexto numero");
    num6 = float.Parse(Console.ReadLine());

resultado = (num1 + num2 + num3 + num4 + num5 + num6) / 6;

Console.WriteLine(resultado);