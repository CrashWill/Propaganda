using System.Linq;
using Propaganda.Models;

namespace Propaganda.Dados
{
    public class IniciarBanco
    {
        public static void Inicializar(PropContexto contexto)
        {
            contexto.Database.EnsureCreated();
            if (contexto.Areas.Any())
            {
                return;
            }
            var areas = new Areas()
            {
                Nome = "Administracao Geral",
                Descricao = "Curso voltado a area de gerenciamento de escritórios",
            };
            contexto.Areas.Add(areas);

            var cursos = new Cursos()
            {
                Nome = "Auxiliar Administrativo",
                Descricão = "Curso voltado a area de gerenciamento de escritórios",
                IdAreas = areas.IdAreas
            };
            contexto.Cursos.Add(cursos);

            var turmas = new Turmas()
            {
                IdCursos = cursos.IdCursos,
                Duracao = "200 Horas",
                Horario = "Seg, Qua, Sex: 19:00 as 22:30"
            };
            
            contexto.Turmas.Add(turmas);
            contexto.SaveChanges();
        }
        
    }
}