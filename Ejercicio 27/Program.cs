int numero = 0, resultado = 1; // resultado 1 porque si multiplico por 0 siempre me dara 0 
            do
            {

                Console.WriteLine("Ingrese el numero a calcular el factorial, debe ser positivo.");
                numero = int.Parse(Console.ReadLine());
                if (numero <= -1)
                {
                    Console.WriteLine("No se aceptan numeros negativos!!");
                }
            }
            while (numero <= -1);

            for (int i = 1; i <= numero; i++) // se suma i +1 cada repetición hasta ser igual al numero a factoriar
            {
                resultado = resultado * i; //se multiplica hasta que i llega al numero a factoriar
            }
            if (numero == 0)
            {
                Console.WriteLine("El factorial es 1");
            }
            else
            {
                Console.WriteLine($"el factorial de su número es {resultado}");
            }
            Console.ReadKey(true);

