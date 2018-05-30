using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services {
    public interface ITarefaItemService {
        Task<IEnumerable<TarefaItem>> GetItemAsync ();

    }
}