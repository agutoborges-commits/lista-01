
        float saldo, valor;
        int operacao;

        Console.Write("Informe o saldo inicial: R$ ");
        saldo = float.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine("\nEscolha a operação:");
            Console.WriteLine("1 - Entrada de dinheiro");
            Console.WriteLine("2 - Saída de dinheiro");
            Console.WriteLine("3 - Encerrar");

            operacao = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                Console.Write("Informe o valor da movimentação: R$ ");
                valor = float.Parse(Console.ReadLine());

                saldo += valor;

                Console.WriteLine("Entrada registrada. Saldo atual: R$ " + saldo);
            }
            else if (operacao == 2)
            {
                Console.Write("Informe o valor da movimentação: R$ ");
                valor = float.Parse(Console.ReadLine());

                if (valor <= saldo)
                {
                    saldo -= valor;

                    Console.WriteLine("Saída registrada. Saldo atual: R$ " + saldo);
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }

        } while (operacao != 3);

        Console.WriteLine("Saldo final: R$ " + saldo);