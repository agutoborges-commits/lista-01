Console.WriteLine("Informe uma nota de 0 a 10: ");
float nota = float.Parse(Console.ReadLine());
while (nota < 0 || nota > 10)
{
        Console.WriteLine("Informe uma nota de 0 a 10: ");
        nota = float.Parse(Console.ReadLine());
}
Console.WriteLine("Nota válida!");
Console.WriteLine("Nota registrada: " + nota);