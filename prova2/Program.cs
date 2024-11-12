using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();

           
            var aluno1 = new Aluno { Nome = "Igor Martins", Matricula = "123456", Idade = 20 };
            var aluno2 = new Aluno { Nome = "Giovanna Mendes", Matricula = "789012", Idade = 24 };

            
            var disciplina1 = new Disciplina { NomeDisciplina = "Desenvolvimento de Sistemas", CodigoDisciplina = 101 };
            var disciplina2 = new Disciplina { NomeDisciplina = "Banco de Dados", CodigoDisciplina = 102 };

           
            aluno1.Disciplinas.Add(disciplina1);
            aluno1.Disciplinas.Add(disciplina2);
            aluno2.Disciplinas.Add(disciplina1);

            db.Alunos.Add(aluno1);
            db.Alunos.Add(aluno2);
            db.SaveChanges();

         
            var alunos = db.Alunos.Include(a => a.Disciplinas).ToList();
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"  Aluno: {aluno.Nome}, Matricula: {aluno.Matricula}, Idade: {aluno.Idade}");
                foreach (var disciplina in aluno.Disciplinas)
                {
                    Console.WriteLine($"  Disciplina: {disciplina.NomeDisciplina}, Código: {disciplina.CodigoDisciplina}");
                }
            }
        }
    }
}
