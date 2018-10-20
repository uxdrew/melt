using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Melt.Pages
{
    public class DashboardModel : PageModel
    {
        public int ClimberTop { get; set; }
        public int ClimberBottom { get; set; }
        public void OnGet()
        {
        }

        //private int ComputeClimberoffset()
        //{

        //}
    }
}