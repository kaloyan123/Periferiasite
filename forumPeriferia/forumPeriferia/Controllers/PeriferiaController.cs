using forumPeriferia.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Controllers
{
    public class PeriferiaController : Controller
    {
        private ApplicationDbContext dbContext;

        public PeriferiaController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public PerifernaChast GetById(int id)
        {
            return dbContext.PeriferniChasti.FirstOrDefault(x => x.Id == id);
        }

        public List<PerifernaChast> GetAll()
        {

            return dbContext.PeriferniChasti
                //.Select(x => x.Type == )
                .ToList();
        }

        /*
        private static PostDTO ToDto(Post p)
        {
            PostDTO post = new PostDTO();

            post.Id = p.Id;
            post.Name = p.Name;
            post.Content = p.Content;
            post.Spaces = p.Spaces;
            post.CreatedBy = $"{p.User.Userusername}";
            post.UserEmail = p.User.Email;

            return post;
        }
        */

        public IActionResult Vhodnilist()
        {
            List<PerifernaChast> periferniChasti = dbContext.PeriferniChasti
                .ToList();

            return View(periferniChasti);
        }

        public IActionResult Zapomniashtilist()
        {
            List<PerifernaChast> periferniChasti = dbContext.PeriferniChasti
                .ToList();

            return View(periferniChasti);
        }
        
        public IActionResult Ishodnilist()
        {
            List<PerifernaChast> periferniChasti = dbContext.PeriferniChasti
                .ToList();

            return View(periferniChasti);
        }

        public IActionResult Vhodnoishodnilist()
        {
            List<PerifernaChast> periferniChasti = dbContext.PeriferniChasti
                .ToList();

            return View(periferniChasti);
        }

        public IActionResult Preview(int id)
        {
            PerifernaChast perifernaChast = GetById(id);

            return View(perifernaChast);
        }

        
        public IActionResult AddPeriferia()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditPeriferia(int id)
        {
            PerifernaChast perifernaChast = GetById(id);

            return View(perifernaChast);
        }
        /*
         
    <select class="form-outline custom-select form-white mb-4" aria-label="Default select example" name="Type">
        <option selected value="">Coose Type</option>
        <option value="vhodni">vhodni</option>
        <option value="ishodni">ishodni</option>
        <option value="vhodnoishodni">vhodnoishodni</option>
    </select>
         */

        [HttpPost]
        public IActionResult Add(PerifernaChast perifernaChast)
        {
            dbContext.PeriferniChasti.Add(perifernaChast);
            dbContext.SaveChanges();
            if (perifernaChast.Type== "vhodni")
            {
                return RedirectToAction(nameof(Vhodnilist));
            }
            else if (perifernaChast.Type == "ishodni")
            {
                return RedirectToAction(nameof(Ishodnilist));
            }
            else
            {
                return RedirectToAction(nameof(Vhodnoishodnilist));
            }
        }

        [HttpPost]
        public IActionResult Edit(PerifernaChast perifernaChast)
        {
            PerifernaChast dbchast = GetById(perifernaChast.Id);
            dbchast.Name = perifernaChast.Name;
            dbchast.Istoria = perifernaChast.Istoria;
            dbchast.Klasificatsia = perifernaChast.Klasificatsia;
            dbchast.Ustroistvo = perifernaChast.Ustroistvo;
            dbchast.ProcesNaDeisvie = perifernaChast.ProcesNaDeisvie;
            dbContext.SaveChanges();

            /*
        public string Type { get; set; }
        */

            return RedirectToAction(nameof(Vhodnilist));
        }

        public IActionResult Delete(int id)
        {
            PerifernaChast dbchast = GetById(id);
            dbContext.PeriferniChasti.Remove(dbchast);
            dbContext.SaveChanges();

            return RedirectToAction(nameof(Vhodnilist));
        }

        /*
         public async Task<IActionResult> Add(PerifernaChast perifernaChast)
        {

            dbContext.PeriferniChasti.Add(perifernaChast);
            dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Add()
        {
            return View();
        }
        */
    }
}
