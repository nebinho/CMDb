﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Models
{
    public class TopListDto
    {
        public string ImdbID { get; set; }
        public int numberOfLikes { get; set; }
        public int numberOfDislikes { get; set; }

    }
}
