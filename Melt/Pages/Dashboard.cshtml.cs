using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Melt.Pages
{
    public class DashboardModel : PageModel
    {
        public decimal PercentToWorthlessness { get; set; }
        public string ClimberPath { get; set; }
        public decimal Offset { get; set; }
        public void OnGet()
        {
            ClimberPath = "~/images/climber.png";
            if(PercentToWorthlessness == 0)
            {
                ClimberPath = "~/images/winningClimber.png";
            }
            Offset = ((PercentToWorthlessness * 3.5M) / 100) + 1;

        }
    }
}