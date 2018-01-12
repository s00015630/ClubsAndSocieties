using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubsAndSocieties.Models
{
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [ForeignKey("associatedAdministrator")]
        public int AdminID { get; set; }


        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime Date { get; set; }

        [Required()]

        public string Message { get; set; }


        public virtual Administrator associatedAdministrator { get; set; }
    }
}