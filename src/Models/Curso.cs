using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SisGerenciador.src.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Sigla")]
        [StringLength(25)]
        [Required(ErrorMessage = "Sigla � obrigat�ria", AllowEmptyStrings = false)]
        public string Sigla { get; set; }

        [Display(Name = "Descri��o")]
        [Required(ErrorMessage = "Descri��o � obrigat�ria", AllowEmptyStrings = false)]
        [StringLength(255, MinimumLength = 4, ErrorMessage = "A descri��o deve conter no m�nimo 4 e m�ximo 255 caracteres.")]
        public string Descricao { get; set; }

        [Display(Name = "Quantidade de per�odos")]
        [Required(ErrorMessage = "A quantidade de per�odos � obrigat�ria")]
        public int QtdPeriodo { get; set; }

        [Display(Name = "Limite de per�odos")]
        [Required(ErrorMessage = "A quantidade de per�odos � obrigat�ria")]
        public int LimiteQtdPeriodoCurricular { get; set; }

        public Instituicao Instituicao { get; set; }
        public int InstituicaoId { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

        public virtual ICollection<GradeCurricular> GradesCurriculares { get; set; }
    }
}


        
    
