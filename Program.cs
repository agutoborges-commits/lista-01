Console.WriteLine("informe a idade: ");
int idade = int.Parse(Console.ReadLine());
if (idade >= 0 && idade <= 11)
{
        Console.WriteLine("faixa de criança");
}
else if (idade >= 12 && idade <= 17)
{
        Console.WriteLine("faixa de adolescente");
}
else if (idade >= 18 && idade <= 59)
{
        Console.WriteLine("faixa de adulto");
}
else
{
        Console.WriteLine("faixa de idoso");
}