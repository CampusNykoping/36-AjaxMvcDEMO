using AjaxMvc.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace AjaxMvc.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET /demo/demo1
        [Route("demo1")]
        public ContentResult Demo1()
        {
            return Content("Hello, world!");
        }

        // GET /demo/demo2/{fullName}
        [Route("demo2/{fullName}")]
        public ContentResult Demo2 (string fullName)
        {
            return Content("Hello, " + fullName, "text/plain");
        }

        // GET /demo/demo3
        [Route("demo3")]
        public IActionResult Demo3()
        {
            var product = new Product()
            {
                Id = 1,
                Name = "Strykjärn",
                Price = 234
            };
            var result = new JsonResult(product);
            return result;
        }

        // GET /demo/demo4
        [Route("demo4")]
        public IActionResult Demo4()
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Strykjärn", Price = 234},
                new Product() { Id = 2, Name = "Elvisp", Price = 123},
                new Product() { Id = 3, Name = "Matberedare", Price = 1234},
            };

            var result = new JsonResult(products);
            return result;
        }
    }
}
