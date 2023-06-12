using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Rental
    {
        [Key]
        public Guid RentalId { get; set; }

        public List<RentalItem> RentalItems { get; set; }

        public Employee RentingEmployee { get; set; }

        public DateOnly RentStartDate { get; set; }

        public DateOnly RentEndDate { get; set; }
    }
}
