using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class JobTitleList
    {
        [Key]
        public Guid JobTitleListId { get; set; }

        public List<String> JobTitles { get; set; }

        public Branch Branch { get; set; }

    }
}