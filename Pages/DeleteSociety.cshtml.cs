using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class DeleteSocietyModel : PageModel
    {
        private readonly MyDbContext _context;

        public DeleteSocietyModel(MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string societyName { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            
            var society = await _context.Societies.FirstOrDefaultAsync(s => s.Name == societyName);

           
            if (society != null)
            {
                _context.Societies.Remove(society);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Index"); 
            }

            
            return NotFound(); 
        }
    }
}
