using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Packt.Shared;
using System.Linq;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        private Northwind db;
        public IEnumerable<string> Suppliers { get; set; }

        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Website - Suppliers";

            Suppliers = db.Suppliers.Select(s => s.CompanyName);
            //Suppliers = new[]
            //{
            //    "Alpha Co.", "Beta Limited", "Gamma Corp"
            //};
        }
    }
}