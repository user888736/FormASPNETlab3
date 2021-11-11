using System.ComponentModel.DataAnnotations;

namespace Lab3_test3.Models
{
    public class FormModel
    {
        [Display(Name = "Imię")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Liczba powtórzeń")]
        public string Description { get; set; }
        [Display(Name = "Element widoczny?")]
        public bool IsVisible { get; set; }
    }
}