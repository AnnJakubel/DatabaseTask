using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Hint
    {
        [Key]
        public Guid HintId { get; set; }

        // FK
        public Branch Branch { get; set; }
        public Guid BranchId { get; set; }

        public String HintContent { get; set; }

        public DateTime HintSubmissionDate { get; set; }

        public String HintStatus { get; set; }


    }
}
