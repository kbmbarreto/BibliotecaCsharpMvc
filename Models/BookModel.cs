using System.ComponentModel.DataAnnotations;

namespace BibliotecaCsharpMvc.Models
{
    public class BookModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="Digite o nome do livro!")]
        public String Title { get; set; }
        [Required(ErrorMessage = "Digite o nome do autor!")]
        public String Author { get; set; }
        [Required(ErrorMessage = "Digite o ano de lançamento!")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Digite o nome da editora!")]
        public String PublishingCompany {  get; set; }
        public bool IsReaded { get; set; }
        public bool IsDigital { get; set; }
        public bool IsDeleted { get; set; }
        public String Cover { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
