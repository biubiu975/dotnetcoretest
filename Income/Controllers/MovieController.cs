using System.Configuration;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Demo2.Controllers
{
    public class MovieController : Controller
    {
        private readonly DataContext db;

        public MovieController(DataContext db)
        {
            this.db = db;
        }

        // GET
        public IActionResult Index()
        {
            //https://blog.csdn.net/dxb601/article/details/79563834
            var movies = db.movies.OrderBy(t => t.id).ToList();
            return View();
        }

        public ViewResult ReadConfigure()
        {
//            IConfiguration configuration = new ConfigurationBuilder();
            return View();
        }
    }
}