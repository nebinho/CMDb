﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMDb_Grupp13.Models
{
    public class SearchDto
    {
       public IEnumerable<MovieSearchDto> Search { get; set; }
        
    }
}
