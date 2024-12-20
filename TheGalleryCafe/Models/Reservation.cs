using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheGalleryCafe.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Reservation
    {

        public int ReservationID { get; set; }
   
        [Required(ErrorMessage = "Customer name is required.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Please enter a valid 10-digit mobile number.")]
        public string ContactNumber { get; set; }

        public string Email { get; set; }
        [Required(ErrorMessage = "Reservation date is required.")]
        [DataType(DataType.DateTime)]
        public DateTime ReservationDate { get; set; }

        [Required(ErrorMessage = "Table number is required.")]
        public int TableNumber { get; set; }

        [Required(ErrorMessage = "Number of guests is required.")]
        [Range(1, 20, ErrorMessage = "Number of guests must be between 1 and 20.")]
        public int NumberOfGuests { get; set; }
        public string SpecialRequests { get; set; }
        public bool IsConfirmed { get; set; }
    }


}