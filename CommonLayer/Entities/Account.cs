using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Account
    {
        public int AccountId {  get; set; }
        public string AccountNumber {  get; set; }
        public decimal Saldo { get; set; }
        public string OpenDateAccount { get; set; }
        public int AccountTypeId { get; set; }
        public int ClientId { get; set; }


    }
}
