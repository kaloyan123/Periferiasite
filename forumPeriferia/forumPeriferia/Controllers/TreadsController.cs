using forumPeriferia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Controllers
{
    public class TreadsController : Controller
    {

       // private PostService postService;
        private UserManager<User> userManager;
        private ApplicationDbContext dbContext;

        public TreadsController(UserManager<User> userManager, ApplicationDbContext dbContext)
        {
           // this.postService = postService;
            this.userManager = userManager;
            this.dbContext = dbContext;
        }
        private static TreadDTO ToDto(Tread t)
        {
            TreadDTO tread = new TreadDTO();

            tread.Id = t.Id;
            tread.Name = t.Name;
            tread.Topic = t.Topic;
            tread.ReplyesNumber = t.ReplyesNumber;
            tread.Content = t.Content;
            tread.CreatedBy = $"{t.User.Userusername}";
            tread.UserEmail = t.User.Email;

            return tread;
        }
        private static CommentDTO CommentToDto(Comment c)
        {
            CommentDTO commet = new CommentDTO();

            commet.Id = c.Id;
            commet.Content = c.Content;
            commet.TreadID = c.TreadID;
            commet.CreatedBy = $"{c.User.Userusername}";
            commet.CreatedByEmail = c.User.Email;

            return commet;
        }
        public List<CommentDTO> TreadComents(int id)
        {
            List<CommentDTO> comments = dbContext.Comments.Include(p => p.User).Where(p => p.TreadID == id).
                Select(p => CommentToDto(p)).ToList<CommentDTO>();

            return comments;
        }

        private TreadDTO ToDtowComments(Tread t)
        {
           // List<Comment> comments = dbContext.Comments.Where(p => p.TreadID == t.Id).ToList<Comment>();

            TreadDTO tread = new TreadDTO();

            tread.Id = t.Id;
            tread.Name = t.Name;
            tread.Topic = t.Topic;
            tread.ReplyesNumber = t.ReplyesNumber;
            tread.Content = t.Content;
            tread.CreatedBy = $"{t.User.Userusername}";
            tread.UserEmail = t.User.Email;
            tread.Comments = TreadComents(t.Id);

            return tread;
        }

        public List<TreadDTO> GetAll()
        {
            return dbContext.Treads
                .Include(p => p.User)
                .Select(p => ToDto(p))
                .ToList();
        }
        public List<TreadDTO> GetAllByTopic(string topic)
        {
            return dbContext.Treads
                .Where(p => p.Topic == topic)
                .Include(p => p.User)
                .Select(p => ToDto(p))
                .ToList();

           // return dbContext.Treads.Include(p => p.User).FirstOrDefault(x => x.Topic == topic);
        }

        public Tread GetById(int id)
        {
            return dbContext.Treads.FirstOrDefault(x => x.Id == id);
        }
        public Tread GetByIdwUser(int id)
        {
            return dbContext.Treads.Include(p => p.User).FirstOrDefault(x => x.Id == id);
        }
        
        public Comment CommentGetById(int id)
        {
            return dbContext.Comments.FirstOrDefault(x => x.Id == id);
        }

        public List<PerifernaChast> GetAllP()
        {
            return dbContext.PeriferniChasti
                .ToList();
        }

        public void Createnew(Tread tread, User user)
        {
            tread.User = user;

            dbContext.Treads.Add(tread);
            dbContext.SaveChanges();
        }

        public void Deletetread(int id)
        {
            Tread dbtread = GetById(id);
            dbContext.Treads.Remove(dbtread);
            dbContext.SaveChanges();
        }

        public void Edittread(Tread tread)
        {
            Tread dbtread = GetById(tread.Id);
            dbtread.Content = tread.Content;
            dbContext.SaveChanges();
        }
        public void Incrementtread(Tread tread)
        {
            Tread dbtread = GetById(tread.Id);
            dbtread.ReplyesNumber = dbtread.ReplyesNumber+1;
            dbContext.SaveChanges();
        }

        public void Changecomment(Comment coment)
        {
            Comment dbcomment = CommentGetById(coment.Id);
            dbcomment.Content = coment.Content;
            dbContext.SaveChanges();
        }

        public IActionResult TreadsAll()
        {
            List<TreadDTO> posts = GetAll();

            return View(posts);
        }
        
        public IActionResult TreadsPerifaira(string type)
        {
            List<TreadDTO> posts = GetAllByTopic(type);

            return View(posts);
        }

        public IActionResult Preview(int id)
        {
            Tread tread = GetByIdwUser(id);

            TreadDTO tradr = ToDtowComments(tread);

            return View(tradr);
        }

        public IActionResult Create()
        {
            List<PerifernaChast> chasti = GetAllP();

            return View(chasti);
        }
        public IActionResult Edit(int id)
        {
            Tread tread = GetById(id);

            return View(tread);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Tread tread)
        {
            User user = await userManager.GetUserAsync(User).ConfigureAwait(false);

            Createnew(tread, user);

            return RedirectToAction(nameof(TreadsAll));
        }

        [HttpPost]
        public IActionResult Edit(Tread tread)
        {
            Edittread(tread);

            return RedirectToAction("Preview", new { id = tread.Id });
        }

        public IActionResult Delete(int id)
        {
            Deletetread(id);

            return RedirectToAction(nameof(TreadsAll));
        }

        public async Task<IActionResult> CreateComment(Comment comment, int trid)
        {
            User user = await userManager.GetUserAsync(User).ConfigureAwait(false);

            Console.WriteLine(trid);

            Tread tread = GetById(trid);
            Incrementtread(tread);

            Comment newComment = new Comment();

            newComment.Content = comment.Content;

            newComment.User = user;

            newComment.Tread = tread;


            newComment.TreadID = trid;

            dbContext.Comments.Add(newComment);
            dbContext.SaveChanges();

            // "Preview", new { id = 99 }
            // nameof(Preview(trid))

            return RedirectToAction("Preview", new { id = trid });
        }

        public IActionResult DeleteComment(int comid)
        {
            Comment dbpost = CommentGetById(comid);
            int trid = dbpost.TreadID;
            dbContext.Comments.Remove(dbpost);
            dbContext.SaveChanges();

            return RedirectToAction("Preview", new { id = trid });
        }
        public IActionResult EditC(int id)
        {
            Comment comment = CommentGetById(id);

            return View(comment);
        }

        public IActionResult EditComment(Comment comment)
        {
            Changecomment(comment);

            return RedirectToAction("Preview", new { id = comment.TreadID });
        }
    }
}
