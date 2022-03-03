﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactNameSurname { get; set; }
        public string ContactMail { get; set; }
        public sbyte ContactPhoneNumber { get; set; }
        public string ContactSubject { get; set; }
        public string ContactContents { get; set; }
        public bool ContactStatus { get; set; }
    }
}
