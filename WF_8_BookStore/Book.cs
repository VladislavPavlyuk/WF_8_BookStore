using System.ComponentModel.DataAnnotations;

namespace BookStore
{
    public class Book 
    {
        [Key]
        public int ID { get; set; }

        [MinLength(1) ,StringLength(100), Required (ErrorMessage = "An Book Title is required (max 100 char).")]       
        public string Book_Title { get; set; } = null!;

        [MinLength(1), StringLength(100), Required(AllowEmptyStrings = false, 
            ErrorMessage = "An Author Name is required (max 50 char).")]
        public string Author { get; set; } = null!;

    }
}