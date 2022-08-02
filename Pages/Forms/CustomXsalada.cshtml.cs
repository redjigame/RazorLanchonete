using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLanchonete.Models;

namespace RazorLanchonete.Pages.Forms
{
    public class CustomXsaladaModel : PageModel
    {
        [BindProperty]
        public XsaladasModel Xsalada { get; set; }
        public float XsaladaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            XsaladaPrice = Xsalada.BasePrice;

            if (Xsalada.Queijo) XsaladaPrice += 1;
            if (Xsalada.Presunto) XsaladaPrice += 1;
            if (Xsalada.Hamburger) XsaladaPrice += 1;
            if (Xsalada.Beacon) XsaladaPrice += 1;
            if (Xsalada.Tomato) XsaladaPrice += 1;
            if (Xsalada.Alface) XsaladaPrice += 1;
            if (Xsalada.Milho) XsaladaPrice += 1;
            if (Xsalada.Ervilha) XsaladaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new {Xsalada.XsaladaName, XsaladaPrice});
        }
    }
}
