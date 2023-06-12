using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class JobTitle
    {
        [Key]
        public Guid JobTitleId { get; set; }

        public String Title { get; set; }

        // FK
        public Branch Branch { get; set; }
        public Guid BranchId { get; set; }

    }
}