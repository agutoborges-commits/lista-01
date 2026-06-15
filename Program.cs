Console.WriteLine("informe a primeira pontuação: ");
int pontuacao1 = int.Parse(Console.ReadLine());
Console.WriteLine("informe a segunda pontuação: ");
int pontuacao2 = int.Parse(Console.ReadLine());
Console.WriteLine("informe a terceira pontuação: ");
int pontuacao3 = int.Parse(Console.ReadLine());
if (pontuacao1 > pontuacao2 && pontuacao1 > pontuacao3)
{
    Console.WriteLine("a maior pontuação é: " + pontuacao1);
}
else if (pontuacao2 > pontuacao1 && pontuacao2 > pontuacao3)
{
    Console.WriteLine("a maior pontuação é: " + pontuacao2);
}
else
{
    Console.WriteLine("a maior pontuação é: " + pontuacao3);
}