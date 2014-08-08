using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Koo.Web.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public int Status { get; set; }

        public ApplicationUser CreateUser { get; set; }

        public DateTime CreateTime { get; set; }

        public IList<OrderItem> Items { get; set; }
    }
}