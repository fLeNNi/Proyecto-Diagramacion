int fuerza = 0, vidaEnem = 0, defensaEnem = 150;
double danio = 0;

Console.WriteLine("Digite la fuerza del personaje");
fuerza = int.Parse(Console.ReadLine());
while(fuerza > 700 || fuerza < 500)
{
    Console.WriteLine("La fuerza se pasa de los rangos admitidos, digitela otra vez");
    fuerza = int.Parse(Console.ReadLine());
}
Console.WriteLine("Digite la vida del enemigo del personaje");
vidaEnem = int.Parse(Console.ReadLine());
while (vidaEnem > 1000 || vidaEnem < 200)
{
    Console.WriteLine("La vida se pasa de los rangos admitidos, digitela otra vez");
    vidaEnem = int.Parse(Console.ReadLine());
}

danio = ((fuerza * 0.3) + (0.1 * vidaEnem)) - defensaEnem;

Console.WriteLine($"El enemigo recibe {danio} de danio");
