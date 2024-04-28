using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE_Project.Models;

namespace SE_Project.Pages
{
    public class ManageInterviewModel : PageModel
    {
        

        private readonly MyDbContext _context;
        [BindProperty]

        public Models.Interview Interview { get; set; }
        public List<Models.Interview> Interviews = new List<Models.Interview>();
        public string SocietyName { get; set; }
        public ManageInterviewModel(MyDbContext context)
        {
            _context = context;
        }
        public void OnGet(string societyName)
        {
            SocietyName = societyName;
            TempData["SocietyName"] = societyName;
            Loadinterviews();
        }
        private void Loadinterviews()
        {
            // Retrieve announcements associated with the current society name
            if (TempData.TryGetValue("SocietyName", out object societyNameObj))
            {
                // Retrieve announcements associated with the society name
                string societyName = societyNameObj as string;
                TempData["SocietyName"] = societyName;
                this.SocietyName = societyName;
                this.Interviews = _context.Interview.Where(a => a.SocietyName == societyName).ToList();
            }


        }
    }
}
