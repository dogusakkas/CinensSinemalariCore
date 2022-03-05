using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }
        public string BranchName { get; set; }
        public bool BranchStatus { get; set; }
    }
}
