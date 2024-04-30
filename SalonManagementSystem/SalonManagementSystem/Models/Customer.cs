using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManagementSystem.Models
{
    public class Customer: Person
    {
        public int customerTypeId { get; set; } = 4;
        public int addedBy { get; set; }
        public DateTime createdOn { get; set; } = DateTime.Now;
        public DateTime? updatedOn { get; set; }
        public int? updatedBy { get; set; }

    }
}
