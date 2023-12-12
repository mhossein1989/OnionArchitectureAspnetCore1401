using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Dtos
{
    public class CustomerDto 
    {
        public string CustomerName { get; set; }
        public string PurchasesProduct { get; set; }
        public string PaymentType { get; set; }
    }
}
