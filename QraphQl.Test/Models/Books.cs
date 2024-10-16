using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QraphQl.Test.Models
{
    public class Books
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int Book_Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; } 
    }
}
