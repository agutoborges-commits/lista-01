using System;

class Program
{
    static void Main()
    {
        int numero;
        int positivos = 0;
        int negativos = 0;
        int zeros = 0;

        // Repete 10 vezes
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                positivos++;
            }
            else if (numero < 0)
            {
                negativos++;
            }
            else
            {
                zeros++;
            }
        }

        Console.WriteLine("Quantidade de positivos: " + positivos);
        Console.WriteLine("Quantidade de negativos: " + negativos);
        Console.WriteLine("Quantidade de zeros: " + zeros);
    }
}