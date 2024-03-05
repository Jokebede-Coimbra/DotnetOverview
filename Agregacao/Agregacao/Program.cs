using Agregacao;

internal class Program
{
    private static void Main(string[] args)
    {
        Professor professor1 = new Professor("Jayanne", "Química");
        Professor professor2 = new Professor("Josué", "Matemática");
        Professor professor3 = new Professor("Samarah", "Inglês");
        Professor professor4 = new Professor("Jacson", "Literatura");

        Departamento dep1 = new Departamento("Exatas");
        dep1.IncluirProfessor(professor1);
        dep1.IncluirProfessor(professor2);
        dep1.ListaProfessores();

        Departamento dep2 = new Departamento("Humanas");
        dep2.IncluirProfessor(professor3);
        dep2.IncluirProfessor(professor4);
        dep2.ListaProfessores();




       
        
    }
}