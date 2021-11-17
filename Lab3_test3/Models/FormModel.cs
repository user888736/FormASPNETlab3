using System.ComponentModel.DataAnnotations;

namespace Lab3_test3.Models
{
    public class FormModel
    {
        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Liczba powtórzeń")]
        public int numOfRepeat { get; set; }
        
    }
}