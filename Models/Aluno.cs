﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        public string CPF { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }

        [Display(Name = "Data/Hora Inicio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        [Required(ErrorMessage = "Data/Hora do inicio é obrigatória", AllowEmptyStrings = false)]
        public DateTime DtNasc { get; set; }

        public string Matricula { get; set; }

        public DateTime DtMatricula { get; set; }

        public Instituicao Instituicao { get; set; }

        public int InstituicaoId { get; set; }

    }
}
