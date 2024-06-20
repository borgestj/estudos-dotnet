using System.Globalization;

namespace ExercicioEstruturaSequencial
{
    class ExercicioEstruturaSequencial
    {
        static void Main(string[] args)
        {
            //Exercício 01

            //int a, b, soma;

            //Console.WriteLine("Exercício 01 - Soma de dois valores:");
            //Console.WriteLine("Digite o primeiro valor:");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor:");
            //b = int.Parse(Console.ReadLine());

            //soma = a + b;

            //Console.WriteLine();
            //Console.WriteLine("Soma = {0}", soma);

            //Exercício 02

            //double raio, area, pi = 3.14159;

            //Console.WriteLine("Exercício 02 - Raio de um círculo:");
            //Console.WriteLine("Digite o valor:");
            //raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = pi * raio * raio;

            //Console.WriteLine();
            //Console.WriteLine("A={0}", area.ToString("F4", CultureInfo.InvariantCulture));

            //Exercício 03

            //int A, B, C, D, diferenca;
            //Console.WriteLine("Exercício 03 - Diferença entre valores:");
            //Console.WriteLine("Digite o valor A:");
            //A = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor B:");
            //B = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor C:");
            //C = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o valor D:");
            //D = int.Parse(Console.ReadLine());

            //diferenca = ((A * B) - (C * D));

            //Console.WriteLine();
            //Console.WriteLine("Diferença: {0}", diferenca);

            //Exercício 04

            //int funcionarios, horasTrabalhadas;
            //double valorHora, salario;

            //Console.WriteLine("Exercício 04 - Cálculo de Salário:");
            //Console.WriteLine("Qual o número de funcionários:");
            //funcionarios = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o total de horas trabalhadas:");
            //horasTrabalhadas = int.Parse(Console.ReadLine());

            //Console.WriteLine("Qual o valor da hora dos funcionários:");
            //valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = horasTrabalhadas * valorHora;

            //Console.WriteLine();
            //Console.WriteLine("Number = {0}", funcionarios);
            //Console.WriteLine("Salary = U$ {0}", salario.ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 05

            //int codigoPeca1, codigoPeca2, numeroPeca1, numeroPeca2;
            //double valorPeca1, valorPeca2, total;

            //Console.WriteLine("Exercício 05 - Valor a pagar:");
            //Console.WriteLine("Dígite os dados do primeiro produto:");
            //string[] valores = Console.ReadLine().Split(' ');
            //codigoPeca1 = int.Parse(valores[0]);
            //numeroPeca1 = int.Parse(valores[1]);
            //valorPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //Console.WriteLine("Dígite os dados do segundo produto:");
            //valores = Console.ReadLine().Split(' ');
            //codigoPeca2 = int.Parse(valores[0]);
            //numeroPeca2 = int.Parse(valores[1]);
            //valorPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = (numeroPeca1 * valorPeca1) + (numeroPeca2 * valorPeca2);

            //Console.WriteLine("Valor a pagar: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 06

            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi = 3.14159;

            Console.WriteLine("Exercício 06 - Precisão:");
            Console.WriteLine("Dígite os valores a serem calculados:");
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = pi * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine();
            Console.WriteLine("Triângulo: {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Círculo: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
