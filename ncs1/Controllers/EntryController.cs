using com.sun.xml.@internal.bind.v2.model.core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ncs1.Data;
using ncs1.Models;
using ncs1.Models.Entry;

namespace ncs1.Controllers
{

    public class EntryController : Controller


    {
        public string EntryCategory { get; set; }

        private readonly ApplicationDbContext _context;
        private readonly UserManager<MyUser> _userManager;




        public EntryController(ApplicationDbContext context, UserManager<MyUser> userManager) { _context = context; _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
           var entryCategories = _context.EntryCategories.ToList();

           ViewBag.EntryCategoryList = new SelectList(entryCategories, "EntryCategoryId", "EntryCategoryName");

           return View();
        }

        [HttpPost]
        public IActionResult AddEntry(Entry entry)

        {
            
            //entry.EntryReference = Request.Form["EntryReference"];

            if (ModelState.IsValid)
            {
                _context.Entries.Add(entry);
                _context.SaveChanges();

                return View("SingleEntry", entry);
            }

            // If ModelState is not valid, return to the form with validation errors
            return View(entry);
        }

        [HttpGet("/EntryController/SingleEntry/{id}")]

        public IActionResult SingleEntry(Guid Id)
        {
            if (ModelState.IsValid)
            {
                Entry entry = _context.Entries.Where(c => c.EntryId == Id).FirstOrDefault();

                //return Content("{Some json value}");
                return View(entry);
            }


            return Content("Not Found");

        }
    }
}
