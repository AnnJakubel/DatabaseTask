namespace DatabaseTask.Core.Domain
{
    public class Branch
    {
        public Guid BranchId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

       public int RegisterCode { get; set; }

    }
}