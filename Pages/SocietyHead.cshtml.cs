using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SE_Project.Pages;

public class SocietyHead : PageModel
{
    public string SocietyName { get; set; }
    public void OnGet(string societyName)
    {
        SocietyName = societyName;
    }
}