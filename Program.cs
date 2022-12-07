
//Faça um função que receba um número e imprima o seu fatorial.
// O programa deve receber um número e imprimir o seu fatorial.
int Fat(int n){
    if(n == 1){
        return n;
    }
    return n * Fat(--n);
}
void fatorial(){
    Console.WriteLine("");
    Console.WriteLine("programa para imprimir fatorial");
    Console.Write("digite um numero: ");
    int n = int.Parse(Console.ReadLine());
    int resultado = Fat(n);
    Console.WriteLine("o fatorial de "+n+" é "+resultado);

} 

//fatorial();


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


/*Faça um função que receba uma altura e peso de uma pessoa
// e calcule seu IMC. O programa deve receber uma altura e peso
// e imprimir o seu IMC e sua classificação. As classificações são:

Abaixo do peso: Abaixo do peso (IMC abaixo de 18,5)
Peso normal: Peso normal (IMC entre 18,5 e 24,9)
Sobrepeso: Sobrepeso (IMC entre 25 e 29,9)
Obesidade grau I: Obesidade grau I (IMC entre 30 e 34,9)
Obesidade grau II: Obesidade grau II (IMC entre 35 e 39,9)
Obesidade grau III: Obesidade grau III (IMC acima de 40)
Exemplo: Entrada: 1.75 e 80 Saída: Seu IMC é: 24.5 Você está com peso normal.

A fórmula é:*/
void IMC(){
    Console.WriteLine("calculando IMC");
    Console.Write("digite sua altura: ");
    double altura = double.Parse(Console.ReadLine());
    Console.Write("digite seu peso: ");
    double peso = double.Parse(Console.ReadLine());
    Double imc = peso / Math.Pow(altura, 2);

    
    if (imc < 18.5){
        Console.WriteLine("seu imc é: "+imc.ToString("F1"));
        Console.WriteLine("Abaixo do peso (IMC abaixo de 18,5)");
    }
    else if (imc <= 24.9 ){
    Console.WriteLine("seu imc é: "+imc.ToString("F1"));
        Console.WriteLine("Peso normal (IMC entre 18,5 e 24,9)");
    }
    else if (imc <=29.9 ){
        Console.WriteLine("seu imc é: "+imc.ToString("F1"));
        Console.WriteLine("Sobrepeso (IMC entre 25 e 29,9)");
    }
    else if (imc <=34.9 ){
        Console.WriteLine("seu imc é: "+imc.ToString("F1"));
        Console.WriteLine("Obesidade grau I (IMC entre 30 e 34,9)");
    }
    else if (imc <=39.9){
        Console.WriteLine("seu imc é: "+imc.ToString("F1"));
        Console.WriteLine("Obesidade grau II (IMC entre 35 e 39,9)");
    }
    else {
        Console.WriteLine("seu imc é: "+imc.ToString("F1"));
        Console.WriteLine("Obesidade grau III (IMC acima de 40)");
    }
 
}
IMC();


///////////////////////////////////////////////////////////////////////////

/*Derrapagem na frenagem
O Tesla Model X é um carro autônomo que consegue dirigir sozinho. Para evitar acidentes, o
 carro deve ser capaz de calcular qual a distância que ele percorrerá, ao iniciar o processo de frenagem, até parar.

Você acabou de ser contratado(a) como desenvolver(a) de software na Tesla. Sua primeira tarefa é fazer
 um programa capaz de calcular essa distância. A fórmula para o cálculo é a seguinte:

 

Seu programa sempre receberá como entrada a a velocidade e a aceleração e deverá imprimir
 na tela a distância percorrida pelo carro até parar.

Você acabou de ser contratado(a) como desenvolver(a) de software na Tesla. Sua primeira
 tarefa é fazer um programa capaz de calcular essa distância. A fórmula para o cálculo é a seguinte:

Seu programa sempre receberá como entrada a a velocidade e a aceleração e deverá imprimir
 na tela a distância percorrida pelo carro até parar.

input A entrada será sempre composta por dois números inteiros: a velocidade e a aceleração.

output A saída deverá ser sempre um número representando a distância percorrida pelo carro ao longo da frenagem.

Exemplo de entrada: Sample Input

20 -2

Sample Output

100.0*/
void Distancia(){
    Console.Write("digite a velocidade: ");
    int velocidade = Convert.ToInt32(Console.ReadLine());
    Console.Write("digite a aceleração: ");
    int aceleracao = Convert.ToInt32(Console.ReadLine());
    int distancia = (-velocidade * -velocidade)/ (2 * aceleracao);
    Console.WriteLine("a distancia é "+distancia);

}
//Distancia();
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*Cálculo da Parcela
Um novo banco abriu em seu estado e liberou a fórmula que ele utiliza para calcular o valor da parcela de um tipo de empréstimo.

A fórmula precisa de 3 dados, o valor do empréstimo, seu score no Serasa e em quantos meses a pessoa pretende pagar.

 

Existem 3 faixas de juros que as pessoas se encaixam dependendo de seu score no Serasa:

1ª faixa (Score menor que 300), juros = 3%;
2ª faixa (Score menor que 700), juros = 9%;
3ª faixa (Score maior ou igual a 700), juros = 15%;
Um amigo seu viu isso como uma forma de empreender e decidiu criar um aplicativo que calcula o valor da parcela.
 Para fazer isso ele pediu a sua ajuda.

Seu programa receberá sempre como entrada os ganhos da pessoa, seu score no Serasa e em quantos meses a pessoa pagará e 
deverá imprimir na tela o valor da parcela.

input A entrada será sempre três números:

os ganhos da pessoa
seu score no Serasa
em quantos meses a pessoa pagará.
output A saída deverá ser sempre um número representando o valor da parcela.

Exemplo de entrada: Sample Input

5000 80 10

Sample Output

515.0*/

void Parcela(){
    Console.WriteLine("vamos calcular sua parcela ?");
    Console.Write("digite quanto voce precisa: ");
    double emprestimo = double.Parse(Console.ReadLine());
    Console.Write("digite seu score na serasa: ");
    double score = double.Parse(Console.ReadLine());
    Console.Write("digite a quantidade de parcelas mensais: ");
    int meses = int.Parse(Console.ReadLine());
    double juros = 0;
    double parcela = 0;

    if(score < 300){
        juros = 0.03;
    }
    else if (score < 700){
        juros = 0.09;
    }
    else if (score >= 700){
        juros = 0.15;
    }
    else{
        Console.WriteLine("voce nao se encaixa na linha de financiamento");
    }

    parcela = (emprestimo+(emprestimo*juros))/meses;
    Console.WriteLine("emprestimo liberado,serão: "+meses+ " parcelas de : "+parcela.ToString("F1") +" reais"); 

}
//Parcela();
/*-Calculadora Simples
Você deverá construir uma calculadora simples, que ao receber dois números e um operador, exibe o resultado da operação.

input: Duas variáveis double e um operador String

constraints:

Operadores possíveis: +, -, *, /, onde o operador + é o default.
Não exibir 0s desnecessários, por exemplo, se o resultado da operação for 2, não exibir 2.00000, mas sim 2.
output: Um número com no máximo 5 casas decimais.

Exemplo de entrada: Sample Input

2.2 + 4.6

Sample Output

6.8*/
void CalculadoraSimples(){
    Console.Write("digite o primeiro numero: ");
    int n1 = Convert.ToInt16(Console.ReadLine());
    Console.Write("digite segundo numero: ");
    int n2 = Convert.ToInt16(Console.ReadLine());
    Console.Write("digite o operador aritmetico +, -, *, /,  ");
    string op = Console.ReadLine();

    if (op == "+"){
        Console.WriteLine("a soma é "+ (n1 + n2));
    }
    else if (op == "-"){
        Console.WriteLine("a subtraçao é "+ (n1 - n2));
    }
    else if (op == "*"){
        Console.WriteLine("a multiplicaçao é "+ (n1 * n2));
    }
    else if (op == "/"){
        Console.WriteLine("a divisao é "+ (n1 / n2));
    }
    else{
        Console.WriteLine("voce digitou operador invalido");

    }

}

//CalculadoraSimples();
Console.ReadKey();

