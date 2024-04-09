using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class Members
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public int Id { get; set; }
        

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Password field is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Roll No field is required.")]
        public string RollNo { get; set; }

        [Required(ErrorMessage = "The Role field is required.")]
        public string Role { get; set; }
    }
}
