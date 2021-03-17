using System;
using System.Globalization;

namespace ExercicioUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex6();
        }

        public static void Ex1()
        {
            int a, b, result;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int soma = a + b;
            result = soma;

            Console.WriteLine("SOMA = " + result);
        }

        public static void Ex2()
        {
            double raio = double.Parse(Console.ReadLine());

            double pi = 3.14159;

            double areea = pi * (2 * raio);

            Console.WriteLine("A = " + areea.ToString("F4", CultureInfo.InvariantCulture));
        }

        public static void Ex3()
        {
            int A, B, C, D;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            int dif = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + dif);
        }

        public static void Ex4()
        {
            int func, horas;
            double valor, salario;

            func = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valor;

            Console.WriteLine("NUMBER = " + func);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }

        public static void Ex5()
        {
            int cod1, cod2, quant1, quant2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');

            cod1 = int.Parse(valores[0]);
            quant1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            quant2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * quant1 + preco2 * quant2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Ex6()
        {
            double A, B, C, area, circulo, pi, trapezio, quadrado, retangulo;

            pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            area = A * C / 2;
            Console.WriteLine("TRIANGULO: " + area.ToString("F3", CultureInfo.InvariantCulture));

            circulo = pi * (C * C);

            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));

            trapezio = (A + B) * C / 2;

            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));

            quadrado = B * B;

            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));

            retangulo = A * B;

            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }

}
