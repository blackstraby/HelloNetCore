using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.Models {
    public class TarefaItem {
        [Key]
        public Guid Id { get; set; }

        [Display (Name = "Tarefa Complea")]
        public bool isCompleta { get; set; }

        [Required (ErrorMessage = "O nome da tarefa é obrigatório")]
        [StringLength (200)]
        public string Nome { get; set; }

        [Display (Name = "Data de Conclusão")]
        public DateTimeOffset? DataConclusao { get; set; }
    }
}