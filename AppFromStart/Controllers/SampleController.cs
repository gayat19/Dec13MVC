using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Controllers
{
    public class SampleController : Controller
    {
        private readonly IMemoryCache _cache;

        public SampleController(IMemoryCache cache)
        {
            _cache = cache;
            _cache.GetOrCreate<string>("myTime", cacheEntry =>
            {
                cacheEntry.SlidingExpiration = TimeSpan.FromSeconds(60);
                return "G3 " + DateTime.Now.ToString();
            });
        }
        public IActionResult Index(string name)
        {
            //TempData["Username"] = "Jim";
            HttpContext.Session.SetString("Username", name);
            return View();
            //return _cache.Get("myTime").ToString();
        }
        public IActionResult Second()
        {
            //ViewBag.Username = TempData.Peek("Username").ToString();
            ViewBag.Username = HttpContext.Session.GetString("Username").ToString();
            return View();
        }
    }
}
