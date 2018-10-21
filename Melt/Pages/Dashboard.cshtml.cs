using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Melt.Pages
{
    public class DashboardModel : PageModel
    {
        public decimal PercentToWorthlessness { get; set; }
        public string ClimberPath { get; set; }
        public decimal Offset { get; set; }
        public void OnGet(int? percent)
        {
            if(percent == null || percent == 0)
            {
                percent = 100;
            }

            PercentToWorthlessness = Convert.ToDecimal(percent);
            ClimberPath = "~/images/climber.png";
            if(PercentToWorthlessness == 0)
            {
                ClimberPath = "~/images/winningClimber.png";
            }
            Offset = ((PercentToWorthlessness * 3.5M) / 100) + 1;

        }
    }
}