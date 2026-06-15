
Console.WriteLine("informe a quantidade de tarefas concluidas: ");
int tarefas = int.Parse(Console.ReadLine());
if (tarefas >= 50){


        Console.WriteLine("Meta atingida");
}
else
{
        Console.WriteLine("Meta não atingida");
        tarefas = 50 - tarefas;
        Console.WriteLine("Faltam " + tarefas + " tarefas para atingir a meta");
}