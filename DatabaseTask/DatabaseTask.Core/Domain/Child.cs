namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        public Guid ChildId { get; set; }

        public String ChildName { get; set; }
        
        public String ChildAge { get; set; }

        public Employee EmployeeAsParent { get; set; }
    }
}