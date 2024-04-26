using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class SocietyTeamModel : PageModel
    {
        public string SocietyName { get; set; }
        [BindProperty]
        public string Name { get; set; }
        public string announcement { get; set; }

        private readonly MyDbContext _context;

        public SocietyTeamModel(MyDbContext context)
        {
            _context = context;
        }

        public Models.Announcements Announcement { get; set; }
        public List<Models.Announcements> Announcements = new List<Models.Announcements>();

        public Models.Tasks Tasks { get; set; }
        public List<Models.Tasks> Task = new List<Models.Tasks>();
        public Models.Meetings Meetings { get; set; }
        public List<Models.Meetings> Meeting = new List<Models.Meetings>();

        public void OnGet(string societyName,string name)
        {
            SocietyName = societyName;
            Name = name;
            TempData["SocietyName"] = societyName;
            TempData["Name"]=name;
            LoadAnnouncements();
            LoadTasks();
            LoadMeetings();
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
        private void LoadTasks()
        {
            // Retrieve announcements associated with the current society name
            if (TempData.TryGetValue("Name", out object NameObj))
            {
                // Retrieve announcements associated with the society name
                string Name = NameObj as string;
                TempData["Name"] = Name;
                this.Name = Name;
                this.Task = _context.Tasks.Where(a => a.RollNo == Name).ToList();
            }


        }

        private void LoadMeetings()
        {
            // Retrieve announcements associated with the current society name
            if (TempData.TryGetValue("SocietyName", out object societyNameObj))
            {
                // Retrieve announcements associated with the society name
                string societyName = societyNameObj as string;
                TempData["SocietyName"] = societyName;
                this.SocietyName = societyName;
                this.Meeting = _context.Meetings.Where(a => a.Society == societyName).ToList();
            }


        }
    }
}
