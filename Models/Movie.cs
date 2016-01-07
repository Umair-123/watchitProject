﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WatchIt.Models
{
   
        public class Movie
        {
            public int MovieId { get; set; }

            public string Title { get; set; }

            public string Director { get; set; }

            public int YearReleased { get; set; }

            public string PosterImage { get; set; }

        }
    
}