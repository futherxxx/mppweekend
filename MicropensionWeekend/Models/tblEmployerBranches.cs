namespace MicropensionWeekend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmployerBranches
    {
        public long ID { get; set; }

        public long? EmployersID { get; set; }

        public long? TeamID { get; set; }

        public long? ReferenceEmployersID { get; set; }

        [StringLength(255)]
        public string txtEmployerBranchName { get; set; }

        [StringLength(200)]
        public string txtAddress { get; set; }

        [StringLength(200)]
        public string txtAddress1 { get; set; }

        [StringLength(50)]
        public string txtCity { get; set; }

        [StringLength(50)]
        public string txtLGAcode { get; set; }

        [StringLength(5)]
        public string txtStatecode { get; set; }

        [StringLength(50)]
        public string txtBatchID { get; set; }

        [StringLength(255)]
        public string txtContactPerson { get; set; }

        [StringLength(50)]
        public string txtContactEmail { get; set; }

        public DateTime? dtelastchange { get; set; }

        [StringLength(50)]
        public string txtEmployerCode { get; set; }

        public long? InitiatorID { get; set; }

        [StringLength(255)]
        public string txtAltEmployername { get; set; }

        public long? MergeID { get; set; }

        public int? Status { get; set; }

        public virtual tblEmployers tblEmployers { get; set; }

        public virtual tblEmployerBranches tblEmployerBranches2 { get; set; }
    }
}
