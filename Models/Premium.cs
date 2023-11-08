using System.IO;
using System;
using System.Xml.XPath;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Premium
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o título do Premium")]
        [StringLength(80, ErrorMessage = "O título deve conter no máximo 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter no máximo 80 caracteres")]
        [DisplayName("Nome Completo")]
        public string Title { get; set; } = String.Empty;

        [DataType(DataType.DateTime)]
        //[GreaterThanToday]
        [DisplayName("Início")]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Término")]
        public DateTime EndTime { get; set; }

        [DisplayName("Aluno")]
        [Required(ErrorMessage = "Aluno inválido")]
        public int StudentId { get; set; }

        public Student? Student {get; set;}
    }
}