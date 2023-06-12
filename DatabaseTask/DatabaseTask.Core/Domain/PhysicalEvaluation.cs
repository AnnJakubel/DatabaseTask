using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PhysicalEvaluation
    {

        public Guid PhysicalEvalId { get; set; }

        public DateTime PhysicalEvaluationDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public String? Limitations { get; set; }

        public String? AidEquipment { get; set; }
    }
}
