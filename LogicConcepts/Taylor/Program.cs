using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var n = ConsoleExtension.GetInt("Cúantos terminos desea: ");
    var x = ConsoleExtension.GetDouble("Digita el valor de x..: ");
    var taylor = Taylor(x, n);
    Console.WriteLine($"f(a{x}) = {taylor:N5}");


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("¡Gracias por usar el programa!");

double Taylor(double x, int n)
{
    double sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += Math.Pow(x, i) / MyMath.Factorial(i);
    }
    return sum;
}

