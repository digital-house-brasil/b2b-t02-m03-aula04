using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Questao1(){
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                int valor = 1;
                Console.WriteLine("O fatorial do valor é: ");

                for (int i = numero; i > 0; i--)
                {
                    valor = i * valor;
                    if (i == 1)
                    {
                        Console.WriteLine(i + " = " + valor);
                    }
                    else
                    {
                        Console.WriteLine(i + " * ");
                    }
                }
            }

            void Questao2()
            {
                Console.WriteLine("Digite o valor do peso: ");
                double peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor do altura: ");
                double altura = double.Parse(Console.ReadLine());

                double imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    Console.WriteLine("Peso normal");
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    Console.WriteLine("Sobrepeso");
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    Console.WriteLine("Obesidade grau I");
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    Console.WriteLine("Obesidade grau II");
                }
                else if (imc > 40)
                {
                    Console.WriteLine("Obesidade grau III");
                }
            }

            void Questao3()
            {
                Console.WriteLine("Digite o valor da velocidade ");
                int velocidade = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor da aceleração: ");
                int aceleracao = double.Parse(Console.ReadLine());

                double distancia = ((-1 * velocidade) * (-1 * velocidade))/(aceleracao * aceleracao);

                Console.WriteLine("A distância percorrida foi: " + distancia + " Km");
            }

            void Questao4() 
            {
                Console.WriteLine("Digite o valor do empréstimo: ");
                double emprestimo = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o seu score no Serasa: ");
                double score = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de meses: ");
                int meses = int.Parse(Console.ReadLine());

                double juros = 0;
                if (score < 300)
                {
                    juros = 0.03;
                }
                else if (score >= 300 && score <700)
                {
                    juros = 0.09;
                }
                else if (score >= 700)
                {
                    juros = 0.15;
                }
                double parcela = (emprestimo + (emprestimo * juros)) / meses;

                Console.WriteLine("O valor da parcela do empréstimo será de: ");
            }
            void Questao5()
            {
                Console.WriteLine("Digite o primeiro valor: ");
                double n1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a operação desejada( + | - | * | / |): ");
                string operacao = Console.ReadLine();
            
                if (operacao == "+")
                {
                    Console.WriteLine(n1 + " + " + " = " + (n1 + n2));
                }
                else if (operacao == "-")
                {
                    Console.WriteLine(n1 + " - " + " = " + (n1 - n2));
                }
                else if (operacao == "*")
                {
                    Console.WriteLine(n1 + " * " + " = " + (n1 * n2));
                }
                else if (operacao == "/")
                {
                    Console.WriteLine(n1 + " / " + " = " + (n1 / n2));
                }
            }


            Questao1();
            Questao2();
            Questao3();
            Questao4();
            Questao5();
        }
    }
}
