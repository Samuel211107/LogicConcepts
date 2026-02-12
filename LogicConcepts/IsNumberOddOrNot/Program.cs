using Shared;


var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var number = ConsoleExtension.GetInt("Ingresa un número entero diferente de cero: ");
    if (number == 0)
    {
        continue;
    }

    if (number % 2 == 0)
    {
        Console.WriteLine($"El número {number} es par.");
    }
    else
    {
        Console.WriteLine($"El número {number} es impar.");
    }


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas ingresar otro número? [S]í, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Programa terminado. ¡Hasta luego!");
