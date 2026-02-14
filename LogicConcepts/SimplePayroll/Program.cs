using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do 
{ 
    var name = ConsoleExtension.GetString("Ingrese el nombre: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese el número de horas trabajadas: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese el valor de la hora: ");
    var salaryMinimum = ConsoleExtension.GetDecimal("Ingrese el salario mínimod mensual: ");

    var salary = (decimal)workHours * hourValue;
    if (salary < salaryMinimum)
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario: {salaryMinimum:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario: {salary:C2}");
    }

    do
    { 
        answer = ConsoleExtension. GetValidOptions("¿Desea calcular otro salario? [S]í. [N]o : ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("¡Gracias por usar el programa!");
