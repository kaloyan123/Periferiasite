using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Data
{
    public class CommentDTO
    {
        public int Id { get; set; }

        public string Content { get; set; }

       // public int CreatedOnId { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedByEmail { get; set; }

        public int TreadID { get; set; }

    }
}
