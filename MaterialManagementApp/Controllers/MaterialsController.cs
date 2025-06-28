using Microsoft.AspNetCore.Mvc;
using MaterialManagementApp.Models;
using System.Collections.Generic;

namespace MaterialManagementApp.Controllers
{
    public class MaterialsController : Controller
    {
        private static List<Material> materials = new List<Material>
        {
            new Material { Id = 1, Name = "Tent", Description = "A large tent for camping", Quantity = 5 },
            new Material { Id = 2, Name = "Sleeping Bag", Description = "Warm sleeping bag for cold nights", Quantity = 10 },
            new Material { Id = 3, Name = "First Aid Kit", Description = "Basic first aid supplies", Quantity = 3 }
        };

        public IActionResult Index()
        {
            return View(materials);
        }

        public IActionResult Details(int id)
        {
            var material = materials.Find(m => m.Id == id);
            if (material == null)
            {
                return NotFound();
            }
            return View(material);
        }
    }
}