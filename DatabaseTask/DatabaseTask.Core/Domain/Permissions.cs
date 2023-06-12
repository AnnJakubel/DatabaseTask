using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
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
        public Guid PermissionsId { get; set }

        public JobTitleList JobTitleList { get; set; }

        public Employee Employee { get; set; }

        public String PermissionsDescription { get; set; }

        public DateOnly PermissionsGrantedDate { get; set; }

        public DateOnly PermissionsExpirationDate { get; set; }
    }
}