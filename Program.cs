Console.WriteLine("Informe a idade do passageiro:");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor normal da passagem: ");
double valorPassagem = double.Parse(Console.ReadLine());
if (idade < 5)
{
    Console.WriteLine("Passagem gratuita");
}
else if (idade >= 60)
{
    double valorDesconto = valorPassagem * 0.5;
    Console.WriteLine($"Valor da passagem com desconto: {valorDesconto}");
}
else if (idade > 5 && idade < 60)
{
    Console.WriteLine($"Valor normal da passagem: {valorPassagem}");
}
