namespace Calculator;
internal class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Oque gostaria de Calcular? ");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Operacões Basicas");
        Console.WriteLine("2 - Calcular Areas");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Selecione uma opcao: ");
        short op = short.Parse(Console.ReadLine());

        switch (op)
        {
            case 0: Environment.Exit(0); break;
            case 1: CalculadoraBasica.Menu(); break;
            case 2: CalculadoraArea.Menu(); break;
            default: Menu(); break;
        }
    }
}
