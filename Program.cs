Console.WriteLine("Informe a temperatura atual");
int temperatura = int.Parse(Console.ReadLine());
if (temperatura < 18)
{
    Console.WriteLine("ambiente frio.");
}
else if (temperatura >= 18 && temperatura <= 26)
{
    Console.WriteLine("Ambiente confortável.");
}
else
{
    Console.WriteLine("Ambiente quentedotne.");
}