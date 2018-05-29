using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloNetCore.Models
{
    public class TarefaViewModel
    {
        public IEnumerable<TarefaItem> TarefasItem { get; set; }
    }
}
