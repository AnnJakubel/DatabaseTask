using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Request
    {
        [Key]
        public Guid RequestId { get; set; }


        // FK
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }


        // FK
        public Branch Branch { get; set; }
        public Guid BranchId { get; set; }

        public String RequestDescription { get; set; }

        public DateTime RequestSubmissionDate { get; set; }

        public String RequestStatus { get; set; }
        
    }
}
