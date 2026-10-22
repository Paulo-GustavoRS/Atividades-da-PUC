class Program
{
    struct Funcionario
    {
        public string nome;
        public DataDNasc DataDNasc;
        public double salario;
      
    }

    struct DataDNasc
    {
        public string dia;
        public string Mês;
    }
    static void Main()
    {
        Funcionario[] Fs = new Funcionario[3];

        for(int I=0; I< Fs.Length; I++)
        {
             Console.WriteLine("nome do funcionario:");
         Fs[I].nome = Console.ReadLine();

         Console.WriteLine("\nData de nacimento - Dia:");
         Fs[I].DataDNasc.dia = Console.ReadLine();

         Console.WriteLine("Mês:");
         Fs[I].DataDNasc.Mês = Console.ReadLine();

         Console.WriteLine("\nSalario:");
         Fs[I].salario = double.Parse(Console.ReadLine())        ;


        }

        Console.Clear();

        for(int I=0; I < Fs.Length; I++)
        {
            Console.WriteLine($"Nome do funcionario: {Fs[I].nome} Nacido:{Fs[I].DataDNasc} salario:{Fs[I].salario}");

        }

       

    }
}