using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore_helloworld.Pages
{
    public class IndexModel : PageModel
    {
        public int DevTimeYears { get; private set; }

        public void OnGet()
        {
            var firstJobDate = new DateTime(2008, 06, 01);
            var devDuration = DateTime.UtcNow - firstJobDate;
            DevTimeYears = (int)(devDuration.Days / 365.25);
        }
    }
}
