using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace TheGalleryCafe.Models
{
    public class Carts
    {
        [Key]
        public int CartID { get; set; } 
        public string UserID { get; set; } 
        public DateTime CreatedDate { get; set; } 
        public bool IsCheckedOut { get; set; } 
    }
}