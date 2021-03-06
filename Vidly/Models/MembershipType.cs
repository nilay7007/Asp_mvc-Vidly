using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        public string Name { set; get; }
        public short SignUpFee { get; set; }
        public byte DurationInMonts { get; set; }
        public byte DiscountedRate { get; set; }
    }
}