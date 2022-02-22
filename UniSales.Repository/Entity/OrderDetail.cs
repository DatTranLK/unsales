using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniSales.Repository.Entity
{
    public class OrderDetail
    {
        int Id { get; set; }
        int ProductId   { get; set; }
        int OrderId { get; set; }
        decimal Price { get; set; }
        int Quantity { get; set; }
    }
}
