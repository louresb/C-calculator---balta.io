using System;

namespace Calculator
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Potência");
            Console.WriteLine("6 - Raiz Quadrada");
            Console.WriteLine("7 - Sair");

            Console.WriteLine("--------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Potencia(); break;
                case 6: RaizQuadrada(); break;
                case 7: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 + v2;

                Console.WriteLine($"O resultado da soma é {resultado}");
                Console.ReadKey();
                Menu();
            }

        static void Subtracao()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 - v2;

                Console.WriteLine($"O resultado da subtração é {resultado}");
                Console.ReadKey();
                Menu();
            }

        static void Divisao()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 / v2;

                Console.WriteLine($"O resultado da divisão é {resultado}");
                Console.ReadKey();
                Menu();
            }

        static void Multiplicacao()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                float resultado = v1 * v2;

                Console.WriteLine($"O resultado da multiplicação é {resultado}");
                Console.ReadKey();
                Menu();
            }
        static void Potencia()
            {
                Console.Clear();

                Console.WriteLine("Primeiro valor: ");
                int v1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                int v2 = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                double resultado = Math.Pow(v1, v2);

                Console.WriteLine($"O resultado da potência é {resultado}");
                Console.ReadKey();
                Menu();
            }

        static void RaizQuadrada()
            {
                Console.Clear();

                Console.WriteLine("Raiz Quadrada: ");
                int v1 = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                double resultado = Math.Sqrt(v1);

                Console.WriteLine($"A raiz quadrada é {resultado}");
                Console.ReadKey();
                Menu();
            }
        }
}
