﻿// <auto-generated />
using System;
using AlloeHRMSystem.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlloeHRMSystem.Persistence.Migrations
{
    [DbContext(typeof(AlloeContext))]
    [Migration("20200302050258_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<string>("BloodType")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContractType")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int?>("Department")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("HousePhone")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLeavedJob")
                        .HasColumnType("bit");

                    b.Property<string>("JobLocation")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LeaveJobDate")
                        .HasColumnType("date");

                    b.Property<string>("LeaveJobReason")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("LegalDayOff")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("QuitDate")
                        .HasColumnType("date");

                    b.Property<string>("Rank")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeAttachment", b =>
                {
                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar")
                        .HasMaxLength(50);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<int?>("FileId")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<int>("FileSize")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<int>("Type")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<string>("URLOnly")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("FileName");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeAttachments");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeCertificate", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Name");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeCertificates");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeEducation", b =>
                {
                    b.Property<int>("DegreeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<string>("Degree")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("EntranceDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("GraduationDate")
                        .HasColumnType("date");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<string>("StillStudying")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Thesis")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.HasKey("DegreeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeEducations");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeEmergencyCall", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("RelationTo")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SurName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Name");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeEmergencyCalls");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeLanguage", b =>
                {
                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<int>("LanguageId")
                        .HasColumnType("int")
                        .HasMaxLength(25);

                    b.Property<string>("NativeLang")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<int?>("SpeakingLevel")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<int?>("WrittenLevel")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.HasKey("Language");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeLanguages");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeProject", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Completed")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("Finish")
                        .HasColumnType("date");

                    b.Property<string>("JobPosition")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<int>("ProjectId")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<DateTime?>("Start")
                        .HasColumnType("date");

                    b.HasKey("Name");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeQuit", b =>
                {
                    b.Property<int>("ApproverId")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<string>("BANotes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<string>("BookKeepingAdvance")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("CHRAdvance")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("CHRNotes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<string>("CioNotes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<string>("CompanyIdCard")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CompanyVehicle")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("CreditCard")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<string>("GSMCard")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("HealthInsurance")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("MailSent")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Monitor")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Multinet")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PC")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneHeadSet")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("ProcessBegin")
                        .HasColumnType("date");

                    b.Property<DateTime?>("ProcessEnd")
                        .HasColumnType("date");

                    b.Property<bool>("Quit")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("QuitDate")
                        .HasColumnType("date");

                    b.Property<string>("QuitReason")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<string>("TrainingCancel")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("VehicleEntryStamp")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("ApproverId");

                    b.HasIndex("EmployeeId")
                        .IsUnique()
                        .HasFilter("[EmployeeId] IS NOT NULL");

                    b.ToTable("EmployeeQuits");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeTechnicalSkill", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<int?>("Level")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<int>("LevelId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<string>("Notes")
                        .HasColumnType("ntext")
                        .HasMaxLength(500);

                    b.Property<int>("SkillId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.HasKey("Name");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeTechnicalSkills");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeTraining", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int")
                        .HasMaxLength(30);

                    b.Property<DateTime?>("Finish")
                        .HasColumnType("date");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime?>("Start")
                        .HasColumnType("date");

                    b.HasKey("Name");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeTrainings");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.IdentityEntities.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.IdentityEntities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("CanMakeCall")
                        .HasColumnType("bit");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("date");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("Department")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastPasswordUpdate")
                        .HasColumnType("date");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ModifyBy")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("PasswordExpirationEnable")
                        .HasColumnType("bit");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeAttachment", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeAttachments")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeAttachments_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeCertificate", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeCertificates")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeCertificates_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeEducation", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeEducations")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeEducations_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeEmergencyCall", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeEmergencyCalls")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeEmergencyCalls_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeLanguage", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeLanguages")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeLanguages_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeProject", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeProjects_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeQuit", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithOne("EmployeeQuit")
                        .HasForeignKey("AlloeHRMSystem.Domain.Entities.EmployeeQuit", "EmployeeId")
                        .HasConstraintName("FK_EmployeeQuits_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeTechnicalSkill", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeTechnicalSkills")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeTechnicalSkills_Employees");
                });

            modelBuilder.Entity("AlloeHRMSystem.Domain.Entities.EmployeeTraining", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeTrainings")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_EmployeeTrainings_Employees");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.IdentityEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.IdentityEntities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AlloeHRMSystem.Domain.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AlloeHRMSystem.Domain.IdentityEntities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
