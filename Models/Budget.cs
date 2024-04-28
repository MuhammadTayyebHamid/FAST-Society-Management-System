using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class Budget
    {
        [Required(ErrorMessage = "The id field is required.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The society name field is required.")]
        public string SocietyName { get; set; }
        [Required(ErrorMessage = "The bugdet field is required.")]
        public int TotalBudget { get; set; }
    }
}
