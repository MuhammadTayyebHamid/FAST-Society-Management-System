using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class ManageEventModel : PageModel
    {
        private readonly MyDbContext _context;

        public ManageEventModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Events Event { get; set; }

        public string RemoveEvent { get; set; }

        public IActionResult OnPost()
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
            _context.Events.Add(Event);
            _context.SaveChanges();
            return RedirectToPage("/Index"); // Redirect to homepage
        }

        public async Task<IActionResult> OnPostRemove()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var eventToRemove = await _context.Events.FirstOrDefaultAsync(e => e.Name == RemoveEvent);

            if (eventToRemove != null)
            {
                _context.Events.Remove(eventToRemove);
                await _context.SaveChangesAsync(); // Save changes asynchronously
                return RedirectToPage("/Index"); // Redirect to homepage
            }

            return NotFound(); // Event not found
        }
    }
}
