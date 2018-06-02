using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.Models {
    public class TarefaItem {
        [Key]
        public int Id { get; set; }

        [Display (Name = "Tarefa Complea")]
        public bool isCompleta { get; set; }

        [Required (ErrorMessage = "O nome da tarefa é obrigatório")]
        [Display (Name = "Nome da Tarefa")]
        [StringLength (200)]
        public string Nome { get; set; }

        [Required (ErrorMessage = "Informe a Data de Conclusão da Tarefa")]
        [Display (Name = "Data de Conclusão")]
        [DisplayFormat (ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTimeOffset? DataConclusao { get; set; }
    }
}