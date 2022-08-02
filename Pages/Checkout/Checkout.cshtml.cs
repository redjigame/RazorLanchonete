using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorLanchonete.Data;
using RazorLanchonete.Models;

namespace RazorLanchonete.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string XsaladaName { get; set; }
        public float XsaladaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(XsaladaName))
            {
                XsaladaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "xsalada";
            }

            XsaladaOrder xsaladaOrder = new XsaladaOrder();
            xsaladaOrder.XsaladaName = XsaladaName;
            xsaladaOrder.BasePrice = XsaladaPrice;

            _context.XsaladaOrders.Add(xsaladaOrder);
            _context.SaveChanges();
        }
    }
}
