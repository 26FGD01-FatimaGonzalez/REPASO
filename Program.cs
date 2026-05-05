internal class Program
{
    private static void Main(string[] args)
    {
        double saldo=10000;
        int intentos = 0;
        int pinCorrecto = 1234; 
        int pinIngresado;

        //VALIDACION DEL PIN
        while (intentos<3)
        {
            Console.Write("Ingrese su PIN: ");
            if (int.TryParse(Console.ReadLine(), out pinIngresado))
            {
                if (pinIngresado==pinCorrecto)
                {
                 Console.WriteLine("PIN correcto. Acceso concedido.");

                    int opcion=0;
                    //menu principal
                    while (opcion!=4)
                    {
                        Console.WriteLine("===============================");
                        Console.WriteLine("Seleccione una opción:");
                        Console.WriteLine("1. Consultar saldo");
                        Console.WriteLine("2. Retirar dinero");
                        Console.WriteLine("3. Depositar dinero");
                        Console.WriteLine("4. Salir");
                        Console.WriteLine("===============================");

                        if (int.TryParse(Console.ReadLine(), out opcion))
                        {
                            switch (opcion)
                            {
                                case 1:
                                    Console.WriteLine("Su saldo actual es: $" + saldo);
                                    break;
                                case 2:
                                    Console.Write("Ingrese el monto a retirar: $");
                                    if (double.TryParse(Console.ReadLine(), out double montoRetirar))
                                    {
                                        if (montoRetirar <= saldo)
                                        {
                                            saldo -= montoRetirar;
                                            Console.WriteLine("Retiro exitoso. Su nuevo saldo es: $" + saldo);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fondos insuficientes.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Monto inválido.");
                                    }
                                    break;
                                case 3:
                                    Console.Write("Ingrese el monto a depositar: $");
                                    if (double.TryParse(Console.ReadLine(), out double montoDepositar))
                                    {
                                        saldo += montoDepositar;
                                        Console.WriteLine("Depósito exitoso. Su nuevo saldo es: $" + saldo);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Monto inválido.");
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Gracias por usar el cajero automático. ¡Hasta luego!");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                                    break;
                            }
                        }
                        else
                        {
                        }
                        Console.WriteLine("Entrada no válida. Por favor, ingrese un número del 1 al 4.");
                    }
                }
                else
                {
                    intentos++;
                    Console.WriteLine("PIN incorrecto. Intentos restantes: "+ intentos +"de 3 \n");
                }
            }
            else
            {
                Console.WriteLine("Digite un PIN válido"); 
            }

        }

        //bloqueo de la tarejta
        Console.WriteLine("Tarjeta bloqueada \n Demasiados intentos fallidos!!");
        Console.ReadKey();
    }
}