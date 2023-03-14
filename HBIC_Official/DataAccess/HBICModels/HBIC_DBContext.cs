using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess.HBICModels
{
    public partial class HBIC_DBContext : DbContext
    {
        public HBIC_DBContext()
        {
        }

        public HBIC_DBContext(DbContextOptions<HBIC_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoreFieldSubjectCoop> CoreFieldSubjectCoops { get; set; }
        public virtual DbSet<CoreFieldUserCoop> CoreFieldUserCoops { get; set; }
        public virtual DbSet<CoreFieldUserInvestmentSpec> CoreFieldUserInvestmentSpecs { get; set; }
        public virtual DbSet<CoreFieldUserInvestmentType> CoreFieldUserInvestmentTypes { get; set; }
        public virtual DbSet<CoreLikeUser> CoreLikeUsers { get; set; }
        public virtual DbSet<CoreSubject> CoreSubjects { get; set; }
        public virtual DbSet<CoreSubjectGroup> CoreSubjectGroups { get; set; }
        public virtual DbSet<CoreUser> CoreUsers { get; set; }
        public virtual DbSet<FieldFile> FieldFiles { get; set; }
        public virtual DbSet<FieldFinacialFile> FieldFinacialFiles { get; set; }
        public virtual DbSet<FieldFirmFile> FieldFirmFiles { get; set; }
        public virtual DbSet<FieldHbiccoop> FieldHbiccoops { get; set; }
        public virtual DbSet<FieldInvestmentSpeciality> FieldInvestmentSpecialities { get; set; }
        public virtual DbSet<FieldInvestmentType> FieldInvestmentTypes { get; set; }
        public virtual DbSet<FieldLaboratory> FieldLaboratories { get; set; }
        public virtual DbSet<FieldMachine> FieldMachines { get; set; }
        public virtual DbSet<FieldSpeciality> FieldSpecialities { get; set; }
        public virtual DbSet<FieldSpecialityGroup> FieldSpecialityGroups { get; set; }
        public virtual DbSet<FieldTitle> FieldTitles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.1.183;Database=HBIC_DB;User=thang;Password=abc@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<CoreFieldSubjectCoop>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("CoreField_SubjectCoop");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.HbicCoop)
                    .WithMany(p => p.CoreFieldSubjectCoops)
                    .HasForeignKey(d => d.HbicCoopId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_SubjectCoop_Field_HBICCoop");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CoreFieldSubjectCoops)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_SubjectCoop_Core_Subject");
            });

            modelBuilder.Entity<CoreFieldUserCoop>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("CoreField_UserCoop");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HbiccoopId).HasColumnName("HBICCoopId");

                entity.HasOne(d => d.Hbiccoop)
                    .WithMany(p => p.CoreFieldUserCoops)
                    .HasForeignKey(d => d.HbiccoopId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_UserCoop_Field_HBICCoop");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreFieldUserCoops)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_UserCoop_Core_User");
            });

            modelBuilder.Entity<CoreFieldUserInvestmentSpec>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("CoreField_UserInvestmentSpec");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvestmentSpecValue).HasMaxLength(10);

                entity.HasOne(d => d.InvestmentSpecValueNavigation)
                    .WithMany(p => p.CoreFieldUserInvestmentSpecs)
                    .HasForeignKey(d => d.InvestmentSpecValue)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_UserInvestmentSpec_Field_InvestmentSpecialities");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreFieldUserInvestmentSpecs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_UserInvestmentSpec_Core_User");
            });

            modelBuilder.Entity<CoreFieldUserInvestmentType>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("CoreField_UserInvestmentTypes");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvestmentTypeValue).HasMaxLength(10);

                entity.HasOne(d => d.InvestmentTypeValueNavigation)
                    .WithMany(p => p.CoreFieldUserInvestmentTypes)
                    .HasForeignKey(d => d.InvestmentTypeValue)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_UserInvestmentTypes_Field_InvestmentTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreFieldUserInvestmentTypes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreField_UserInvestmentTypes_Core_User");
            });

            modelBuilder.Entity<CoreLikeUser>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("Core_LikeUsers");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoreSubject>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("Core_Subject");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CoreSubjects)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Core_Subject_Core_SubjectGroup");
            });

            modelBuilder.Entity<CoreSubjectGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("Core_SubjectGroup");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupTitle).HasMaxLength(50);
            });

            modelBuilder.Entity<CoreUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("Core_User");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.AddressSchoolWork).HasMaxLength(100);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.Career).HasMaxLength(100);

                entity.Property(e => e.Certificate).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DevelopmentStage).HasMaxLength(50);

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailCodeTime).HasColumnType("datetime");

                entity.Property(e => e.ExpectedWork).HasMaxLength(50);

                entity.Property(e => e.ExtraSkill).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FirstProductTime).HasColumnType("datetime");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.GroupCompanyName).HasMaxLength(100);

                entity.Property(e => e.GroupTitle).HasMaxLength(50);

                entity.Property(e => e.ImagePath).HasMaxLength(50);

                entity.Property(e => e.IndustrialArea).HasMaxLength(100);

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastPwdChanged).HasColumnType("datetime");

                entity.Property(e => e.LastSubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.LockoutTime).HasColumnType("datetime");

                entity.Property(e => e.ResetPassCodeTime).HasColumnType("datetime");

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.SchoolYear).HasMaxLength(50);

                entity.Property(e => e.SubjectTitle).HasMaxLength(50);

                entity.Property(e => e.TaxCode).HasMaxLength(100);

                entity.Property(e => e.TaxCodeTime).HasColumnType("datetime");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(10);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Zipcode)
                    .HasMaxLength(50)
                    .HasColumnName("ZIPCode");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CoreUsers)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Core_User_Core_SubjectGroup");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.CoreUsers)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Core_User_Field_Speciality");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.CoreUsers)
                    .HasForeignKey(d => d.SubjectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Core_User_Core_Subject");

                entity.HasOne(d => d.TitleNavigation)
                    .WithMany(p => p.CoreUsers)
                    .HasForeignKey(d => d.Title)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Core_User_Field_Title");
            });

            modelBuilder.Entity<FieldFile>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("Field_File");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileType).HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FieldFiles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Field_File_Core_User");
            });

            modelBuilder.Entity<FieldFinacialFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Field_FinacialFiles");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FilePath).HasMaxLength(150);

                entity.Property(e => e.SysId).HasColumnName("SysID");
            });

            modelBuilder.Entity<FieldFirmFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Field_FirmFiles");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FilePath).HasMaxLength(150);
            });

            modelBuilder.Entity<FieldHbiccoop>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("Field_HBICCoop");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<FieldInvestmentSpeciality>(entity =>
            {
                entity.HasKey(e => e.Value);

                entity.ToTable("Field_InvestmentSpecialities");

                entity.Property(e => e.Value).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SysId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<FieldInvestmentType>(entity =>
            {
                entity.HasKey(e => e.Value);

                entity.ToTable("Field_InvestmentTypes");

                entity.Property(e => e.Value).HasMaxLength(10);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SysId).ValueGeneratedOnAdd();

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<FieldLaboratory>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("Field_Laboratory");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LaboratoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<FieldMachine>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("Field_Machine");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.MachineId)
                    .HasMaxLength(100)
                    .HasColumnName("MachineID");

                entity.Property(e => e.MachineName).HasMaxLength(100);
            });

            modelBuilder.Entity<FieldSpeciality>(entity =>
            {
                entity.HasKey(e => e.SpecialityId);

                entity.ToTable("Field_Speciality");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.SpecialityGroup)
                    .WithMany(p => p.FieldSpecialities)
                    .HasForeignKey(d => d.SpecialityGroupId)
                    .HasConstraintName("FK_Field_Speciality_Field_SpecialityGroup");
            });

            modelBuilder.Entity<FieldSpecialityGroup>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.ToTable("Field_SpecialityGroup");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasMaxLength(50);

                entity.Property(e => e.GroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<FieldTitle>(entity =>
            {
                entity.HasKey(e => e.TitleCode);

                entity.ToTable("Field_Title");

                entity.Property(e => e.TitleCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TitleId).ValueGeneratedOnAdd();

                entity.Property(e => e.TitleName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
