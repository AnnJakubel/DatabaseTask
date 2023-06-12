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

        public DateOnly PhysicalEvaluationDate { get; set; }

        public DateOnly ExpirationDate { get; set; }

        public String? Limitations { get; set; }

        public String? AidEquipment { get; set; }
    }
}
