using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var a = ConsoleExtension.GetInt("Ingrese el primer número : ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    if (b % a == 0)
    {
        Console.WriteLine($"{a} es múltiplo {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es múltiplo {b}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Quieres continuar? [S]í, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("¡Hasta luego!");

