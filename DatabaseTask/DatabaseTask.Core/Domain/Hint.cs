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

        public Branch Branch { get; set; }

        public String HintContent { get; set; }

        public DateOnly HintSubmissionDate { get; set; }

        public String HintStatus { get; set; }


    }
}
