namespace DatabaseTask.Core.Domain
{
    public class Branch
    {
        public Guid BranchId { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

       public int RegisterCode { get; set; }

    }
}