using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seafood.Models
{
    [Table("Subscribers")]
    public class Subscriber
    {
        [Key]
        public int SubscriberId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email address is required.")]
        public string Email { get; set; }
    }
}
