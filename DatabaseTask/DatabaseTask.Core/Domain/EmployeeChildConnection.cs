using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class EmployeeChildrenConnection
    {
        [Key]
        public Guid ConnectionId { get; set; }

        public Employee EmployeeAsParent { get; set; }

        public List<Child> Children { get; set; }
    }
}
