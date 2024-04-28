using System.ComponentModel.DataAnnotations;

namespace SE_Project.Models
{
    public class Events
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string SocietyName { get; set; }

        [Required(ErrorMessage = "The bugdet field is required.")]
        public int Budget { get; set; }
        [Required(ErrorMessage = "The bugdet field is required.")]
        public int ticket_price { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Location { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public TimeSpan StartTime { get; set; }
        [Required(ErrorMessage = "The Name field is required.")]
        public TimeSpan EndTime { get; set; }
    }
}
