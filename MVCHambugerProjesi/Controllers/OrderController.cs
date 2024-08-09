using Microsoft.AspNetCore.Mvc;
using MVCHambugerProjesi.Models;
using Newtonsoft.Json;

namespace MVCHambugerProjesi.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Submit(string orderData)
        {
            var items = JsonConvert.DeserializeObject<List<ShoppingItem>>(orderData);

            double totalAmount = 0;
            foreach (var item in items)
            {
                totalAmount += Convert.ToDouble(item.Price.Replace("₺","")); // ₺5.99
            }

            ViewBag.TotalAmount = totalAmount;

            return View(items); // Order/Submit.cshtml adlı view'a yönlendir
        }

    }
}
