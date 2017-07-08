using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Nome do autor é obrigatório.")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Nome da editora é obrigatório.")]
        public string Editora { get; set; }
        [Required(ErrorMessage = "Número da edição é obrigatório.")]
        public int Edicao { get; set; }
        [Required(ErrorMessage = "Ano da edição é obrigatório.")]
        public int Ano { get; set; }
        [Required(ErrorMessage = "Número de páginas é obrigatório.")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "ISBN é obrigatório.")]
        public int ISBN { get; set; }
    }
}
