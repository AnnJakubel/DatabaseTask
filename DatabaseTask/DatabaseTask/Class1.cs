using DatabaseTask.Core.Domain;

namespace DatabaseTask
{
    public class Requests
    {
        public Guid RequestId { get; set; }

        public Employee Employee { get; set; }

        public Branch Branch { get; set; }

        public String RequestDescription { get; set; }

        public DateTime SubmissionDate { get; set; }

        public String Status { get; set; }


    }
}
