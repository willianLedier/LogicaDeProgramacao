using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LogicaDeProgramacao
{
    public class EstruturaRepeticao
    {

        #region ////////////// WHILE //////////////////

        /// <summary>
        /// Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
        /// incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
        /// impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
        /// </summary>
        public static void ValidarSenha()
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }

        /// <summary>
        /// Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
        /// cartesiano.Para cada ponto escrever o quadrante a que ele pertence.O algoritmo será encerrado quando pelo
        /// menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
        /// </summary>
        public static void LocalizarQuadrante()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else
                {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            }

        }

        /// <summary>
        /// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
        /// um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
        /// 4.Fim). Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
        /// que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
        /// mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.
        /// </summary>
        public static void ValidarPreferencia()
        {

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool = alcool + 1;
                }
                else if (tipo == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3)
                {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }

        #endregion

        #region ////////////// FOR /////////////////

        /// <summary>
        /// Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
        /// </summary>
        public static void ExtrairImpares()
        {

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
        /// Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando
        /// essas informações conforme exemplo(use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
        /// </summary>
        public static void ExibirValoresIntervalo()
        {

            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in = cont_in + 1;
                }
                else
                {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

        }

        /// <summary>
        /// Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
        /// de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
        /// conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
        /// </summary>
        public static void CalcularMediaPonderada()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }

        }

        /// <summary>
        /// Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
        /// segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
        /// </summary>
        public static void ValidarDivisao()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
                }
            }
        }

        /// <summary>
        /// Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
        /// Lembrando que, por definição, fatorial de 0 é 1.
        /// </summary>
        public static void CalcularFatorial()
        {

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);

        }

        /// <summary>
        /// Ler um número inteiro N e calcular todos os seus divisores.
        /// </summary>
        public static void CalcularDivisores()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
        /// começando de 1 até N.Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.
        /// </summary>
        public static void CalcularPotencia()
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }

        }

        #endregion

    }
}

