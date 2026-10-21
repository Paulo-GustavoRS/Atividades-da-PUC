class Program
{
    /*calcular o mdc de dois numeros conforme
    a formula de Euclides
    mdc(a,b) = mdc(b, a % b)
    */

    static void Main(string[] agrs)
    {
        Console.WriteLine("informe numero A");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("informe numero B");
        int b = int.Parse(Console.ReadLine());

        int MdC = MDC(a, b);

        Console.WriteLine($"\n{MdC}");
    }

    static int MDC(int A, int B)
    {
        if (B == 0)
        {
            return A;
        }

        else
        {
            return MDC(B, A % B);
        }
    }
}