using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class AddSocietyModel : PageModel
    {
        private readonly MyDbContext _context;

        public AddSocietyModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Society society { get; set; }

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

            _context.Societies.Add(society);
            _context.SaveChanges();
            return RedirectToPage("/Index"); // Redirect to homepage
        }
    }
}
