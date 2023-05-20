using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_Application.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; } 
        public int Age { get;set; }
        public string Address { get; set; } 
        public string City { get; set; }    
        public string Phone{ get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string BankCard { get; set; }
        public DateTime OrderedData { get; set; } = DateTime.Now;
    }
}
