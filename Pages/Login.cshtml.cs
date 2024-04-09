using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class LoginModel : PageModel
    {
        private readonly MyDbContext _context;
        public LoginModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            // Check if username and password match the society head's credentials
            var society = _context.Societies.FirstOrDefault(s => s.Head == Username && s.HeadPassword == Password);
            if (society != null)
            {
                // Redirect to the AddSociety page with the society name as a parameter
                return RedirectToPage("/SocietyHead", new { societyName = society.Name });
            }

            // If username or password is incorrect, show an error message
            ModelState.AddModelError(string.Empty, "Invalid username or password.");
            return Page();
        }
    }
}
