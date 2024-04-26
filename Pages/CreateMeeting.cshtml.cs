using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SE_Project.Models;
using System.Threading.Tasks;

namespace SE_Project.Pages
{
    public class CreateMeeting : PageModel
    {
        private readonly MyDbContext _context;

        public CreateMeeting(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Meetings Meetings { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Log ModelState errors
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        // Log or handle validation error messages
                        Console.WriteLine($"Validation Error: {error.ErrorMessage}");
                    }
                }
                return Page();
            }
            _context.Meetings.Add(Meetings);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
