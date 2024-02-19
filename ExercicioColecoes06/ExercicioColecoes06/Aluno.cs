using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioColecoes06
{
    internal class Aluno
    {
        string[] alunos = new string[10];
        public string this[int i]
        {
            get
            {
                if (i >= 0 && i < alunos.Length)
                {

                    return alunos[i];

                }
                return "Erro";
            }
            set
            {
                if (i > 0 && i < alunos.Length)
                {
                    alunos[i] = value;
                }
            }
        }
    }
}
