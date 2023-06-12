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

        public Employee Employee { get; set; }

        public Branch Branch { get; set; }

        public String RequestDescription { get; set; }

        public DateOnly RequestSubmissionDate { get; set; }

        public String RequestStatus { get; set; }
        
    }
}
