using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClubsAndSocieties.Models
{
    public class Club
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [ForeignKey("AssociatedAdministrator")]
        public int AdministratorID { get; set; }

        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Name { get; set; }


        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Chairperson { get; set; }


        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Secretary { get; set; }


        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Treasurer { get; set; }

        [Required()]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Must be a phone number")]
        public string Phone { get; set; }

        [Required()]
        [Display(Name = "Email Address")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required()]
        [StringLength(50, ErrorMessage = "Cannot be longer than 50 characters.")]
        public string Description { get; set; }

        public virtual Administrator AssociatedAdministrator { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Event> Events { get; set; }


    }
}