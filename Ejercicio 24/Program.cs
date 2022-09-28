int contador = 1, nroTicket = 10;

do
{
    Console.WriteLine($"Ticket Nro: {nroTicket} ");
    contador++;
    nroTicket = nroTicket + 10;
} while (contador <= 100);