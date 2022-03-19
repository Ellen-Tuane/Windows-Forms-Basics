using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_score
{
    class student
    {
        private int matricula;
        private double score, notaProva1, notaProva2, notaTrabalho;
        private string nome;

        public int Matricula { get => matricula; set => matricula = value; }
        public double Score { get => score; set => score = value; }
        public double NotaProva1 { get => notaProva1; set => notaProva1 = value; }
        public double NotaProva2 { get => notaProva2; set => notaProva2 = value; }
        public double NotaTrabalho { get => notaTrabalho; set => notaTrabalho = value; }
        public string Nome { get => nome; set => nome = value; }

        public double Media(double notaProva1, double notaProva2, double notaTrabalho)
        {
            return ((2.5 * (notaProva1 + notaProva2) + (2 * notaTrabalho)) / 7);
        } 
    }
}
