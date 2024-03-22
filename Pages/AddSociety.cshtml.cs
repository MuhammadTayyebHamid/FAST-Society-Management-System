using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class AddSocietyModel : PageModel
    {
        private readonly MyDbContext _context;

        public List<Society> Societies { get; set; } = new List<Society>();

        [BindProperty]
        public Society NewSociety { get; set; }

        public AddSocietyModel(MyDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Societies = _context.Societies.ToList();
        }
        public IActionResult onPost()
        {
            _context.Societies.Add(NewSociety);
            _context.SaveChangesAsync();
            return RedirectToPage("./Index"); // Redirect to index page after adding
        }
    }
}
