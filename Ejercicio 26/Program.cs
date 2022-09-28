int num = 0,i ;
double factorial;

do{
    Console.WriteLine("Ingrese un numero");
    num = int.Parse(Console.ReadLine());
}while(num < 0);   

for(i = 1, factorial = 1; i <= num; i++)
{
    factorial = factorial * i;
    
}       

Console.WriteLine($"El factorial de ${num} es ${factorial}");