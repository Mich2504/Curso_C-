using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal GetValuetoPay()
        {
            return Price * (decimal) Quantity;
        }
        public override string ToString()
        {
            return $" {Id} - {Description}" +
                $"\n\tQuantity.......: {$"{Quantity:N2}",18}"+
                $"\n\tPrice..........: {$"{Price:C2}",18}" +
                $"\n\tValue..........: {$"{GetValuetoPay():C2}",18}" ;
        }
    }
}
