using Melt.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Melt.Pages
{
    public class TestDbModel : PageModel
    {
        private ISqlAccess _sqlAccess;

        public int Id { get; set; }
        public string ServerName { get; set; }
        public TeamMember Member { get; set; }

        [BindProperty] //This attribute is what tells Model Binding to do the binding for this property.
        public Restaurant Restaurant { get; set; }

        public TestDbModel(ISqlAccess sqlAccess)
        {
            _sqlAccess = sqlAccess;
        }

        public IActionResult OnGet(int id)
        {
            Id = id;
            ServerName = _sqlAccess.ExecuteScalarQuery<string>("select @@serverName");

            if (id == 0)
            {
                return RedirectToAction("Index", "Home", new { ComingFromPage = true });
            }

            return Page();
        }

        // Post method. Works like any controller post method.
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return Page();
        }
    }

    public enum TeamMember
    {
        Arjun,
        Andrew,
        Jeremy,
        Scott
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
    }

}