using System;

class OperacionesMatematicas
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nOperaciones Matemáticas Básicas");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            Console.Write("Selecciona una operación (1/2/3/4/5): ");
            string opcion = Console.ReadLine();

            if (opcion == "5")
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }

            Console.Write("Ingresa el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Error: Por favor ingresa un número válido.");
                continue;
            }

            Console.Write("Ingresa el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Error: Por favor ingresa un número válido.");
                continue;
            }

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {Sumar(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine($"Resultado: {Restar(num1, num2)}");
                    break;
                case "3":
                    Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                    break;
                case "4":
                    Console.WriteLine($"Resultado: {Dividir(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intenta de nuevo.");
                    break;
            }
        }
    }

    static double Sumar(double a, double b)
    {
        return a + b;
    }

    static double Restar(double a, double b)
    {
        return a - b;
    }

    static double Multiplicar(double a, double b)
    {
        return a * b;
    }

    static string Dividir(double a, double b)
    {
        if (b != 0)
        {
            return (a / b).ToString();
        }
        else
        {
            return "Error: División por cero no permitida.";
        }
    }
}