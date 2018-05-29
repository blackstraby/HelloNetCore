using HelloNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloNetCore.Services
{
    public interface ITarefaItemService
    {
        Task<IEnumerable<TarefaItem>> GetItemAsync();

    }
}
