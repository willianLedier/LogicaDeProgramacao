using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LogicaDeProgramacao
{
    public class EstruturaCondicional
    {

        /// <summary>
        /// Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não
        /// </summary>
        public static void ValidarNumeroNegativo()
        {
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
        }

        /// <summary>
        /// Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar
        /// </summary>
        public static void ValidarNumeroParImpar()
        {
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }

        }

        /// <summary>
        /// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
        /// Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
        /// ordem crescente ou decrescente.
        /// </summary>
        public static void ValidarMultiplos()
        {

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }

        }

        /// <summary>
        /// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
        /// começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
        /// </summary>
        public static void CalcularPeriodo()
        {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

        }

        /// <summary>
        /// Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
        /// seguir, calcule e mostre o valor da conta a pagar.
        /// </summary>
        public static void CalcularContaPagar()
        {

            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        }

        /// <summary>
        /// Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
        /// seguintes intervalos([0,25], (25,50], (50,75], (75,100]) este valor se encontra.Obviamente se o valor não estiver em
        /// nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
        /// </summary>
        public static void ValidarIntervalo()
        {

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

        }

        /// <summary>
        /// Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
        /// de um ponto em um plano.A seguir, determine qual o quadrante ao qual pertence o
        /// ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
        /// Se o ponto estiver na origem, escreva a mensagem “Origem”.
        /// Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
        /// </summary>
        public static void CalcularQuadrante()
        {

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }

        /// <summary>
        /// Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
        /// que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
        /// qualquer desvio.A moeda deste país é o Rombus, cujo símbolo é o R$.
        /// Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
        /// mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
        /// 
        /// Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
        /// salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.No exemplo fornecido (abaixo), a taxa é
        /// de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
        /// duas casas decimais.
        /// </summary>
        public static void CalcularImposto()
        {
           
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }

        }

    }

}
