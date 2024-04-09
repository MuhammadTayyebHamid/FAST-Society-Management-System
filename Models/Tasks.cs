using System;
using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The RollNo field is required.")]
        public string RollNo { get; set; }

        [Required(ErrorMessage = "The Deadline field is required.")]
        public DateTime Deadline { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        public string Description { get; set; }
    }
}
