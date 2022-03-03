using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class GeneralAudience
    {
        [Key]
        public int GeneralAudienceID { get; set; }
        public string GeneralAudienceImageUrl { get; set; }
        public bool GeneralAudienceStatus { get; set; }
        public int MovieID { get; set; }
        public Movie Movie { get; set; }
    }
}
