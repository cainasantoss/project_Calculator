namespace Calculator;

public static class CalculadoraArea
{
    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Qual operacao gostaria de fazer? ");
        Console.WriteLine("0 - Voltar");
        Console.WriteLine("1 - Area Triangulo");
        Console.WriteLine("2 - Area Quadrado");
        Console.WriteLine("3 - Area Retangulo");
        Console.WriteLine("4 - Area Circulo");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Selecione uma opcao: ");
        short op = short.Parse(Console.ReadLine());

        switch (op)
        {
            case 0: Program.Menu(); break;
            case 1: AreaTriangulo(); break;
            case 2: AreaQuadrado(); break;
            case 3: AreaRetangulo(); break;
            case 4: AreaCirculo(); break;
            default: Menu(); break;
        }

    }

    static void AreaCirculo()
    {
        Console.Clear();
        Console.Write("Qual o raio do circulo: ");
        double raio = double.Parse(Console.ReadLine());
        double area = (raio * raio) * Math.PI;
        Console.WriteLine($"A area do Circulo é {area}");
        Console.ReadKey();
        Menu();
    }
    static void AreaTriangulo()
    {
        Console.Clear();
        Console.Write("Qual Medida da base do triangulo: ");
        double bas = double.Parse(Console.ReadLine());
        Console.Write("Qual Medida da altura do triangulo: ");
        double alt = double.Parse(Console.ReadLine());

        double area = bas * alt / 2;
        Console.WriteLine($"A area do Triangulo é {area}");
        Console.ReadKey();
        Menu();
    }

    static void AreaQuadrado()
    {
        Console.Clear();
        Console.Write("Qual a medida do lado do quadrado: ");
        double lado = double.Parse(Console.ReadLine());
        double area = lado * lado;
        Console.WriteLine($"A area do Quadrado é {area}");
        Console.ReadKey();
        Menu();
    }

    static void AreaRetangulo()
    {
        Console.Clear();
        Console.Write("Qual Medida da base do triangulo: ");
        double bas = double.Parse(Console.ReadLine());
        Console.Write("Qual Medida da altura do triangulo: ");
        double alt = double.Parse(Console.ReadLine());

        double area = bas * alt;
        Console.WriteLine($"A area do Triangulo é {area}");
        Console.ReadKey();
        Menu();
    }
}