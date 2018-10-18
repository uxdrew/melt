using Melt.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Melt.ViewComponent
{
    public class TestViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private ISqlAccess _sqlAccess;

        public string DateFirst { get; set; }

        public TestViewComponent(ISqlAccess sqlAcccess)
        {
            _sqlAccess = sqlAcccess;
        }

        public IViewComponentResult Invoke()
        {
            var date = _sqlAccess.ExecuteScalarQuery<DateTime>("select GetDate()");
            return View("Default", date.ToLongDateString());
        }
    }
}
