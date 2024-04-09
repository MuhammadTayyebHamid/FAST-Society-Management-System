using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SE_Project.Models;


namespace SE_Project.Pages
{
    public class ManageMemberModel : PageModel
    {
        private readonly MyDbContext _context;

        public ManageMemberModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Members member { get; set; }
        public string RemoveMember { get; set; }

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
            _context.Members.Add(member);
            _context.SaveChanges();
            return RedirectToPage("/Index"); // Redirect to homepage
        }

        public async Task<IActionResult> OnPostRemove()
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

            var memberToRemove = await _context.Members.FirstOrDefaultAsync(m => m.Name == RemoveMember);

            if (memberToRemove != null)
            {
                _context.Members.Remove(memberToRemove);
                await _context.SaveChangesAsync(); // Save changes asynchronously
                return RedirectToPage("/Index"); // Redirect to homepage
            }

            return NotFound(); // Member not found
        }


    }
}
