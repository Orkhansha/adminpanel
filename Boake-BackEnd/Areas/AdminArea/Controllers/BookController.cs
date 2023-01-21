using Boake_BackEnd.DAL;
using Boake_BackEnd.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Boake_BackEnd.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _env;
        public BookController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Book> books = _context.Books.Where(b => !b.IsDeleted).ToList();
            return View(books);
        }
    }
}
