using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class JobTitleHistory
    {
        [Key]
        public Guid JobTitleHistoryId { get; set; }

        public string CurrentJobTitle { get; set; }

        public JobTitleList JobTitleList { get; set; }

        public DateTime JobTitleStartDate { get; set; }

        public DateTime JobTitleDuration { get; set;}

    }
}