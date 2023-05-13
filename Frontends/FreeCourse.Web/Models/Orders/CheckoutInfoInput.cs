using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FreeCourse.Web.Models.Orders
{
    public class CheckoutInfoInput
    {
        [Display(Name = "year")]
        public string Province { get; set; }

        [Display(Name = "district")]
        public string District { get; set; }

        [Display(Name = "street")]
        public string Street { get; set; }

        [Display(Name = "zipCode")]
        public string ZipCode { get; set; }

        [Display(Name = "line")]
        public string Line { get; set; }

        [Display(Name = "card Name")]
        public string CardName { get; set; }

        [Display(Name = "card Number")]
        public string CardNumber { get; set; }

        [Display(Name = "Expiration date(month/year)")]
        public string Expiration { get; set; }

        [Display(Name = "CVV/CVC2 number")]
        public string CVV { get; set; }
    }
}
