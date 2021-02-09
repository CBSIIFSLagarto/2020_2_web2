using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class MatriculaTurma
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status � obrigat�rio")]
        public bool status { get; set; }

        public Aluno Aluno { get; set; }
        public int AlunoId { get; set; }

        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }

    }
}


        
    
