using System;

class Program
{
    static void Main()
    {
        // Entrada: Solicita e lê o valor total da compra
        Console.Write("Informe o valor total da compra: ");
        if (double.TryParse(Console.ReadLine(), out double valorOriginal))
        {
            double desconto = 0;

            // Regra de processamento: Compras a partir de R$ 200,00 recebem 10% de desconto
            if (valorOriginal >= 200.00)
            {
                desconto = valorOriginal * 0.10; // 10% de desconto
            }
            // Compras abaixo de R$ 200,00 caem aqui, mantendo o desconto em 0

            // Cálculo do valor final
            double valorFinal = valorOriginal - desconto;

            // Saída esperada
            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine($"Valor original: {valorOriginal:C}");
            Console.WriteLine($"Desconto aplicado: {desconto:C}");
            Console.WriteLine($"Valor final: {valorFinal:C}");
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor numérico válido.");
        }
    }
}