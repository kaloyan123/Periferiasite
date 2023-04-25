using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Data
{
    public class Tread
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Topic { get; set; }

        public int ReplyesNumber { get; set; }

        public string Content { get; set; }

        [ForeignKey("User")]
        public int UseerId { get; set; }
        public User User { get; set; }

    }
}
