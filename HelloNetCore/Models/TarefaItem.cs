using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloNetCore.Models
{
    public class TarefaItem
    {
        public Guid Id { get; set; }

        public bool isCompleta { get; set; }

        public string Nome { get; set; }

        public DateTimeOffset? DataConclusao { get; set; }
    }
}
