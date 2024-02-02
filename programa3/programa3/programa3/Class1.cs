using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("¡Bienvenido al juego de dados!");

        // Generar valores para los tres dados
        int dado1 = ObtenerNumeroAleatorio();
        int dado2 = ObtenerNumeroAleatorio();
        int dado3 = ObtenerNumeroAleatorio();

        // Mostrar los resultados de los dados
        Console.WriteLine($"Resultado del dado 1: {dado1}");
        Console.WriteLine($"Resultado del dado 2: {dado2}");
        Console.WriteLine($"Resultado del dado 3: {dado3}");

        // Verificar si los tres dados tienen el mismo valor
        if (dado1 == dado2 && dado2 == dado3)
        {
            Console.WriteLine("¡Felicidades! Has ganado.");
        }
        else
        {
            Console.WriteLine("Lo siento, has perdido.");
        }
    }

    static int ObtenerNumeroAleatorio()
    {
        // Generar y devolver un número aleatorio entre 1 y 6.
        Random random = new Random();
        return random.Next(1, 7);
    }
}


