using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PhysicalEvaluation
    {
        [Key]
        public Guid PhysicalEvalId { get; set; }

        // FK
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public DateTime PhysicalEvaluationDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public String? Limitations { get; set; }

        public String? AidEquipment { get; set; }
    }
}
