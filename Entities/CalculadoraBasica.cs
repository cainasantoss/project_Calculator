namespace Calculator;
public static class CalculadoraBasica
{
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Qual operacao gostaria de fazer? ");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtracao");
        Console.WriteLine("3 - Divisao");
        Console.WriteLine("4 - Multiplicao");
        Console.WriteLine("5 - Raiz Quadrada");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Selecione uma opcao: ");
        short op = short.Parse(Console.ReadLine());

        switch (op)
        {
            case 0: Program.Menu(); break;
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: RaizQuadrada(); break;
            default: Menu(); break;
        }
    }
    static void Soma()
    {
        Console.Clear();
        Console.Write("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double result = v1 + v2;
        Console.WriteLine($"Resultado da Soma é {result}");
        Console.ReadKey();
        Menu();
    }

    static void Subtracao()
    {
        Console.Clear();
        Console.Write("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double result = v1 - v2;
        Console.WriteLine($"Resultado da Subtracão é {result}");
        Console.ReadKey();
        Menu();
    }

    static void Divisao()
    {
        Console.Clear();
        Console.Write("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double result = v1 / v2;
        Console.WriteLine($"Resultado da Divisão é {result}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();
        Console.Write("Primeiro Valor: ");
        double v1 = double.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        double v2 = double.Parse(Console.ReadLine());

        double result = v1 * v2;
        Console.WriteLine($"O Resultado da multiplicação é {result}");
        Console.ReadKey();
        Menu();
    }

    static void RaizQuadrada()
    {
        Console.Clear();
        Console.Write("Digite o Valor: ");
        double valor = double.Parse(Console.ReadLine());
        var result = Math.Sqrt(valor);

        Console.Write($"O Resultado da Raiz Quadrada é {result}");
        Console.ReadKey();
        Menu();
    }
}