using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using mike.data;
using mike.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace aspnetcore_helloworld.Pages
{
    public class PortfolioModel : PageModel
    {
        public IEnumerable<Section> Sections { get; private set; }

        public string TotalUltraTime { get; private set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public PortfolioModel(ISectionData sectionData)
        {
            this._sectionData = sectionData;

            var ultrastart = new DateTime(2011, 06, 25);
            var diff = DateTime.UtcNow - ultrastart;
            var totalUltraTime = DateTime.MinValue + diff;
            TotalUltraTime = $"{totalUltraTime.Year-1} Years, {totalUltraTime.Month-1} Months";
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