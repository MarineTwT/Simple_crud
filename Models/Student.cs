using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Models
{
    public class Student
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter no máximo 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter no máximo 80 caracteres")]
        [DisplayName("Nome Completo")]
        public string Name { get; set; } = String.Empty;

        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = String.Empty;

        public List<Premium> Premiums {get; set;} = new();
    }
}