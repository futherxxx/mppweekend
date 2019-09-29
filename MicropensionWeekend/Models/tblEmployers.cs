namespace MicropensionWeekend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblEmployers
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string txtemployercode { get; set; }

        public string txtemployername { get; set; }

        public string txtaddress { get; set; }

        public string txtaddress1 { get; set; }

        [StringLength(50)]
        public string txtcity { get; set; }

        public long? LgaID { get; set; }

        [StringLength(50)]
        public string txtStateCode { get; set; }

        [StringLength(50)]
        public string txtbusinessnature { get; set; }

        [StringLength(50)]
        public string SectorCode { get; set; }

        [StringLength(50)]
        public string IndustryCode { get; set; }

        [StringLength(50)]
        public string CategoryCode { get; set; }

        public int? RetirementAge { get; set; }

        public int? retirement_LenService { get; set; }

        public long? InitiatorID { get; set; }

        public long? CountryID { get; set; }

        public int? Status { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? dteFirstUse { get; set; }

        public bool? isEmployerIPPIS { get; set; }

        public DateTime? dteIPPISDateJoined { get; set; }

        public long? iPPISNo { get; set; }

        public int? employerLocation { get; set; }

        [StringLength(50)]
        public string employerPhoneNumber { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public string oldemployername { get; set; }

        [StringLength(50)]
        public string oldemployercode { get; set; }

        [StringLength(30)]
        public string Registration_code { get; set; }

        public DateTime? dteChangedate { get; set; }

        public bool? isSubscribed { get; set; }
    }
}
