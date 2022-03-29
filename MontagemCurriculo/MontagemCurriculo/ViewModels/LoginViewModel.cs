using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Campo Obrigatorio")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [EmailAddress(ErrorMessage ="E-mail Inválido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Campo Obrigatorio")]
        [StringLength(50, ErrorMessage = "Use menos caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
