using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportStoreNetCore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }

        [BindNever]
        public ICollection<CartLine> Lines { get; set; }

        [Required(ErrorMessage = "Пожалуйста, заполните поле имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, заполните поля адреса")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Пожалуйста, заполните поле город")]
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
