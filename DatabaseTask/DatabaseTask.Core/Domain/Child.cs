using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public Guid ChildId { get; set; }

        public String ChildFullName { get; set; }
        
        public int ChildAgeInYears { get; set; }

        // FK
        public Employee EmployeeAsParent { get; set; }
        public Guid EmployeeId { get; set; }
    }
}