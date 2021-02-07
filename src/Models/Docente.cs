﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Docente
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "CPF")]
        [StringLength(11)]
        public string CPF { get; set; }

        [Display(Name = "Nome")]
        [StringLength(500)]
        [Required(ErrorMessage = "Nome é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        [StringLength(500)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Endereço")]
        [StringLength(500)]
        public string Endereco { get; set; }

        [Display(Name = "Matricula")]
        [Required(ErrorMessage = "Matricula é obrigatória")]
        public int Matricula { get; set; }

        [Display(Name = "Data de Matricula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime DtMatricula { get; set; }

        public Instituicao Instituicao { get; set; }
        public int InstituicaoId { get; set; }

        public virtual ICollection<MatriculaTurma> MatriculaTurmas { get; set; }

    }
}
