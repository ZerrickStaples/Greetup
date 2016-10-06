using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Greetup1.Models
{
    public class RSVP
    {
        public int ID { get; set; }
        [Display(Name = "Date")]
        public string date { get; set; }
        public virtual ICollection<UserInfo> Info { get; set; }
    }
}