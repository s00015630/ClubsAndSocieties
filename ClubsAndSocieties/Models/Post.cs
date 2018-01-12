using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubsAndSocieties.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [ForeignKey("AssociatedStudent")]
        public int StudentID { get; set; }

        [Required()]
        [ForeignKey("AssociatedEvent")]
        public int EventID { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }



        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Title { get; set; }


        [Required()]
        public string PostMessage { get; set; }


        public virtual Event AssociatedEvent { get; set; }

        public virtual Student AssociatedStudent { get; set; }
    }
}
