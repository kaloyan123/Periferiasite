using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Data
{
    public class TreadDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Topic { get; set; }

        public int ReplyesNumber { get; set; }

        public string Content { get; set; }

        public string CreatedBy { get; set; }
        public string UserEmail { get; set; }

        public List<CommentDTO> Comments { get; set; }

    }
}
