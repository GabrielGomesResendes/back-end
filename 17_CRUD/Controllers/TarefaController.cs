using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


    public class TarefaController : Controller
    {
     private static List<Tarefa> _tarefas = new List<Tarefa>();

     public IActionResult Index()
     {
        return View(_tarefas);
     }
     public IActionResult Adicionar()
     {
        return View();
     }
     
     [HttpPost]
     public IActionResult Adicionar(Tarefa novaTarefa)
     {
      novaTarefa.Id = _tarefas.Count + 1;
      _tarefas.Add(novaTarefa);
      return RedirectToAction("Index"); 
     }

     public IActionResult Editar(int id)
     {
      Tarefa novaTarefa =_tarefas.FirstOrDefault(t => t.Id == id);

      if (novaTarefa == null)
      return NotFound();

      return View(novaTarefa);
     }


      [HttpPost]

      public IActionResult Editar(Tarefa tarefaEditando)
      {
         Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
         if (tarefaEncontrada == null)
         return NotFound();

         tarefaEncontrada.Descricao = tarefaEditando.Descricao;
         tarefaEncontrada.Concluida = tarefaEditando.Concluida;
         return RedirectToAction("Index")
      }
     public IActionResult Deletar(int id)
     {
      Tarefa novaTarefa =_tarefas.FirstOrDefault(t => t.Id == id);

      if (novaTarefa == null)
      return NotFound();

      return View(novaTarefa);
     }

[HttpPost]

      public IActionResult DeletarConfirmado(int Id)
      {
         Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
         if (tarefaEncontrada == null)
         return NotFound():
      }
     
    }
