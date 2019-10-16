using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestPOC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string address { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Code { get; set; }
        [Column(TypeName = "bit")]
        public bool Checked { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? JoinedDate { get; set; }
    }
}
