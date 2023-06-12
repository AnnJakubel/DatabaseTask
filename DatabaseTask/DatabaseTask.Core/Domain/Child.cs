using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public Guid ChildId { get; set; }

        public String ChildName { get; set; }
        
        public int ChildAgeInYears { get; set; }

        public Employee EmployeeAsParent { get; set; }
    }
}