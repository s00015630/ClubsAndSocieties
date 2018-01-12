using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubsAndSocieties.Models
{
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Admin Email")]
        [EmailAddress]
        public string Email { get; set; }



        public virtual ICollection<Club> Clubs { get; set; }


        public virtual ICollection<Notification> Notifications { get; set; }

    }
}