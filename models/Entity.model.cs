using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tickets.models
{
    public class Entity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(10)]
        public string nit { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }

        [Required]
        [StringLength(30)]
        public string email { get; set; }

        [Required]
        [StringLength(10)]
        public string telephone { get; set; }
    }
}