﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Instituicao
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Sigla")]
        [StringLength(11)]
        [Required(ErrorMessage = "Sigla é obrigatória", AllowEmptyStrings = false)]
        public string Sigla { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Descrição é obrigatória", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "A descrição deve conter no mínimo 4 e máximo 255 caracteres.")]
        public string Descricao { get; set; }

        public virtual ICollection<Docente> Docentes { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
