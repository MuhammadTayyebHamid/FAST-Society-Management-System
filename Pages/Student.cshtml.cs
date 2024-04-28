using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Migrations;
using SE_Project.Models;

namespace SE_Project.Pages;


public class StudentModel : PageModel
{
    private readonly MyDbContext _context;
    public StudentModel(MyDbContext context)
    {
        _context = context;
    }
    [BindProperty]
    public Models.Events Events { get; set; }
    public List<Models.Events> Event = new List<Models.Events>();

    public Models.Announcements Announcement { get; set; }
    public List<Models.Announcements> Announcements = new List<Models.Announcements>();

    public String Student_name { get; set; }
    public void OnGet(string student_name)
    {
        Student_name = student_name;
        TempData["SocietyName"] = student_name;
        LoadAnnouncements();
        LoadEvents();
    }

    private void LoadAnnouncements()
    {
        this.Announcements = _context.announcements.ToList();


    }

    private void LoadEvents()
    {
        // Retrieve announcements associated with the current society name
        this.Event = _context.Events.ToList();
    }
}

