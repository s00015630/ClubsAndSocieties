using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace ClubsAndSocieties.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [ForeignKey("AssociatedClub")]
        public int ClubID { get; set; }

        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 30 characters.")]
        public string Title { get; set; }


        [Required()]

        public string Description { get; set; }


        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }


        [Required()]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }


        public bool PublicClubEvent { get; set; }

        public virtual Club AssociatedClub { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}