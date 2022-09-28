int dia = 0, mes = 0, anio = 0, fechaIngresada = 0;
bool fechaCorrecta = true;
string mensaje = "La fecha ingresada es correcta";

Console.WriteLine("Ingrese la fecha");
fechaIngresada = int.Parse(Console.ReadLine());

dia = fechaIngresada / 1000000;
mes = (fechaIngresada % 1000000) / 10000;
anio = fechaIngresada % 10000;

if (!((anio < 0) || (mes < 1 || mes > 12) || (dia < 0 || dia > 31)))
{
    if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
    {
        if (dia < 1 || dia > 31)
        {
            fechaCorrecta = false;
            mensaje = "El dia ingresado no es valido para el mes ingresado";
        }
    }
    else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
    {
        if (dia < 1 || dia > 30)
        {
            fechaCorrecta = false;
            mensaje = "El dia ingresado no es valido para el mes ingresado";
        }
    }
    else
    {
        if ((anio % 400) == 0 || (anio % 4) == 0 && (anio % 100) != 0)
        {
            if (dia < 1 || dia > 29)
            {
                fechaCorrecta = false;
                mensaje = "El dia ingresado no es valido para el mes ingresado";
            }
        }
        else if (dia < 1 || dia > 28)
        {
            fechaCorrecta = false;
            mensaje = "El dia ingresado no es valido para el mes ingresado";

        }
    }

}
  else{
        fechaCorrecta = false;
        mensaje = "La fecha ingresada no es valida";
    }
    Console.WriteLine($"{mensaje} \nSu fecha: {dia}/{mes}/{anio}");
