﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieImageUrl { get; set; }
        public string MovieHorizontalImageUrl { get; set; }
        public DateTime MovieDate { get; set; }
        public string MovieCast { get; set; }
        public string MovieDirector { get; set; }
        public string YoutubeEmbed { get; set; }
        public sbyte MovieStatus { get; set; }

    }
}
