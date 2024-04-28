using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class Interview
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string SocietyName { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Roll No field is required.")]
        public string RollNo { get; set; }
    }
}
