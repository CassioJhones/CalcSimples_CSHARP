namespace Calculator;

public static class CalculadoraMenu
{

    /// <summary>
    /// Exibe o menu inicial com as op��es
    /// </summary>
    public static void ExibirMenuPrincipal()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("CALCULADORA C#");
        Console.ResetColor();
        Console.WriteLine("[1] - SOMA");
        Console.WriteLine("[2] - SUBTRA��O");
        Console.WriteLine("[3] - DIVIS�O");
        Console.WriteLine("[4] - MULTIPLICA��O");
        Console.WriteLine("[5] - SAIR\n");
        Console.WriteLine("---------------------");
        Console.Write("Digite uma op��o: ");

        if (short.TryParse(Console.ReadLine(), out short resposta))
            ExecutarOpcao(resposta);

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Op��o inv�lida. Pressione uma tecla para continuar.");
            Console.ResetColor();
            Console.ReadKey();
            ExibirMenuPrincipal();
        }
    }
    private static void ExecutarOpcao(short opcao)
    {
        switch (opcao)
        {
            case 1: RealizarSoma(); break;
            case 2: RealizarSubtracao(); break;
            case 3: RealizarDivisao(); break;
            case 4: RealizarMultiplicacao(); break;
            case 5: Environment.Exit(0); break;
            default: ExibirMenuPrincipal(); break;
        }
    }
    static void RealizarSubtracao() => RealizarOperacao("SUBTRA��O", (a, b) => a - b);
    static void RealizarSoma() => RealizarOperacao("SOMA", (a, b) => a + b);
    static void RealizarDivisao() => RealizarOperacao("DIVISAO", (a, b) => a / b);
    static void RealizarMultiplicacao() => RealizarOperacao("MULTIPLICA��O", (a, b) => a * b);
    private static void RealizarOperacao(string operacao, Func<float, float, float> operacaoFunc)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n---{operacao.ToUpper()}---\n");
        Console.ResetColor();
        Console.Write("Primeiro Valor: ");

        if (float.TryParse(Console.ReadLine(), out float primeiroValor))
        {
            Console.Write("Segundo Valor: ");
            if (float.TryParse(Console.ReadLine(), out float segundoValor))
            {
                float resultado = operacaoFunc(primeiroValor, segundoValor);
                Console.WriteLine($"\nO resultado � {resultado}");
                Console.ReadKey();
                ExibirMenuPrincipal();
            }
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Valores inseridos inv�lidos. Pressione uma tecla para continuar.");
        Console.ResetColor();
        Console.ReadKey();
        ExibirMenuPrincipal();
    }


}
