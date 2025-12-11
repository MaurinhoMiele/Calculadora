Menu();
Soma();
Subtracao();
Divisao();
Multiplicacao();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Boas vindas a calculadora! oq você precisa?");
    Console.WriteLine("1-Soma");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Divisão");
    Console.WriteLine("4-Multiplicação");
    Console.WriteLine("5-Sair");
    Console.WriteLine("");

    Console.Write("Selecione uma opção: ");
    int resultado = int.Parse(Console.ReadLine()!);

    switch (resultado)
    {
        case 1:Soma();
            break;
        case 2:Subtracao();
            break;
        case 3:Divisao();
            break;
        case 4:Multiplicacao();
            break;
        case 5:System.Environment.Exit(0);
            break;
        default:Menu();
            break;

    }
}
static void Soma()
{
    Console.Clear();

    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("\nSegundo valor: ");
    float v2 = float.Parse(Console.ReadLine()!);
    Console.WriteLine("");
    float resultado = v1 + v2;
    //Console.WriteLine($"O resultado da soma é {resultado}");
    Console.WriteLine($"O resultado da soma é " + resultado);
    //Console.WriteLine($"O resultado da soma é {v1 + v2}");
    //Console.WriteLine("O resultado da soma é " + (v1 + v2));
    Console.WriteLine("Digite qualquer tecla para sair");
    Console.ReadKey();
    Menu();
}

static void Subtracao()
{
    Console.Clear();

    Console.Write("Primeiro número: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("Segundo número: ");
    float v2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.WriteLine("Digite qualquer tecla para sair!");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.Write("Primeiro número: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("Segundo número: ");
    float v2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = v1 / v2;

    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.WriteLine("Digite qualquer tecla para sair!");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();

    Console.Write("Primeiro número: ");
    float v1 = float.Parse(Console.ReadLine()!);

    Console.Write("Segundo número: ");
    float v2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");

    Console.WriteLine("Digite qualquer tecla para sair! ");
    Console.ReadKey();
    Menu();
}

 


