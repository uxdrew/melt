using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Melt.Pages
{
    public class DashboardModel : PageModel
    {
        public decimal PercentToWorthlessness { get; set; }
        public decimal Offset { get; set; }
        public void OnGet()
        {
            Offset = ((PercentToWorthlessness * 3.5M) / 100) + 1;

        }
    }
}