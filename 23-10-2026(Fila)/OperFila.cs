using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fila
{
    public class Funcionario
    {
        private string _Nome;
        
        private string _Depatamento;
        private int _Idade;
        private double _salario;

        public Funcionario(string Nome, string Departamento, int Idade, double salario)
        {
            _Nome = Nome;
            _Depatamento = Departamento;
            _Idade = Idade;
            _salario = salario;
        }

        public string Nome => _Nome;
        public int Idade => _Idade;
        public double Salario => _salario;
    }
    public class Elemento
    {
        public Funcionario Dado;
        public Elemento Prox;

        public Elemento()
        {
            Dado = null;
            Prox = null;
        }
    }

    public class Fila
    {
        private Elemento Início;              // Objeto Início da Fila
        private Elemento Fim;                 // Objeto Fim da Fila
        private Elemento Aux;                 // Objeto Auxiliar

        public int Tamanho;                   // Tamanho da Fila (Número de Elementos)

        public Fila()                         // Construtor da Classe
        {
            Início = null;
            Fim = null;
            Tamanho = 0;
        }

        // Função para inserir um elemento na Fila
        public void Inserir(Funcionario Pessoa)
        {
            Elemento Novo = new Elemento();     // Alocação Dinâmica - Novo elemento para a Fila

            Novo.Dado = Pessoa;                   // Insere o valor do elemento na Fila
            Novo.Prox = null;                   // e o endereço que ele aponta é nulo

            if (Início == null)                 // A lista está vazia? Então o elemento que está entrando é o primeiro da Pilha
            {
                Início = Novo;                  // O Início da Pilha aponta para esse elemento
                Fim = Novo;                     // e o Fim da Pilha também
            }
            else                                // A lista já possui elementos?
            {
                Fim.Prox = Novo;                // Aquele último que entrou aponta para o novo que está entrando
                Fim = Novo;                     // e o Fim da Pilha agora é o elemento que entrou
            }

            Tamanho++;                          // O elemento entrou na Fila
        }

        // Função para mostrar todos os elementos da Fila
        public void MostraFila()
        {
            Console.Clear();              // Limpa a tela

            if (Início == null)           // Se o Início é nulo, a Fila não tem elemento...
            {
                Console.WriteLine("A Fila não possui nenhum elemento!!! \n\n");
                Console.ReadKey();
            }
            else                          // Se a Fila tem pelo menos um elemento eles são mostrados do primeiro inserido até o último
            {
                Console.WriteLine("Elementos da Fila: {0}\n", Tamanho);

                Aux = Início;             // Pega o primeiro elemento

                while (Aux != null)       // Enquanto a Fila tiver elemento que aponta para outro
                {
                    Console.WriteLine("{0,5} {1,2} {2,3}", Aux.Dado.Nome, Aux.Dado.Idade, Aux.Dado.Salario);        // Mostra o elemento,
                    Aux = Aux.Prox;                             // aponta para o próximo elemento
                }                                               // e volta

                Console.ReadKey();
            }
        }

        //Função para retirar um elemento da Fila
        public void RetiraElemento()
        {
            Funcionario x = Início.Dado;                            // Variável que vai receber o elemento retirado da Fila
            Início = Início.Prox; 
            Tamanho --;                                      // O Início da Fila agora aponta para o próximo elemento
            Console.Clear();                        // Limpa a tela

            if (Início == null)                     // Se não tem elemento na Fila...
            {
                Console.WriteLine("A Fila não possui nenhum elemento!!! \n\n");        // Mostra
                Console.ReadKey();
            }
            else                                    // A Fila tem elemento - O elemento a retirar é o do final (o primeiro inserido)
            {
                x = Início.Dado;                     // Variável passada por referência que "pega" o número retirado da Fila
                Início = Início.Prox;               // É só indicar que o Início agora é o próximo elemento da Fila
                Tamanho--;                          // E a Fila diminui de tamanho

                Console.Write("Elemento {0} retirado da Fila\nTamanho da Fila: {1}\n\n", x, Tamanho);
                Console.ReadKey();
            }
        }

        //Função para esvaziar toda a Fila
        public void EsvaziarFila()
        {
            if (Início == null)                       // Se não tem elemento na Fila
            {
                Console.WriteLine("A Fila não possui nenhum elemento!!! \n\n");        // Mostra
                Console.ReadKey();
            }
            else                                      // A Fila contém elementos...
            {
                Início = null;                        // O Início da Fila não aponta para ninguém...
                Tamanho = 0;
            }
        }
    }
}
