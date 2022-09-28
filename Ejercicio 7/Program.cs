int num1 = 0, num2 = 0;
float resultado;

Console.WriteLine("Ingrese el primer numero");
num1 = int.Parse(Console.ReadLine());   
Console.WriteLine("Ingrese el segundo numero");
num2 = int.Parse(Console.ReadLine());   

resultado = (num2 / num1);    
Console.WriteLine($"{resultado}");   