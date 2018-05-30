using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.Models {
    public class TarefaViewModel {
        public IEnumerable<TarefaItem> TarefasItem { get; set; }
    }
}