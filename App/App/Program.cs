using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args) {

            

            void Fatorial() {
                int Fat(int n) {
                    if (n == 1) {
                        return n;
                    }
                    return n * Fat(n - 1);
                }
                Console.WriteLine("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                int resultado = Fat(numero);
                Console.WriteLine("O Fatorial de " + numero + " é " + resultado);
            }
            //Fatorial();   

            void IMC() {
                Console.WriteLine("Digite sua altura: ");
                double altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu peso:");
                double peso = double.Parse(Console.ReadLine());

                double imc = peso / Math.Pow(altura, 2);

                //baixo do peso: Abaixo do peso(IMC abaixo de 18, 5)
                //Peso normal: Peso normal(IMC entre 18,5 e 24,9)
                //Sobrepeso: Sobrepeso(IMC entre 25 e 29, 9)
                //Obesidade grau I: Obesidade grau I(IMC entre 30 e 34, 9)
                //Obesidade grau II: Obesidade grau II(IMC entre 35 e 39, 9)
                //Obesidade grau III: Obesidade grau III(IMC acima de 40)
                if (imc < 18.5) {
                    Console.WriteLine("Abaixo do peso");
                } else if (imc < 24.9) {
                    Console.WriteLine("Peso normal");
                } else if (imc < 29.9) {
                    Console.WriteLine("Sobrepeso");
                } else if (imc < 34.9) {
                    Console.WriteLine("Obesidade grau I");
                } else if (imc < 39.9) {
                    Console.WriteLine("Obesidade grau II");
                } else {
                    Console.WriteLine("Obesidade grau III");
                }
                Console.ReadKey();
            }
            //IMC();

            void DerrapagemNaFrenagem() {
                Console.WriteLine("Digite a velocidade: ");
                double velocidade = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a aceleração: ");
                double aceleracao = double.Parse(Console.ReadLine());

                double distancia = -(Math.Pow(velocidade, 2)) / (2 * aceleracao);

                Console.WriteLine("A distância pecorrida é: " + distancia);
                Console.ReadKey();
            }
            //DerrapagemNaFrenagem();

            void CalculoDaParcela() {
                double juros = 0.03;
                Console.WriteLine("As parcelas ficarão: " + juros);
                Console.WriteLine("Digite o valor do empréstimo: ");
                double emprestimo = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu Score do Serasa: ");
                int score = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite os meses para pagamento: ");
                int meses = int.Parse(Console.ReadLine());

                
                if (score < 300) {
                    juros = 0.03;
                } else if (score < 700) {
                    juros = 0.09;
                } else {
                    juros = 0.15;
                }
                double parcelas = (emprestimo + (emprestimo * juros)) / meses;

                Console.WriteLine("As parcelas ficarão: " + parcelas);
                Console.ReadKey();
            }
            //CalculoDaParcela();

            void CalculadoraSimples() {
                Console.WriteLine("Digite o 1º número: ");
                int numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o 2º número: ");
                int numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o operador aritmético: ");
                string op = Console.ReadLine();

                if (op == "+") {
                    Console.WriteLine("A soma é " + (numero1 + numero2));
                } else if (op == "-") {
                    Console.WriteLine("A subtração é " + (numero1 - numero2));
                } else if (op == "/") {
                    Console.WriteLine("A divisão é " + (numero1 / numero2));
                } else if (op == "*") {
                    Console.WriteLine("A mult é " + (numero1 * numero2));
                }
                Console.ReadKey();
            }
            //CalculadoraSimples();
        }
    }
}
