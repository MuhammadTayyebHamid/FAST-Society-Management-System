using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SE_Project.Pages
{
    public class AdminBudgetModel : PageModel
    {
        
        private readonly MyDbContext _context;

        public AdminBudgetModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Budget budget { get; set; }
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
            Console.WriteLine($"Validation Error: {budget.Id}");
            Console.WriteLine($"Validation Error: {budget.SocietyName}");
            Console.WriteLine($"Validation Error: {budget.TotalBudget}");
            _context.Budget.Add(budget);
            _context.SaveChanges();
            return RedirectToPage("/Index"); // Redirect to homepage
        }
        public void OnGet()
        {
        }

    }
}
