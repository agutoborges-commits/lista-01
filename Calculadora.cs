public class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }
    public int multiplicar(int a, int b)
    {
        return a * b;
    }
    public double delta(double a, double b, double c)
    {
        return (b * b) - (4 * a * c);
    }
    public double bhaskara(double a, double b, double delta)
    {
        return (b * -1 + Math.Sqrt(delta)) / (2 * a);
    }

    public int subtrair(int a, int b, int c)
    {
        return a - b - c;
    }
}