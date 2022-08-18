using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LogicaDeProgramacao
{
    public static class EstruturaSequencial
    {

        /// <summary>
        /// Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
        /// mensagem explicativa, conforme exemplos.
        /// </summary>
        public static void SomarDoisValores()
        {

            int A, B, soma;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            soma = A + B;

            Console.WriteLine("SOMA = " + soma);

        }

        /// <summary>
        /// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
        /// casas decimais conforme exemplos.
        /// Fórmula da área: area = π.raio2
        /// Considere o valor de π = 3.14159
        /// </summary>
        public static void CalcularArea()
        {
            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
        /// de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A* B - C* D).
        /// </summary>
        public static void CalcularDiferencaProdutos()
        {
            int A, B, C, D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);
        }

        /// <summary>
        /// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
        /// hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
        /// </summary>
        public static void CalcularSalario()
        {

            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }

        /// <summary>
        /// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        /// código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
        /// </summary>
        public static void CalcularValorPagamento()
        {
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
        /// a) a área do triângulo retângulo que tem A por base e C por altura.
        /// b) a área do círculo de raio C. (pi = 3.14159)
        /// c) a área do trapézio que tem A e B por bases e C por altura.
        /// d) a área do quadrado que tem lado B.
        /// e) a área do retângulo que tem lados A e B
        /// </summary>
        public static void CalcularAreaFormas()
        {

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }

    }
}
