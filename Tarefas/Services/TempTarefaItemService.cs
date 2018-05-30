using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Models;

namespace Tarefas.Services {

    public class TempTarefaItemService : ITarefaItemService {
        public Task<IEnumerable<TarefaItem>> GetItemAsync () {
            IEnumerable<TarefaItem> items = new [] {
                new TarefaItem {
                Nome = "Aprender ASP.NET Core 2.0",
                isCompleta = false,
                DataConclusao = DateTimeOffset.Now.AddDays (15)
                },

                new TarefaItem {
                Nome = "Criar APP Web",
                isCompleta = false,
                DataConclusao = DateTimeOffset.Now.AddDays (30)
                }
            };

            return Task.FromResult (items);

        }
    }
}