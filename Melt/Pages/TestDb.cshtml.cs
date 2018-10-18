using Melt.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Melt.Pages
{
    public class TestDbModel : PageModel
    {
        private ISqlAccess _sqlAccess;
        public string ServerName { get; set; }


        public TestDbModel(ISqlAccess sqlAccess)
        {
            _sqlAccess = sqlAccess;
        }

        public void OnGet()
        {
            ServerName = _sqlAccess.ExecuteScalarQuery<string>("select @@serverName");
        }
    }
}