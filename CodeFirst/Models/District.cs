using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class District
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        [Required]
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
