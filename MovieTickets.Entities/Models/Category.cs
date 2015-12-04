using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTickets.Entities.Models
{
    public class Category : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
