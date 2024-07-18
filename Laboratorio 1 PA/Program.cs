
bool continueOne = true;
do
{
    try
    {
        Console.Clear();
        Console.WriteLine("--- Menú Principal");
        Console.WriteLine("1. Suma y Resta");
        Console.WriteLine("2. Multiplición y División");
        Console.WriteLine("3. Salir");
        Console.Write("Ingrese una opción: ");
        int optionOne = int.Parse(Console.ReadLine());
        switch (optionOne)
        {
            case 1:
                //Desarrollo Leo
                break;
            case 2:
                //Desarrollo Mily
                break;
            case 3:
                Console.WriteLine("Usted está saliendo del programa...");
                Console.WriteLine("Presione Enter para continuar");
                Console.ReadKey();
                continueOne = false;
                break;

            default:
                Console.WriteLine("Ingrese una opción válida");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine();
        Console.WriteLine("Ingrese una opción numérica");
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadKey();
    }
} while (continueOne);