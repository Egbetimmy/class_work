using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.models
{
    public class Account
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string BVN { get; set; }
        public string AccountName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
