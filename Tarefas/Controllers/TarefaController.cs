using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers {
    public class TarefaController : Controller {

        ITarefaItemService _tarefaService;

        public TarefaController (ITarefaItemService tarefaService) {
            _tarefaService = tarefaService;
        }

        // Lista de Tarefas
        public async Task<IActionResult> Index () {
            // Obter dados e retornar
            var tarefas = await _tarefaService.GetItemAsync ();

            var model = new TarefaViewModel (); {
                model.TarefasItem = tarefas;
            }

            return View (model);
        }
    }

}