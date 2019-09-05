using System;

namespace ExemploTeste
{
    public class Alunos 
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public DateTime DatadeNasc { get; set; }
        public string Disciplina { get; set; }
        public int Ausencia { get; set; }
        public double Nota { get; set; }

        public Alunos(string nome, int numeroDaMatricula, DateTime datadeNasc, string disciplina, int ausencia)
        {
            Nome = nome;
            Matricula = numeroDaMatricula;
            DatadeNasc = datadeNasc;
            Disciplina = disciplina;
            Ausencia = ausencia;
        }

        public int GetIdade()
        {
            return DateTime.Today.Year - DatadeNasc.Year;
        }


    }
}
