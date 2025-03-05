var numberString = string.Empty;
do
{
    Console.WriteLine("Ingrese número o 'salir' para salir: ");
    numberString = Console.ReadLine();
    if (numberString!.ToLower() == "salir")
    {
        continue;
    }

    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {

        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt} es par");
        }
        else
        {
            Console.WriteLine($"El número {numberInt} es impar");
        }
    }
    else
    {
        Console.WriteLine($"El valor ingresado {numberString} no es un número");
    }
} while (numberString!.ToLower() != "salir");
Console.WriteLine("Game Over");