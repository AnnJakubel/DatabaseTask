using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Vacation
    {
        [Key]
        public Guid VacationId { get; set; }

        public Employee Employee { get; set; }

        public String VacationType { get; set; }

        public int VacationDurationInDays { get; set; }

        public DateTime VacationStartDate { get; set; }

        public DateTime VacationEndDate { get; set; }
    }
}
