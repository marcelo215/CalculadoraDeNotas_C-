using System;

class Program
{
    const double MEDIA_APROVACAO = 7.0;
    const double MEDIA_RECUPERACAO = 5.0;

    static string nomeAluno = "";
    static double[] notas = new double[3];
    static bool notasLancadas = false;

    static void Main()
    {
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n1 - Cadastrar aluno");
            Console.WriteLine("2 - Lançar notas");
            Console.WriteLine("3 - Calcular média");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida! Digite um número.");
                continue;
            }

            if (opcao == 1)
                CadastrarAluno();
            else if (opcao == 2)
                LancarNotas();
            else if (opcao == 3)
                CalcularMedia();
            else if (opcao == 4)
                Console.WriteLine("Saindo...");
            else
                Console.WriteLine("Opção inválida! Escolha de 1 a 4.");
        }
    }

    static void CadastrarAluno()
    {
        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome inválido!");
            return;
        }

        nomeAluno = nome;
        Console.WriteLine("Aluno cadastrado!");
    }

    static void LancarNotas()
    {
        if (nomeAluno == "")
        {
            Console.WriteLine("Cadastre o aluno primeiro (opção 1).");
            return;
        }

        for (int i = 0; i < 3; i++)
        {
            double nota;

            Console.Write($"Digite a nota {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
            {
                Console.Write("Nota inválida! Digite um valor de 0 a 10: ");
            }

            notas[i] = nota;
        }

        notasLancadas = true;
        Console.WriteLine("Notas lançadas!");
    }

    static void CalcularMedia()
    {
        if (nomeAluno == "" || !notasLancadas)
        {
            Console.WriteLine("Cadastre o aluno e lance as notas primeiro.");
            return;
        }

        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }

        double media = soma / notas.Length;

        Console.WriteLine($"Aluno: {nomeAluno}");
        Console.WriteLine($"Média: {media:F2}");
        ExibirSituacao(media);
    }

    static void ExibirSituacao(double media)
    {
        string situacao = media switch
        {
            >= MEDIA_APROVACAO => "Aprovado",
            >= MEDIA_RECUPERACAO => "Recuperação",
            _ => "Reprovado"
        };

        Console.WriteLine($"Situação: {situacao}");
    }
}   