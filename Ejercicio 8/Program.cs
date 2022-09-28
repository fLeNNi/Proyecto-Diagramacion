int iFecha, iDia, iMes, iAnio;

Console.WriteLine("Digite la fecha");
iFecha = int.Parse(Console.ReadLine());

iDia = iFecha / 1000000;
iMes = (iFecha % 1000000) / 10000;
iAnio = iFecha % 10000;

Console.WriteLine($"La fecha desglozada es: {iDia}, {iMes}, {iAnio}");