using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MovieTheater
    {
        [Key]
        public int MovieTheaterID { get; set; }
        public string MovieTheaterName { get; set; }
        public bool MovieTheaterStatus { get; set; }
    }
}
