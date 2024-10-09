using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int AccountId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
    }
}
