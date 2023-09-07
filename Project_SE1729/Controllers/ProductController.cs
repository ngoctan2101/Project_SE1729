using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project_SE1729.Models;

namespace Project_SE1729.Controllers
{
    public class ProductController : Controller
    {
        PRJ301_SE1648_HE151074_ProjectContext dbcontext = new PRJ301_SE1648_HE151074_ProjectContext(); 
       
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public IActionResult ListProduct(int Categoryid = 0)
        {
            List<Product> listproducts = new List<Product>();
            if(Categoryid != 0)
            {
                listproducts = dbcontext.Products.Include(x=>x.CidNavigation).Where(x => x.Cid == Categoryid).ToList();
            }
            else
            {
                listproducts = dbcontext.Products.ToList();
            }
            
            ViewBag.Categories = dbcontext.Categories;
            ViewBag.Products = listproducts;

            return View("Index");
        }
        public IActionResult AddCart(string Productid , int Categoryid)
        {
            return View("AddCart");
        }
    }
}
