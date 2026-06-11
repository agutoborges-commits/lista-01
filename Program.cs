Console.WriteLine("Nota do Aluno: ");
int nota = int.Parse(Console.ReadLine());
if (nota >= 7)
{
    Console.WriteLine("Estudante Aprovado");
}
else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Estudante em Recuperação");
}
else
{
    Console.WriteLine("Estudante Reprovado");
}