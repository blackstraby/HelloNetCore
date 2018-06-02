using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarefas.Models;
using Tarefas.Services;

namespace Tarefas.Controllers {
    public class TarefasController : Controller {

        ITarefaItemService _tarefaService;

        public TarefasController (ITarefaItemService tarefaService) => _tarefaService = tarefaService;

        // Lista de Tarefas
        public async Task<IActionResult> Index (bool? criterio) {
            // Obter dados e retornar
            var tarefas = await _tarefaService.GetItemAsync (criterio);

            var model = new TarefaViewModel (); {
                model.TarefasItem = tarefas;
            }

            return View (model);
        }

        [HttpGet]
        public IActionResult AdicionarItemTarefa () {
            return View ();
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarItemTarefa ([Bind ("Id, isCompleta, Nome, DataConclusao ")] TarefaItem tarefa) {
            if (ModelState.IsValid) {
                await _tarefaService.AdicionarItem (tarefa);
                return RedirectToAction (nameof (Index));
            }
            return View (tarefa);
        }

        //GET tarefas/Delete/1
        [HttpGet]
        public IActionResult Delete (int ? id) {
            if (id == null)
                return NotFound ();

            var tarefaItem = _tarefaService.GetarefaById (id);
            if (tarefaItem == null)
                return NotFound ();

            return View (tarefaItem);
        }

        [HttpPost, ActionName ("Delete")]
        public async Task<IActionResult> DeleteConfirmed (int? id) {
            await _tarefaService.DeletarItem (id);
            return RedirectToAction (nameof (Index));
        }

        //GET tarefas/Edit/1
        [HttpGet]
        public IActionResult Edit (int? id) {
            if (id == null)
                return NotFound ();

            var tarefaItem = _tarefaService.GetarefaById (id);
            if (tarefaItem == null)
                return NotFound ();

            return View (tarefaItem);
        }

        [ValidateAntiForgeryToken] // Evita ataque CSRF
        [HttpPost]
        public async Task<IActionResult> Edit (int id, [Bind ("Id, isCompleta, Nome, DataConclusao ")] TarefaItem tarefaItem) {
            if (id != tarefaItem.Id)
                return NotFound ();

            if (ModelState.IsValid) {
                try {
                    await _tarefaService.EditarItem (tarefaItem);
                } catch (DbUpdateConcurrencyException) {
                    // Caso dois usuarios editem ao mesmo tempo o mesmo cara lança a exception
                    throw;
                }
                return RedirectToAction (nameof (Index));
            }
            return View (tarefaItem);
        }

    }

}