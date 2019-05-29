using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using mike.data;
using mike.models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace aspnetcore_helloworld.Pages
{
    public class PortfolioModel : PageModel
    {
        public IEnumerable<Section> Sections { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public PortfolioModel(ISectionData sectionData)
        {
            this._sectionData = sectionData;
        }

        public IActionResult OnGet()
        {
            if (SearchTerm == null)
            {
                Sections = _sectionData.GetAll();
            }
            else
            {
                Sections = _sectionData.GetByContent(SearchTerm);
            }
            return Page();
        }

        private readonly ISectionData _sectionData;
    }
}