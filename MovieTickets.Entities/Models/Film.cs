using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Entities.Models
{
    public class Film : EntityBase
    {
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        public virtual ICollection<Seance> Seances { get; set; }

        public int? DirectorId { get; set; }

        public int? CategoryId { get; set; }

        public virtual Director Director { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Actor> Actors { get; set; } 
    }
}