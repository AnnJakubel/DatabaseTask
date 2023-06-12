using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Employee {

        [Key]
        public Guid EmployeeId { get; set; }

        public String Name { get; set; }

        public JobTitleHistory JobTitleHistory { get; set; }

        public Branch Branch { get; set; }

        public int SocialSecurityNumber { get; set; }

        public string Address { get; set; }

        public string BankAccount { get; set; }

        public DateOnly ContractStartDate { get; set; }

        public DateOnly? ContractEndingDate { get; set; }



    }
}
