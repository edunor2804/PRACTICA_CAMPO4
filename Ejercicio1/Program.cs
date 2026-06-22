//EJERCICIO 1: VERIFICADOR DE NÚMEROS PRIMOS

using System;

internal class VerificadorPrimos
{
    // Método que recibe un parámetro entero y devuelve un booleano
    public static bool EsNumeroPrimo(int numero)
    {
        // Los números menores o iguales a 1 no son primos
        if (numero <= 1) return false;

        // Bucle para verificar si tiene algún divisor además de 1 y de sí mismo
        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
            {
                return false; // Si se encuentra un divisor, no es primo
            }
        }
        return true; // Si no se encontraron divisores, es primo
    }

    static void Main(string[] args)
    {
        Console.WriteLine("--- CASO 1: VERIFICADOR DE NÚMEROS PRIMOS ---");

        int numEvaluar;

        // Bucle de intentos infinitos
        while (true)
        {
            Console.Write("Ingrese un número entero para evaluar: ");

            // Si la conversión es exitosa, rompemos el bucle
            if (int.TryParse(Console.ReadLine(), out numEvaluar))
            {
                break;
            }

            // Si llega aquí, la entrada fue inválida y el bucle vuelve a empezar
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: Por favor, ingrese un número entero válido.");
            Console.ResetColor();
            Console.WriteLine(); // Línea en blanco para separar los intentos
        }

        // Llamada al método enviando la variable como argumento
        bool resultado = EsNumeroPrimo(numEvaluar);

        // Condicional para mostrar la respuesta final según el retorno del método
        Console.WriteLine();
        if (resultado)
        {
            Console.WriteLine($"El número {numEvaluar} SÍ es un número primo.");
        }
        else
        {
            Console.WriteLine($"El número {numEvaluar} NO es un número primo.");
        }

        Console.ReadKey();
    }
}
