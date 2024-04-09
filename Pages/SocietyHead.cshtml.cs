using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Migrations;
using SE_Project.Models;

namespace SE_Project.Pages;

public class SocietyHead : PageModel
{
    [BindProperty]
    public string SocietyName { get; set; }
    [BindProperty]
    public string announcement { get; set; }
    private readonly MyDbContext _context;

    public SocietyHead(MyDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Announcements Announcement { get; set; }

    public void OnGet(string societyName)
    {
        SocietyName = societyName;
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

        Announcement = new Announcements();
        this.Announcement.societyName = this.SocietyName;
        this.Announcement.Announcement = this.announcement;
        _context.announcements.Add(Announcement);
        _context.SaveChanges();
        return RedirectToPage("/Index"); // Redirect to homepage
    }


}