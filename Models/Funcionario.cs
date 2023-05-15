using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TerceiroCRUD.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        
        [Required(ErrorMessage ="Este Campo é de Preenchimento Obrigatório")]
        [Column(TypeName ="nvarchar(250)")]
        [DisplayName("Nome")]
        public string NomeCompleto { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Cod. Funcionário")]
        public int CodFuncionario { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Função")]
        public string Funcao { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Local De Trabalho")]
        public string LocalDeTrabalho { get; set; }
    }
}
