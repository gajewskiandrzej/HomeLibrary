using System.ComponentModel.DataAnnotations;

namespace HomeLibrary.Models
{
    public class Element
    {
        [Key]
        public int IDElement { get; set; }
        public string Carries { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string NameOfAuthors { get; set; }
        public string Status { get; set; }
        public string Cover { get; set; }
        public string Description { get; set; }
    }
}
