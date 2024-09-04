namespace BibliotecaCsharpMvc.Models
{
    public class BookModel
    {
        public long Id { get; set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public int Year { get; set; }
        public String PublishingCompany {  get; set; }
        public bool IsReaded { get; set; }
        public bool IsDigital { get; set; }
        public bool IsDeleted { get; set; }
        public String Cover { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
