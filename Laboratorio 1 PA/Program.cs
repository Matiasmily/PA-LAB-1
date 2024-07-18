// See https://aka.ms/new-console-template for more information
double numberOne = 0, numberTwo = 0, result;
bool menuOptionThree = true;

do
{
    try
    {
        Console.Clear();
    Console.WriteLine(" ----- MULTIPLICACIONES Y DIVISIONES -----");
    Console.WriteLine("1. Multiplicación");
    Console.WriteLine("2. División");
    Console.WriteLine("3. Salir");
    Console.Write("Ingrese una opción: ");
    int optionMenu = int.Parse(Console.ReadLine());
    switch (optionMenu)
    {
        case 1:
            Console.Clear ();
            Console.WriteLine("----- MULTIPLICACIÓN -----");
            Console.Write("Ingrese el primer número: ");
            numberOne = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            numberTwo = double.Parse(Console.ReadLine());
            result = numberOne * numberTwo;
            Console.WriteLine($"\nEl resultado de la multiplicación es: {result}");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadKey();
            menuOptionThree = false;
            break;
        case 2:
            Console.Clear ();
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("----- DIVISIÓN -----");
                    Console.Write("Ingrese el primer número: ");
                    numberOne = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    numberTwo = double.Parse(Console.ReadLine());
                    result = numberOne/numberTwo;
                    Console.WriteLine($"\nEl resultado de la división es {result}");
                    Console.WriteLine("Presione enter para continuar...");
                    Console.ReadKey();
                    menuOptionThree = false;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero");
                    Console.WriteLine("\nPresione enter para continuar...");
                    Console.ReadKey();
                }
            } while (numberTwo == 0);
            break;
        case 3:
            Console.Clear ();
            Console.WriteLine("Usted está cerrando el programa");
            Console.WriteLine("Presione enter para cerrar...");
            Console.ReadKey (); 
            menuOptionThree= false;
            break;
        default:
            Console.WriteLine("\nIngrese una opción válida.");
            Console.ReadKey();
            break;
    }
   

    }
    catch (FormatException)
    {
        Console.WriteLine("Error: Ingrese un valor numérico.");
        Console.WriteLine("\nPresione enter para continuar.");
        Console.ReadKey();
    }
} while (menuOptionThree);