using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SE_Project.Models;
using System.Threading.Tasks;

namespace SE_Project.Pages
{
    public class TaskCoordinationModel : PageModel
    {
        private readonly MyDbContext _context;

        public TaskCoordinationModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tasks Task { get; set; }
        public string SocietyName { get; set; }
        public void OnGet(string societyName)
        {
            SocietyName = societyName;
            TempData["SocietyName"] = societyName;

        }
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
            _context.Tasks.Add(Task);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}
