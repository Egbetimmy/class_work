using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wema.BIT.modules
{
    public class Payment
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public int PaymentId { get; set; }
        public int PayAmount { get; set; }

        public virtual Users Users { get; set; } 
    }
}
