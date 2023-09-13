using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pequenaCalculadora
{
    class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, RaizQuadrada, Sair } //inclui o número 1 para o programa saber q começa com 1 o menu.

        static void Main(string[] args)
        {
            //Realizando um loop para que o programa não encerre após a seleção do menu
            bool escolheuSair = false;
            while (!escolheuSair) //Se colocar uma esclamação antes da condição, a condição é invertida. Agr a condição é verdadeira
            {
                //Enquando o usuário NÂO escolher sair exiba menu
                Console.WriteLine("Seja bem vindo a calculadora!");
                Console.WriteLine("\nSelecione uma das opções: ");
                Console.WriteLine(" 1-Soma\n 2-Subtracao\n 3-Divisao\n 4-Multiplicacao\n 5-Potencia\n 6-Raiz Quadrada\n 7-Sair\n");


                Menu opcao = (Menu)int.Parse(Console.ReadLine()); //Para formatar o retorno que seria uma string para Inteiro. Usando cash explicitamente

                /*
                outra forma menos verbosa para converter:
                string opcaotxt = console.readline();      //pega o que o usuario digitar.
                int opcaoint = int.parse(opcaotxt);       //converte o retorno para inteiro.
                menu opcao = (menu)opcaoint;             //faz a conversão passar para o menu explicitamente.
                */

                //para fazer o programa finalizar após escolher a opção de sair
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.RaizQuadrada:
                        RaizQuadrada();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }


                Console.Clear();            //Para limparar o console.
            }

        }

        static void Soma()
        {
            Console.WriteLine("Calculando a soma de dois números");
            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());
            int soma = primeiroNumero + segundoNumero;
            Console.WriteLine($"Resultado: {soma}"); //Usando interporlação
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números");
            Console.WriteLine("Digite primeiro número: ");
            int primeiroNumeroSub = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumeroSub = int.Parse(Console.ReadLine());
            int subtracao = primeiroNumeroSub - segundoNumeroSub;
            Console.WriteLine($"Resultado: {subtracao}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("Digite primeiro número: ");
            int primeiroNumeroDiv = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumeroDiv = int.Parse(Console.ReadLine());
            float divisao = (float)primeiroNumeroDiv / (float)segundoNumeroDiv;  //Conversão para floate devido o resultado pode ser decimal
            Console.WriteLine($"Resultado: {divisao}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicacao de dois números");
            Console.WriteLine("Digite primeiro número: ");
            int primeiroNumeroMult = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int segundoNumeroMult = int.Parse(Console.ReadLine());
            int multiplicacao = primeiroNumeroMult * segundoNumeroMult;
            Console.WriteLine($"Resultado: {multiplicacao}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potencia de um números");
            Console.WriteLine("Digite primeiro a base: ");
            int primeiroBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int segundoExpoente = int.Parse(Console.ReadLine());
            double potencia = Math.Pow(primeiroBase, segundoExpoente);  //biblioteca Math para calcular algumas expressões aritmetica
            Console.WriteLine($"Resultado: {potencia}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }

        static void RaizQuadrada()
        {
            Console.WriteLine("Raiz de um números");
            Console.WriteLine("Digite o número: ");
            int primeiroNumeroRaiz = int.Parse(Console.ReadLine());
            double raiz = Math.Sqrt(primeiroNumeroRaiz);
            Console.WriteLine($"Resultado: {raiz}");
            Console.WriteLine("Pressione ENTER para voltar ao menu");
            Console.ReadLine();
        }
    }
}
