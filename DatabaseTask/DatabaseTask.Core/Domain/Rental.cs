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


        // FK
        public Employee RentingEmployee { get; set; }
        public Guid EmployeeId { get; set; }

        public DateTime RentStartDate { get; set; }

        public DateTime RentEndDate { get; set; }
    }
}
