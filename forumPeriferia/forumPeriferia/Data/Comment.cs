using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Data
{
    public class Comment
    {
        public int Id { get; set; }

        public string Content { get; set; }

        [ForeignKey("User")]
        public int UseerId { get; set; }
        public User User { get; set; }

        [ForeignKey("Tread")]
        public int TreadID { get; set; }
        public Tread Tread { get; set; }
    }
}
