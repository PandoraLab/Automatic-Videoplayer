
using AutomaticVideoplayer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutomaticVideoplayer.Pages;

public class IndexModel : PageModel
{
    public AfspeelPlanning Planning { get; set; } = new();

    public void OnGet()
    {
    }
}
