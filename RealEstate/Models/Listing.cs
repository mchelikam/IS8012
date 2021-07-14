using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RealEstate.Models
{
    public class Listing
    {
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Listing")]
        public DateTime? DateOfListing { get; set; }

        [Display(Name = "Expected Price")]
        public decimal? ExpectedPrice { get; set; }

        public bool Available { get; set; }
    }
}
