using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Migrations;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class RegisterEventModel : PageModel
    {
        private readonly MyDbContext _context;

        public RegisterEventModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.RegisterEvents registerevents { get; set; }
        public String Student_name { get; set; }
        public void OnGet(string student_name)
        {
            Student_name = student_name;
            TempData["SocietyName"] = student_name;
        }
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
            _context.RegisterEvents.Add(registerevents);
            _context.SaveChanges();
            return RedirectToPage("/Index"); // Redirect to homepage
        }
    }
}
