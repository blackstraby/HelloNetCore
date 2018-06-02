using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services {
    public interface ITarefaItemService {
        Task<IEnumerable<TarefaItem>> GetItemAsync (bool? criterio);
        Task<bool> AdicionarItem (TarefaItem novaItem);

        Task<bool> DeletarItem (int? id);

        Task EditarItem (TarefaItem tarefa);

        TarefaItem GetarefaById (int? id);

    }
}