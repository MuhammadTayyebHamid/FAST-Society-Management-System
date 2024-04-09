using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class Society
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Mentor Name field is required.")]
        public string MentorName { get; set; }
        [Required(ErrorMessage = "The Team Members field is required.")]
        
        public string Member1 { get; set; }
        [Required(ErrorMessage = "The Member Name field is required.")]
        public string Password1 { get; set; }
        [Required(ErrorMessage = "The Password field is required.")]
        public string Member2 { get; set; }
        [Required(ErrorMessage = "The Member Name field is required.")]
        public string Password2 { get; set; }
        [Required(ErrorMessage = "The Password field is required.")]
        public string Member3 { get; set; }
        [Required(ErrorMessage = "The Member Name field is required.")]
        public string Password3 { get; set; }
        [Required(ErrorMessage = "The Password field is required.")]
        public string Member4 { get; set; }
        [Required(ErrorMessage = "The Member Name field is required.")]
        public string Password4 { get; set; }
        [Required(ErrorMessage = "The Password field is required.")]
        public string Member5 { get; set; }
        [Required(ErrorMessage = "The Member Name field is required.")]
        public string Password5 { get; set; }
        [Required(ErrorMessage = "The Password field is required.")]


        public string Head { get; set; }
        [Required(ErrorMessage = "The Plans field is required.")]
        public string HeadPassword { get; set; }
        [Required(ErrorMessage = "The Password field is required.")]

        public string Plans { get; set; }
    }
}
