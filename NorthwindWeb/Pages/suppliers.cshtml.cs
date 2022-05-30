using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Packt.Shared;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {
        private Northwind db;
        public IEnumerable<string> Suppliers { get; set; }
        [BindProperty]
        public Supplier Supplier { get; set; }

        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            return Page();
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