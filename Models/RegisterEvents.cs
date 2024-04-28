using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class RegisterEvents
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
    }
}
