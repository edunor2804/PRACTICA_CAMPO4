//EJERCICIO 2:  SUMA 
using System;

internal class OperacionesMatematicas
{
    // MÉTODO: Recibe dos parámetros de tipo entero (a y b) y retorna su suma
    public static int SumarDosValores(int a, int b)
    {
        // Retorna directamente el resultado de la operación aritmética
        return (a + b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("--- CASO: SUMA ---");

        int n1;
        // Bucle de intentos infinitos para el primer número
        while (true)
        {
            Console.Write("Ingrese el primer número entero: ");
            if (int.TryParse(Console.ReadLine(), out n1))
            {
                break; // Entrada válida, sale del bucle
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Entrada incorrecta. Por favor, ingrese un número entero válido.");
            Console.ResetColor();
        }

        int n2;
        // Bucle de intentos infinitos para el segundo número
        while (true)
        {
            Console.Write("Ingrese el segundo número entero: ");
            if (int.TryParse(Console.ReadLine(), out n2))
            {
                break; // Entrada válida, sale del bucle
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Entrada incorrecta. Por favor, ingrese un número entero válido.");
            Console.ResetColor();
        }

        // INVOCACIÓN: Se llama al método pasando las variables locales como parámetros
        int total = SumarDosValores(n1, n2);

        // Muestra el resultado final en la consola
        Console.WriteLine();
        Console.WriteLine($"La suma total es igual a: {total}");

        Console.ReadKey();
    }
}
