using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese tres números diferentes...");
    var a = ConsoleExtension.GetInt("Ingrese el primer número :");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número:");
    if (a == b)
    { 
        Console.WriteLine("Los números deben ser diferentes, intente de nuevo...");
        continue;
    }

    var c = ConsoleExtension.GetInt("Ingrese el tercer número:");
    if (b == c || c == a)
    { 
        Console.WriteLine("Los números deben ser diferentes, intente de nuevo...");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mayor es {a}, el del medio es {b} y el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el del medio es {c} y el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b}, el del medio es {a} y el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el del medio es {c} y el menor es {a}");
        }
    }
    else
    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c}, el del medio es {a} y el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el del medio es {b} y el menor es {a}");
        }
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Quieres continuar? [S]í, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("¡Hasta luego!");