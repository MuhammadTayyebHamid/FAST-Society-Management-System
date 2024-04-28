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

    public int remaining_budget { get; set; }

    public SocietyHead(MyDbContext context)
    {
        _context = context;
    }

    public Models.Announcements Announcement { get; set; }
    public List<Models.Announcements> Announcements = new List<Models.Announcements>();
    public List<Models.Budget> budgets = new List<Models.Budget>();

    public Models.Events Events { get; set; }
    public List<Models.Events> Event = new List<Models.Events>();

    public void OnGet(string societyName)
    {
        SocietyName = societyName;
        TempData["SocietyName"] = societyName;
        LoadAnnouncements();
        Loadbudget();
        LoadEvents();
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

    private void Loadbudget()
    {
        // Retrieve announcements associated with the current society name
        if (TempData.TryGetValue("SocietyName", out object societyNameObj))
        {
            // Retrieve announcements associated with the society name
            string societyName = societyNameObj as string;
            TempData["SocietyName"] = societyName;
            this.SocietyName = societyName;
            this.budgets = _context.Budget.Where(a => a.SocietyName == societyName).ToList();
            if (this.budgets.Count > 0)
            {
                this.remaining_budget = this.budgets[0].TotalBudget;
            }

        }


    }

    private void LoadEvents()
    {
        // Retrieve announcements associated with the current society name
        if (TempData.TryGetValue("SocietyName", out object societyNameObj))
        {
            // Retrieve announcements associated with the society name
            string societyName = societyNameObj as string;
            TempData["SocietyName"] = societyName;
            this.SocietyName = societyName;
            this.Event = _context.Events.Where(a => a.SocietyName == societyName).ToList();
            for (int i = 0; i < this.Event.Count; i++)
            {
                this.remaining_budget -= Event[i].Budget;
            }
        }


    }

}