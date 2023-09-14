using Microsoft.AspNetCore.Mvc;
using RecursionTree.Models;
using System.Diagnostics;

namespace RecursionTree.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        List<Node> nodes = new List<Node> {
            new Node {Id = 1, ParentId = null, Name = "Parent1",
            SubNode=new List<Node>{ 
            new Node {Id = 11, ParentId= 1 ,Name="child1",SubNode= new List<Node>{ new Node {Id = 111, ParentId= 1 ,Name= "grandchild" } }},
            new Node {Id = 22, ParentId = 1, Name = "child2"},
            new Node {Id = 33, ParentId = 1, Name = "child3" }, } },
            new Node {Id = 4, ParentId = 1, Name = "Parent2"},
            new Node {Id = 5, ParentId = 4, Name = "Parent3"},
            new Node {Id = 6, ParentId = 4, Name = "Parent4"}
            };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(nodes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}