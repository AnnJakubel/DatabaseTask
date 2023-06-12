using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public Guid SickLeaveId { get; set; }

        // FK
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public String SickLeaveType { get; set; }

        public int SickLeaveDurationInDays { get; set; }

        public DateTime SickLeaveStartDate { get; set; }

        public DateTime SickLeaveEndDate { get; set; }



    }
}
