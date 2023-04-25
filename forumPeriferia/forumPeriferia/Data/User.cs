using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forumPeriferia.Data
{
    public class User : IdentityUser<int>
    {
         public string Userusername { get; set; }

        public string Useremail { get; set; }

    }
}
