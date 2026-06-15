
        int quantidadeClientes;
        int tempo;
        int tempoTotal = 0;
        float tempoMedio;

        Console.WriteLine("Informe a quantidade de clientes atendidos: ");
        quantidadeClientes = int.Parse(Console.ReadLine());

        // Repetição para ler o tempo de cada atendimento
        for (int i = 1; i <= quantidadeClientes; i++)
        {
            Console.WriteLine("Informe o tempo do atendimento: ");
            tempo = int.Parse(Console.ReadLine());

            tempoTotal += tempo;
        }

        // Calcula a média
        tempoMedio = (float)tempoTotal / quantidadeClientes;

        Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
        Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");
