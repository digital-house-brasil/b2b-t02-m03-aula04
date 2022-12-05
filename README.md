![](./digital-house-header.png)

# Exercícios de Variáveis e Condicionais


### Fatorial
  > Faça um função que receba um número e imprima o seu fatorial. O programa deve receber um número e imprimir o seu fatorial.

  > Exemplo:

  > Entrada: 5

  > Saída:

  > 5! = 120

  > A fórmula: 

  > $$ 5! = 5*4*3*2*1 = 120 $$
-----------------------------------------------------------------------------------------------
### Cálculo do IMC
  > Faça um função que receba uma altura e peso de uma pessoa e calcule seu IMC. O programa deve receber uma altura e peso e imprimir o seu IMC e sua classificação. As classificações são:  

  - Abaixo do peso: Abaixo do peso (IMC abaixo de 18,5)
  - Peso normal: Peso normal (IMC entre 18,5 e 24,9)
  - Sobrepeso: Sobrepeso (IMC entre 25 e 29,9)
  - Obesidade grau I: Obesidade grau I (IMC entre 30 e 34,9)
  - Obesidade grau II: Obesidade grau II (IMC entre 35 e 39,9)
  - Obesidade grau III: Obesidade grau III (IMC acima de 40)
  
  > Exemplo:
  > Entrada: 1.75 e 80
  > Saída:
  > Seu IMC é: 24.5
  > Você está com peso normal.

  > A fórmula é: 

  > $$ imc = peso/(altura^2) $$
-----------------------------------------------------------------------------------------------    
### Derrapagem na frenagem
  > O Tesla Model X é um carro autônomo que consegue dirigir sozinho. Para evitar acidentes, o carro deve ser capaz de calcular qual a distância que ele percorrerá, ao iniciar o processo de frenagem, até parar.

  >Você acabou de ser contratado(a) como desenvolver(a) de software na Tesla. Sua primeira tarefa é fazer um programa capaz de calcular essa distância. A fórmula para o cálculo é a seguinte:

  > $$distancia = \frac{- velocidade^2}{2*aceleracao}$$

  > Seu programa sempre receberá como entrada a a velocidade e a aceleração e deverá imprimir na tela a distância percorrida pelo carro até parar.

  > Você acabou de ser contratado(a) como desenvolver(a) de software na Tesla. Sua primeira tarefa é fazer um programa capaz de calcular essa distância. A fórmula para o cálculo é a seguinte:

  > Seu programa sempre receberá como entrada a a velocidade e a aceleração e deverá imprimir na tela a distância percorrida pelo carro até parar.

  > `input`
  > A entrada será sempre composta por dois números inteiros:  a velocidade e a aceleração.

  > output
  > A saída deverá ser sempre um número representando a distância percorrida pelo carro ao longo da frenagem.

  > Exemplo de entrada:
  > Sample Input 

  ```20 -2```

  > Sample Output 

  ```100.0```
-----------------------------------------------------------------------------------------------
### Cálculo da Parcela
  > Um novo banco abriu em seu estado e liberou a fórmula que ele utiliza para calcular o valor da parcela de um tipo de empréstimo.

  > A fórmula precisa de 3 dados, o valor do empréstimo, seu score no Serasa e em quantos meses a pessoa pretende pagar.

  > $$ parcela = \frac{valorEmprestimo + (valorEmprestimo * juros)}{mesesParaPagar} $$

  > Existem 3 faixas de juros que as pessoas se encaixam dependendo de seu score no Serasa:
  > - 1ª faixa (Score menor que 300), juros = 3%;<br/>
  > - 2ª faixa (Score menor que 700), juros = 9%;<br/>
  > - 3ª faixa (Score maior ou igual a 700), juros = 15%;<br/>

  > Um amigo seu viu isso como uma forma de empreender e decidiu criar um aplicativo que calcula o valor da parcela. Para fazer isso ele pediu a sua ajuda.

  > Seu programa receberá sempre como entrada os ganhos da pessoa, seu score no Serasa e em quantos meses a pessoa pagará e deverá imprimir na tela o valor da parcela.

  > input A entrada será sempre três números: 
  > - os ganhos da pessoa
  > - seu score no Serasa
  > - em quantos meses a pessoa pagará.

  > output
  > A saída deverá ser sempre um número representando o valor da parcela.

  > Exemplo de entrada:
  > Sample Input 

  ```5000 80 10```

  > Sample Output 

  ```515.0```
-----------------------------------------------------------------------------------------------
### Calculadora Simples
  > Você deverá construir uma calculadora simples, que ao receber dois números e um operador, exibe o resultado da operação.

  > input:
  > Duas variáveis `double` e um operador `String`

  > constraints:
  > 1. Operadores possíveis: `+`, `-`, `*`, `/`, onde o operador `+` é o `default`.
  > 2. Não exibir `0`s desnecessários, por exemplo, se o resultado da operação for `2`, não exibir `2.00000`, mas sim `2`.

  > output:
  > Um número com no máximo 5 casas decimais. 

  > Exemplo de entrada:
  > Sample Input 

  ```2.2 + 4.6```

  > Sample Output 

  ```6.8```

