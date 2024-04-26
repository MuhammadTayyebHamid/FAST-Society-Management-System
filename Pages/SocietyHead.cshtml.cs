using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Migrations;
using SE_Project.Models;

namespace SE_Project.Pages;

public class SocietyHead : PageModel
{
    public string SocietyName { get; set; }
    [BindProperty]
    public string announcement { get; set; }
    private readonly MyDbContext _context;

    public SocietyHead(MyDbContext context)
    {
        _context = context;
    }

    public Models.Announcements Announcement { get; set; }
    public List<Models.Announcements> Announcements = new List<Models.Announcements>();

    public void OnGet(string societyName)
    {
        SocietyName = societyName;
        TempData["SocietyName"] = societyName;
        LoadAnnouncements();
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

        Announcement = new Models.Announcements();
        Console.WriteLine("Society : " + SocietyName);
        this.Announcement.societyName = TempData["SocietyName"] as string;
        this.Announcement.Announcement = this.announcement;
        _context.announcements.Add(this.Announcement);
        _context.SaveChanges();
        LoadAnnouncements();
        return RedirectToPage("/Index"); // Redirect to homepage
    }

    private void LoadAnnouncements()
    {
        // Retrieve announcements associated with the current society name
        if (TempData.TryGetValue("SocietyName", out object societyNameObj))
        {
            // Retrieve announcements associated with the society name
            string societyName = societyNameObj as string;
            TempData["SocietyName"] = societyName;
            this.SocietyName = societyName;
            this.Announcements = _context.announcements.Where(a => a.societyName == societyName).ToList();
        }


    }

}