double numberOne = 0, numberTwo = 0;
bool menuOptionTwo = true;
do
{
    try
    {
        Console.Clear();
        Console.WriteLine("--- Suma y Resta ---");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Salir");
        Console.Write("Ingrese una opción: ");
        int optionCaseOne = int.Parse(Console.ReadLine());
        switch (optionCaseOne)
        {
            case 1:
                Console.Clear();
                Console.Write("Ingrese un número: ");
                numberOne = double.Parse(Console.ReadLine());
                Console.Write("Ingrese otro número: ");
                numberTwo = double.Parse(Console.ReadLine());
                double additionOption = numberOne + numberTwo;
                Console.WriteLine("El resultado de la suma es: " + additionOption);
                Console.WriteLine("\nPresione enter para regresar");
                Console.ReadKey();
                menuOptionTwo = false;
                break;
            case 2:
                Console.Clear();
                Console.Write("Ingrese un número: ");
                numberOne = double.Parse(Console.ReadLine());
                Console.Write("Ingrese otro número: ");
                numberTwo = double.Parse(Console.ReadLine());
                double substractionOption = numberOne - numberTwo;
                Console.WriteLine("El resultado de la suma es: " + substractionOption);
                Console.WriteLine("\nPresione enter para regresar");
                Console.ReadKey();
                menuOptionTwo = false;
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Usted está saliendo del menú\nPresione Enter para continuar");
                Console.ReadKey();
                menuOptionTwo = false;
                break;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Ingrese una opción numérica\nPresione Enter para continuar");
        Console.ReadKey();
    } 
} while (menuOptionTwo);