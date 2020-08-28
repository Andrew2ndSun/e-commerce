using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        [Display(Name = "Customer Name")]
        public string CustomerInfo { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string PaymentMethod { get; set; }

        [Display(Name = "Name on Card")]
        public string NameOnCard { get; set; }

        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Display(Name = "EXP Day")]
        public string ExpDay { get; set; }

        [Display(Name = "Security Code")]
        public string SecCode { get; set; }
        

        public DateTime? DateAdded { get; set; }
        public int? Status { get; set; }
        public ICollection<OrderInfo> OrderInfos { get; set; }
    }
}
