using forumPeriferia.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Controllers
{
    public class CommentController : Controller
    {
        private UserManager<User> userManager;
        private ApplicationDbContext dbContext;

        public CommentController(UserManager<User> userManager, ApplicationDbContext dbContext)
        {
            // this.postService = postService;
            this.userManager = userManager;
            this.dbContext = dbContext;
        }
        public Tread GetTreadById(int id)
        {
            return dbContext.Treads.FirstOrDefault(x => x.Id == id);
        }
        /*
        public async Task<IActionResult> Create(Comment comment, int id)
        {
            User user = await userManager.GetUserAsync(User).ConfigureAwait(false);

            Tread tread = GetTreadById(id);
            Comment newComment = new Comment();

            newComment.Content = comment.Content;
            
            newComment.User = user;

            newComment.Tread = tread;

            newComment.TreadID = id;

            dbContext.Comments.Add(newComment);
            dbContext.SaveChanges();

            return RedirectToAction(nameof(Finish));
        }
        */
    }
}
