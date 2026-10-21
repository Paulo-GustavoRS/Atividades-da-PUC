using System.Collections;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class Lista
{
    private int[] vetor;
    private int Pos;

    public Lista(int Tam)
    {
        vetor = new int[Tam];
    }

    public bool InseriInicio(int x)
    {
        if (Pos < vetor.Length)
        {
            for (int i = Pos; i > 0; i--)
            {
                vetor[i] = vetor[i - 1];
            }
            vetor[0] = x;

            Pos++;
            return true;

        }

        else
        {
            return false;
        }
    }




    public bool InseriFim(int x)
    {
        if (Pos < vetor.Length)
        {
            vetor[Pos] = x;

            Pos++;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool InseriPosição(int x, int indice)
    {
        if (Pos >= vetor.Length || indice < 0 || indice > Pos)
        {
            return false;
        }
        else
        {
            for (int i = Pos; i > indice; i--)
            {
                vetor[i] = vetor[i - 1];
            }

            vetor[indice] = x;
            Pos++;
            return true;
        }
    }
    public bool removerInicio()
    {
        if (Pos != 0)
        {
            Pos--;
            for (int i = 0; i < Pos; i++)
            {
                vetor[i] = vetor[i + 1];
            }

            return true;
        }
        else
        {
            return false;
        }
    }
    public bool removerFim()
    {
        if (Pos != 0)
        {
            Pos--;

            return true;
        }
        else
        {
            return false;
        }
    }

    public void MostraLista()
    {
        Console.Clear();

        for (int i = 0; i < Pos; i--)
        {
            Console.Write($"{vetor[i],7}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Lista minhaLista = new Lista(10);

        minhaLista.InseriInicio(3);
        minhaLista.InseriInicio(7);

        minhaLista.InseriFim(4);
        minhaLista.InseriFim(9);

       if( minhaLista.InseriPosição(999, 2))
       { 
         Console.WriteLine("valo iserido");
       }

        minhaLista.MostraLista();

        minhaLista.removerInicio();
        // Removed incomplete statement
    }
}