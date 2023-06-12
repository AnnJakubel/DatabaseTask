﻿using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class RentalItem
    {
        [Key]
        public Guid ItemId { get; set; }

        public String ItemName { get; set; }


        // FK
        public Branch Branch { get; set; }
        public Guid BranchId { get; set; }

        public String Description { get; set; }
    }
}