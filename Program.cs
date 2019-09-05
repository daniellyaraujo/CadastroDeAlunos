using System;
using System.Collections.Generic;

namespace ExemploTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var opcoes = new Opcoes();
            string opcaoEscolhida;

            menu.CriarMenu();
            opcaoEscolhida = Console.ReadLine();
            Console.Clear();

            menu.SelecionarOpcao(opcaoEscolhida, opcoes);
        }
    }
}
