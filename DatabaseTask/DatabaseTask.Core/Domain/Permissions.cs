using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace DatabaseTask.Core.Domain
{
    public class Permissions
    {

        [Key]
        public Guid PermissionsId { get; set; }

        public List<JobTitle> JobTitleList { get; set; }

        //FK
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }

        public String PermissionsDescription { get; set; }

        public DateTime PermissionsGrantedDate { get; set; }

        public DateTime PermissionsExpirationDate { get; set; }
    }
}