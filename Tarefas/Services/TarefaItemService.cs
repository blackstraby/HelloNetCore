using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarefas.Data;
using Tarefas.Models;

namespace Tarefas.Services {
    public class TarefaItemService : ITarefaItemService {
        private readonly ApplicationDbContext _context;

        public TarefaItemService (ApplicationDbContext contexto) {
            _context = contexto;
        }
        public async Task<IEnumerable<TarefaItem>> GetItemAsync () {
            var items = await _context.Tarefas
                //.Where (t => t.isCompleta == false)
                .ToArrayAsync ();
            return items;
        }

        public async Task<bool> AdicionarItem (TarefaItem novaTarefa) {

            var tarefa = new TarefaItem {
                isCompleta = false,
                Nome = novaTarefa.Nome,
                DataConclusao = novaTarefa.DataConclusao
            };

            _context.Tarefas.Add (tarefa);
            var resultado = await _context.SaveChangesAsync ();
            return resultado == 1;
        }

        public async Task<bool> DeletarItem (int? id) {
            TarefaItem tarefa = _context.Tarefas.Find (id);

            _context.Tarefas.Remove (tarefa);
            var resultado = await _context.SaveChangesAsync ();

            return resultado == 1;
        }

        public async Task EditarItem (TarefaItem item) {
            if (item == null)
                throw new ArgumentException (nameof (item));

            _context.Tarefas.Update (item);
            await _context.SaveChangesAsync ();
        }

        public TarefaItem GetarefaById (int? id) {
            return _context.Tarefas.Find (id);
        }
    }
}