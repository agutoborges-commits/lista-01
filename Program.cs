Console.WriteLine("Qual é sua idade?");
int idade = int.Parse(Console.ReadLine());
if (idade >= 16)
{
    Console.WriteLine("Entrada permitida");
}
else
{
    Console.WriteLine("Entrada somente com responsável");
}