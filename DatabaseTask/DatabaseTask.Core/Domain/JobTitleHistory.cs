using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class JobTitleHistory
    {
        [Key]
        public Guid JobTitleHistoryId { get; set; }

        public String CurrentJobTitle { get; set; }

        public List<JobTitle> JobTitleList { get; set; }

        public DateTime JobTitleStartDate { get; set; }

        public int JobTitleDurationInDays { get; set;}

    }
}