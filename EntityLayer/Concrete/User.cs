﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public int Name { get; set; }
        public int Surname { get; set; }
        public int UserSurname { get; set; }
        public int Mail { get; set; }
        public int Password { get; set; }
        public int ImageURL { get; set; }
        public bool Status { get; set; }
        public List<UserMessage> UserMessages { get; set; }
    }
}
