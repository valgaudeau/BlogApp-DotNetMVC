using DevDrive.Data;
using DevDrive.Models.Domain;
using DevDrive.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DevDrive.Controllers
{
    public class TagController : Controller
    {
        private readonly BlogDbContext _dbContext;

        public TagController(BlogDbContext db)
        {
            _dbContext = db;
        }

        [HttpGet]
        [ActionName("Index")]
        public IActionResult Index()
        {
            var allTags = _dbContext.Tags.ToList();

            return View(allTags);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagVM addTagVM)
        {
            var tag = new Tag
            {
                Name = addTagVM.Name,
                DisplayName = addTagVM.DisplayName,
            };

            _dbContext.Tags.Add(tag);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
