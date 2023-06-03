using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class JobTitleHistory
    {
        [Key]
        public Guid TitleHistoryId { get; set; }

        public List<string> JobTitles { get; set; }

        public JobTitleList JobTitleList { get; set; }

        public DateTime JobTitleStartDate { get; set; }

        public DateTime JobTitleDuration { get; set;}

    }
}