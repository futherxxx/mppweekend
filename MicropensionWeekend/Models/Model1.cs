namespace MicropensionWeekend.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tblEmployerBranches> tblEmployerBranches { get; set; }
        public virtual DbSet<tblEmployers> tblEmployers { get; set; }
        public virtual DbSet<tblRSADetails> tblRSADetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblEmployerBranches>()
                .Property(e => e.txtBatchID)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmployerBranches>()
                .Property(e => e.txtContactPerson)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmployerBranches>()
                .Property(e => e.txtContactEmail)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmployerBranches>()
                .Property(e => e.txtEmployerCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblEmployerBranches>()
                .HasOptional(e => e.tblEmployerBranches1)
                .WithRequired(e => e.tblEmployerBranches2);

            modelBuilder.Entity<tblEmployers>()
                .Property(e => e.employerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.RefCode)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.txtgender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.txtPIN)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.txtmobilePhone)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.Employee_Department)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.txtPreferred_Title)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.refnumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.txtPlaceOfBirth)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.txtMaidenName)
                .IsUnicode(false);

            modelBuilder.Entity<tblRSADetails>()
                .Property(e => e.TxtMotherMaidenName)
                .IsUnicode(false);
        }
    }
}
