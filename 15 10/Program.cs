class Elemento
{
    public string Nome;
    public Elemento Próx;

    public Elemento()
    {
        Nome = "";
        Próx = null;
    }
}

class Lista
{
    public Elemento Inicio;
    public Elemento Fim;

    public Lista()
    {
        Inicio = null;
        Fim = null;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Lista minhaLista = new Lista();

        for (int I = 1; I <= 5; I++)
        {
            Elemento x = new Elemento();

            Console.WriteLine($"Digiti o Nome{I}:");
            x.Nome = Console.ReadLine();

            if (minhaLista.Inicio == null)
            {
                minhaLista.Inicio = x;
                minhaLista.Fim = x;
            }
            else
            {
                x.Próx = minhaLista.Inicio;
                minhaLista.Inicio = x;
            }
        }

        for (int i = 1; i <= 3; i++)
        {
            Elemento x = new Elemento();

            Console.WriteLine($"Digiti o Nome{i}:");
            x.Nome = Console.ReadLine();

            if (minhaLista.Inicio == null)
            {
                minhaLista.Inicio = x;
                minhaLista.Fim = x;
            }
            else
            {
                minhaLista.Fim.Próx = x;
                minhaLista.Fim = x;
            }
        }
    }
}