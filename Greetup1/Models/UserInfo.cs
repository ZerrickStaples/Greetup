using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Greetup1.Models
{
    public class UserInfo
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        public string eMail { get; set; }

        [ForeignKey("RSVP")]
        [Display(Name = "RSVP")]
        public int RSVPID { get; set; }
        public virtual RSVP RSVP { get; set; }
    }
}