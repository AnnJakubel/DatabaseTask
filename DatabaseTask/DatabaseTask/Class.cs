using DatabaseTask.Core.Domain;

namespace DatabaseTask
{
    public class Permissions
    {
        public Guid PermissionsId { get; set; }

        public JobTitleList JobTitleList { get; set; }

        public Employee Employee { get; set; }

        public String Description { get; set; }

        public DateTime ValidityStartDate { get; set; }

        public DateTime? ValidityEndDate { get; set; }


    }
}
