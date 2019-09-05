using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExemploTeste
{
    public class Opcoes
    {
        List<Alunos> cadastrados = new List<Alunos>();
        public void Cadastro()
        {
            Console.WriteLine("Insira o Nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Insira a Matricula");
            var matricula =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a data de Nasc");
            var datadeNasc = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("pt-BR"));

            Console.WriteLine("Insira a Disciplina");
            var disciplina = Console.ReadLine();

            Console.WriteLine("Insira o numero de ausencias");
            var ausencia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a nota");
            var nota = Convert.ToInt32(Console.ReadLine());

            var aluno = new Alunos(nome, matricula, datadeNasc, disciplina, ausencia);
            cadastrados.Add(aluno);
        }

        public void ListarCadastros()
        {
            foreach (var item in cadastrados)
            {
                Console.WriteLine($"O nome do aluno é {item.Nome}, sua matricula é {item.Matricula}, " +
                    $"Sua Data de nascimento é {item.DatadeNasc}, Sua disciplina é {item.Disciplina}, Seu numero de ausencias {item.Ausencia} e sua Nota final é {item.Nota}");
                Console.ReadLine();
            }
        }

        public void Edicao()
        {
            foreach (var item in cadastrados)
            {
                Console.WriteLine($"O nome do aluno é {item.Nome}, sua matricula é {item.Matricula}, " +
                    $"Sua Data de nascimento é {item.DatadeNasc}, Sua disciplina é {item.Disciplina}, Seu numero de ausencias {item.Ausencia} e sua Nota final é {item.Nota}");
            }

            Console.WriteLine("Informe a Matricula do Aluno que voce deseja editar:");
            var mInformada = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            foreach (var item in cadastrados)
            {
                if (mInformada == item.Matricula)
                {
                    Console.WriteLine($"O nome do aluno é {item.Nome}, sua matricula é {item.Matricula}, " +
                     $"Sua Data de nascimento é {item.DatadeNasc}, Sua disciplina é {item.Disciplina}, Seu numero de ausencias {item.Ausencia} e sua Nota final é {item.Nota}");

                    Console.WriteLine("Insira o Nome");
                    var novoNome = Console.ReadLine();
                    item.Nome = novoNome;

                    Console.WriteLine("Insira a Disciplina");
                    var novaDisciplina = Console.ReadLine();
                    item.Disciplina = novaDisciplina;

                    Console.WriteLine("Insira as ausencias");
                    var novasAusencias = Console.ReadLine();
                    item.Ausencia = Convert.ToInt32(novasAusencias);

                    Console.WriteLine("Insira as Notas");
                    var novaNota = Console.ReadLine();
                    item.Nota = Convert.ToInt32(novaNota);
                }
            }
        }   
        public void Deletar()
        {
            Console.WriteLine("Informe a Matricula do Aluno:");
            var mInformada = Convert.ToInt32(Console.ReadLine());

            foreach (var item in cadastrados)
            {
                if (mInformada == item.Matricula)
                {
                    Console.WriteLine("Você tem certeza que quer apagar?");
                    var confirmacao = Console.ReadLine();

                    if (confirmacao == "sim")
                    {
                        cadastrados.Remove(item);
                    }
                }
            }
        }
    }
}
