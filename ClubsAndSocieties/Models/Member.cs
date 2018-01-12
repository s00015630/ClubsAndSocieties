using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClubsAndSocieties.Models
{
    public class Member
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [ForeignKey("AssociatedStudent")]
        public int StudentID { get; set; }

        [Required()]
        [ForeignKey("AssociatedClub")]
        public int ClubID { get; set; }

        [Required()]
        [Display(Name = "Date Joined")]
        public DateTime DateJoined { get; set; }


        public virtual Club AssociatedClub { get; set; }

        public virtual Student AssociatedStudent { get; set; }
    }
}