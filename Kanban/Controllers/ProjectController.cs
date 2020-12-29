using Kanban.Data;
using Kanban.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanban.Controllers
{
    /*
        akcja Create dodaje nowy projekt o unikatowej nazwie zawierającą aktualną datę
        akcja Read zwraca aktualną listę projektów
        akcja Update dodaje 5 dni do terminu zakończenia pierwszego projektu
        akcja Delete usuwa pierwszy projekt
     */

    public class ProjectController : Controller
    {
        private readonly KanbanContext _kanbanContext;

        public ProjectController(KanbanContext kanbanContext)
        {
            _kanbanContext = kanbanContext;
        }
        public IActionResult Index()
        {
            return View(new ProjectInfo() { Name = "Kanban" });
        }

        public IActionResult Create()
        {
            var project = new ProjectInfo()
            {
                Name = "Nowy projekt " + DateTime.Now.ToString(),
                StartDate = DateTime.Now,
                FinishDate = DateTime.Now.AddDays(10),
            };

            _kanbanContext.Project.Add(project);
            _kanbanContext.SaveChanges();

            return Content($"Dodano nowy projekt z id '{project.ProjectInfoId}'");
        }

        public IActionResult Read()
        {
            var result = _kanbanContext.Project.ToList();
            return Json(result);
        }

        public IActionResult Update()
        {
            var firstProject = _kanbanContext.Project.FirstOrDefault();
            if (firstProject == null)
            {
                return NotFound("Brak projektów");
            }
            if (firstProject.FinishDate.HasValue)
            {
                firstProject.FinishDate.Value.AddDays(5);
            }

            _kanbanContext.SaveChanges();
            return Content($"przesunieto termin zakonczenia projekt z id '{firstProject.ProjectInfoId}' o 5 dni");
        }

        public IActionResult Delete()
        {
            var firstProject = _kanbanContext.Project.FirstOrDefault();
            if (firstProject == null)
            {
                return NotFound("Brak projektów");
            }

            _kanbanContext.Project.Remove(firstProject);
            _kanbanContext.SaveChanges();

            return Content($"Usunieto projekt z id '{firstProject.ProjectInfoId}'");
        }
    }
}
