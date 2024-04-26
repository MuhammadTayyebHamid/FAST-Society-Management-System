using System;
using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class Meetings
    {
        [Required(ErrorMessage = "The Description field is required.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "The RollNo field is required.")]
        public string MeetingTopic { get; set; }

        [Required(ErrorMessage = "The RollNo field is required.")]
        public string Society { get; set; }

        [Required(ErrorMessage = "The Deadline field is required.")]
        public DateTime startdate { get; set; }

        [Required(ErrorMessage = "The Deadline field is required.")]
        public TimeSpan starttime { get; set; }

        [Required(ErrorMessage = "The Deadline field is required.")]
        public TimeSpan endtime { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        public string location { get; set; }
    }
}
