using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.Models
{
    public class FormacaoAcademica
    {
        public int FormacaoAcademicaId { get; set; }
        public int TipoCursoId { get; set; }
        public TipoCurso TipoCurso { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string Instituicao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(1920, 2022, ErrorMessage = "Ano Inválido")]
        public int AnoInicio { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(1920, 2026, ErrorMessage = "Ano Inválido")]
        public int AnoFim { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        public string NomeCurso { get; set; }
        public int CurriculoId { get; set; }
        public Curriculo Curriculo { get; set; }
    }
}
