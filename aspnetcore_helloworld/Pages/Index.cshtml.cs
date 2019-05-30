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
        public int DevTimeMonths { get; private set; }

        public string ProfileImageSource { get; private set; }

        public void OnGet()
        {
            var firstJobDate = new DateTime(2008, 06, 09);
            var devDuration = DateTime.UtcNow - firstJobDate;
            var span = DateTime.MinValue + devDuration;
            DevTimeYears = span.Year - 1;
            DevTimeMonths = span.Month - 1;

#if DEBUG
            // just so I don't have to keep looking at myself whilst debugging...
            ProfileImageSource = "img/default-profile.jpg";
#else
            ProfileImageSource = "img/mikemcmillan.jpg";
#endif
        }
    }
}
