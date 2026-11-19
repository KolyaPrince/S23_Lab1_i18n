using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class HuntingLog
    {
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 5)]

        [Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(255)]
        [Display(Name = "Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "ValidationRequired")]
        public string Description { get; set; }

        [Display(Name = "Adventure Date")]
        public DateTime AdventureDate { get; set; }


        [Display(Name = "Zombies")]
        [ValidateNever]
        public virtual List<Zombie> Zombies { get; set; }
    }
}
