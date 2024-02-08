using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaII
{
    internal class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                 new Aluno{Nome = "Maria", Nota = 8.75 },
                 new Aluno{Nome = "Amanda", Nota = 7.75},
                 new Aluno{Nome = "Raquel", Nota = 9.5},
                 new Aluno{Nome = "Miguel", Nota = 6.5},
                 new Aluno{Nome = "Paulo", Nota = 7.5},
                 new Aluno{Nome = "José", Nota = 8.5},
                 new Aluno{Nome = "Julia", Nota = 5.75},
                 new Aluno{Nome = "Pedro", Nota = 9.0}
            };

        return alunos;
        }
    }
}


