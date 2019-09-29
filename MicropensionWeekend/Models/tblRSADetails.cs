namespace MicropensionWeekend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblRSADetails
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string RefCode { get; set; }

        [Required]
        [StringLength(50)]
        public string txtsurname { get; set; }

        [Required]
        [StringLength(50)]
        public string txtfirstname { get; set; }

        [StringLength(50)]
        public string txtothernames { get; set; }

        [StringLength(200)]
        public string txtpreviousname { get; set; }

        [StringLength(50)]
        public string txttitle { get; set; }

        [StringLength(1)]
        public string txtgender { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(20)]
        public string txtFormRefno { get; set; }

        [StringLength(15)]
        public string txtNominalPIN { get; set; }

        [StringLength(15)]
        public string txtPIN { get; set; }

        [StringLength(20)]
        public string txtIndexno { get; set; }

        [StringLength(30)]
        public string txtmobilePhone { get; set; }

        [StringLength(20)]
        public string txtAlt_phoneno { get; set; }

        [StringLength(100)]
        public string txtEmailaddress { get; set; }

        public long? MaritalStatusID { get; set; }

        public long? EmployersID { get; set; }

        [StringLength(50)]
        public string txtEmployerCode { get; set; }

        [Column(TypeName = "ntext")]
        public string Employee_Directorate { get; set; }

        public string Employee_Department { get; set; }

        [Column(TypeName = "ntext")]
        public string Employee_Unit { get; set; }

        [StringLength(20)]
        public string txtemployeeidNo { get; set; }

        [StringLength(20)]
        public string txtserviceidNo { get; set; }

        [StringLength(50)]
        public string txtdesignation { get; set; }

        [StringLength(50)]
        public string txtofficephone { get; set; }

        [StringLength(50)]
        public string txtofficeemail { get; set; }

        public DateTime? dteDOFA { get; set; }

        public DateTime? dtecurrentEmployment { get; set; }

        public decimal? nummonthlyemolument { get; set; }

        public decimal? numexpectedERcontributions { get; set; }

        public decimal? numexpectedEEcontributions { get; set; }

        public decimal? numAVC { get; set; }

        public decimal? numAnnualSalary { get; set; }

        public decimal? numAnnualTransAllowance { get; set; }

        public decimal? numAnnualRentAllowance { get; set; }

        public int? txtbatchid { get; set; }

        public long? UserID { get; set; }

        public DateTime? dteCreateddate { get; set; }

        public DateTime? dtePINdate { get; set; }

        public DateTime? dtelastchange { get; set; }

        public long? EmployerBranchID { get; set; }
        public virtual tblEmployerBranches TblEmployerBranches{get;set;}

        public long? initiatorID { get; set; }

        public int? investor_id { get; set; }

        public bool? isBiometricCaptured { get; set; }

        public bool? isDisabled { get; set; }

        public long? RSALGAOfOriginID { get; set; }

        public bool? inSybase { get; set; }

        [StringLength(20)]
        public string txtAgentCode { get; set; }

        public long? TeamID { get; set; }

        public long? TeamLeaderID { get; set; }

        public int? rsaStatus { get; set; }

        public int? StatusCategory { get; set; }

        [StringLength(50)]
        public string StatusSubCategory { get; set; }

        public long? DepartmentID { get; set; }

        public long? OldEmployerBranchID { get; set; }

        public DateTime? dteConfirmed { get; set; }

        public DateTime? dteDOFE { get; set; }

        [StringLength(15)]
        public string BVN { get; set; }

        [StringLength(50)]
        public string NIN { get; set; }

        [StringLength(50)]
        public string IDType { get; set; }

        [StringLength(50)]
        public string InternationalNumber { get; set; }

        [StringLength(50)]
        public string GradeLevel { get; set; }

        [StringLength(2)]
        public string Step { get; set; }

        public DateTime? dteEDOP { get; set; }

        [StringLength(50)]
        public string InternationalPassportNo { get; set; }

        [StringLength(50)]
        public string NatureOfBusiness { get; set; }

        public int? VitalDocument { get; set; }

        public int? EStatement { get; set; }

        public int? SectorClassification { get; set; }

        public DateTime? dteReport { get; set; }

        public DateTime? EffectiveDate { get; set; }

        [StringLength(250)]
        public string VerifiedEmail { get; set; }

        [StringLength(50)]
        public string VerifiedMobileNumber { get; set; }

        [StringLength(255)]
        public string RSAwithdrawals { get; set; }

        [StringLength(50)]
        public string SecAgentCode { get; set; }

        public bool? inFPCNL { get; set; }

        [StringLength(250)]
        public string dmsPath { get; set; }

        [StringLength(50)]
        public string PIN_LETTER_Batch { get; set; }

        public int? SchemeID { get; set; }

        [StringLength(20)]
        public string txtOldPIN { get; set; }

        public DateTime? PIN_Change_date { get; set; }

        [StringLength(30)]
        public string txtPreferred_Title { get; set; }

        public int? ArchiveStatus { get; set; }

        [StringLength(20)]
        public string txtpin2 { get; set; }

        [StringLength(20)]
        public string txtpin3 { get; set; }

        [StringLength(20)]
        public string txtpin4 { get; set; }

        [StringLength(100)]
        public string txtPINstatus { get; set; }

        [StringLength(20)]
        public string txtvalidPIN { get; set; }

        [StringLength(255)]
        public string txtValidPIN_PFA { get; set; }

        public int? RSACategory { get; set; }

        [StringLength(50)]
        public string MPContributionType { get; set; }

        public decimal? MPContributionAmount { get; set; }

        [StringLength(255)]
        public string InvalidPIN_Comments { get; set; }

        public DateTime? Date_PIN_Invalidated { get; set; }

        [StringLength(100)]
        public string txtPfaName2 { get; set; }

        [StringLength(100)]
        public string txtPfaName3 { get; set; }

        [StringLength(100)]
        public string txtPfaName4 { get; set; }

        public int? PINType2 { get; set; }

        public int? PINType3 { get; set; }

        public int? PINType4 { get; set; }

        [StringLength(12)]
        public string refnumber { get; set; }

        public int? isRecaptureSMS { get; set; }

        public int? isEmailSent { get; set; }

        public int? isRefNum { get; set; }

        [StringLength(255)]
        public string txtPlaceOfBirth { get; set; }

        [StringLength(255)]
        public string txtMaidenName { get; set; }

        [StringLength(255)]
        public string TxtMotherMaidenName { get; set; }

        public bool? isRecaptured { get; set; }
    }
}
