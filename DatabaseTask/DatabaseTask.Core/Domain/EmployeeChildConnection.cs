using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class EmployeeChildrenConnection
    {
        public Guid ConnectionId { get; set; }

        public Employee EmployeeAsParent { get; set; }

        public List<Child> Children { get; set; }
    }
}
