using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CustomerAPI.Models
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; } = null!;
        [StringLength(100)]
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
