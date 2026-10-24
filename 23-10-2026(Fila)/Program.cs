namespace Fila                                      // Estrutura de Dados do Tipo Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op;

            Fila MinhaFila = new Fila();            // Instância da Classe

            do
            {
                Console.Clear();

                Console.WriteLine("FILA");                                 // Menu de Opções
                Console.WriteLine("====\n");
                Console.WriteLine("Opções: \n");
                Console.WriteLine("1 - Inserir Funcionario na Fila");
                Console.WriteLine("2 - Mostrar os Funcionario da Fila");
                Console.WriteLine("3 - Remover Funcionario da Fila");
                Console.WriteLine("4 - Esvaziar a Fila");
                Console.WriteLine("5 - Sair\n");

                Console.Write("Digite sua Opção: ");
                Op = int.Parse(Console.ReadLine());

                if (Op == 1)                    // Inserir no Início da Fila
                {
                    Console.Clear();                // Limpa a Tela
                    Console.WriteLine("Nome:");                    // Valor a ser inserido
                    string nomE = Console.ReadLine();            // Limpa a Tela

                    Console.WriteLine("Idade: ");
                    int idade = int.Parse(Console.ReadLine());
 
                    Console.WriteLine("Departamento: ");
                    string Departamento = Console.ReadLine();

                    Console.WriteLine("Salário:");
                    double Pargamento = double.Parse(Console.ReadLine());

            
                    Funcionario func = new Funcionario(nomE, Departamento, idade, Pargamento);
                    MinhaFila.Inserir(func);

                    Console.WriteLine("\nElemento inserido na Fila... Tamanho: {0}\n\n", MinhaFila.Tamanho);
                    Console.ReadKey();
                }

                if (Op == 2)                    // Mostrar todos os elementos da Fila
                {
                    MinhaFila.MostraFila();
                }

                if (Op == 3)                            // Retirar um Elemento da Fila
                {
                    int x = 0;                          // Variável para "pegar" o elemento que sairá da Fila (o do topo da Fila)
                    
                    Console.Clear();                    // Limpa a Tela

                    MinhaFila.RetiraElemento();    // Chama o método passando a referência de x
                }

                if (Op == 4)                        // Esvaziar a Fila
                {
                    Console.Clear();                // Limpa a Tela

                    MinhaFila.EsvaziarFila();      // Chama o Método

                    Console.WriteLine("Fila Vazia! \n\n");
                    Console.ReadKey();
                }

            } while (Op != 5);
        }
    }
}
