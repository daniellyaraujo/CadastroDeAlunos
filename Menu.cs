using ExemploTeste;
using System;

public class Menu
{
    public void CriarMenu()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de Alunos | Escola Mauá");
        Console.WriteLine("**********************************");
        Console.WriteLine("1 - Inserir o nome do Aluno");
        Console.WriteLine("2 - Ver Alunos cadastrados");
        Console.WriteLine("3 - Editar Aluno");
        Console.WriteLine("4 - Deletar Aluno");
        Console.WriteLine("**********************************");
        Console.WriteLine("5 - Sair");
    }

    public void SelecionarOpcao(string opcaoEscolhida, Opcoes opcoes)
    {
        switch (opcaoEscolhida)
        {
            case "1":
                opcoes.Cadastro();
                break;
            case "2":
                opcoes.ListarCadastros();
                break;
            case "3":
                opcoes.Edicao();
                break;
            case "4":
                opcoes.Deletar();
                break;
            case "5":
                Environment.Exit(0);
                break;
        }

        CriarMenu();
        opcaoEscolhida = Console.ReadLine();
        Console.Clear();
        SelecionarOpcao(opcaoEscolhida, opcoes);
    }
}