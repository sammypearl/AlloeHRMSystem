using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlloeHRMSystem.Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    MobileNo = table.Column<string>(maxLength: 30, nullable: true),
                    Language = table.Column<string>(maxLength: 50, nullable: true),
                    Company = table.Column<string>(maxLength: 50, nullable: true),
                    Department = table.Column<int>(maxLength: 50, nullable: true),
                    JobTitle = table.Column<string>(maxLength: 50, nullable: true),
                    HomePhone = table.Column<string>(maxLength: 30, nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    ModifyBy = table.Column<string>(maxLength: 50, nullable: true),
                    LastPasswordUpdate = table.Column<DateTime>(type: "date", nullable: true),
                    PasswordExpirationEnable = table.Column<bool>(nullable: false),
                    CanMakeCall = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: false),
                    Firstname = table.Column<string>(maxLength: 50, nullable: true),
                    Lastname = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 30, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    HomeAddress = table.Column<string>(maxLength: 60, nullable: true),
                    Department = table.Column<int>(maxLength: 50, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    JobTitle = table.Column<string>(maxLength: 50, nullable: true),
                    Rank = table.Column<string>(maxLength: 50, nullable: true),
                    BloodType = table.Column<string>(maxLength: 30, nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(maxLength: 20, nullable: true),
                    PhotoPath = table.Column<string>(maxLength: 255, nullable: true),
                    Nationality = table.Column<string>(maxLength: 50, nullable: true),
                    HousePhone = table.Column<string>(maxLength: 30, nullable: true),
                    ContractType = table.Column<string>(maxLength: 50, nullable: true),
                    JobLocation = table.Column<string>(maxLength: 50, nullable: true),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "date", nullable: true),
                    LastModifiedBy = table.Column<string>(maxLength: 50, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    QuitDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsLeavedJob = table.Column<bool>(nullable: false),
                    LeaveJobDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeaveJobReason = table.Column<string>(maxLength: 500, nullable: true),
                    LegalDayOff = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAttachments",
                columns: table => new
                {
                    FileName = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    FileId = table.Column<int>(maxLength: 20, nullable: true),
                    URLOnly = table.Column<string>(maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    FileSize = table.Column<int>(maxLength: 20, nullable: false),
                    Type = table.Column<int>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAttachments", x => x.FileName);
                    table.ForeignKey(
                        name: "FK_EmployeeAttachments_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCertificates",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    Provider = table.Column<string>(maxLength: 50, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Notes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCertificates", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EmployeeCertificates_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEducations",
                columns: table => new
                {
                    DegreeId = table.Column<int>(maxLength: 30, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    Department = table.Column<string>(maxLength: 50, nullable: true),
                    Degree = table.Column<string>(maxLength: 50, nullable: true),
                    Institution = table.Column<string>(maxLength: 50, nullable: true),
                    StillStudying = table.Column<string>(maxLength: 50, nullable: true),
                    Notes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    Thesis = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    EntranceDate = table.Column<DateTime>(type: "date", nullable: true),
                    GraduationDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEducations", x => x.DegreeId);
                    table.ForeignKey(
                        name: "FK_EmployeeEducations_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeEmergencyCalls",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    SurName = table.Column<string>(maxLength: 50, nullable: true),
                    RelationTo = table.Column<string>(maxLength: 50, nullable: true),
                    Phone = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEmergencyCalls", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EmployeeEmergencyCalls_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLanguages",
                columns: table => new
                {
                    Language = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    WrittenLevel = table.Column<int>(maxLength: 50, nullable: true),
                    SpeakingLevel = table.Column<int>(maxLength: 50, nullable: true),
                    NativeLang = table.Column<string>(maxLength: 50, nullable: true),
                    LanguageId = table.Column<int>(maxLength: 25, nullable: false),
                    Notes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLanguages", x => x.Language);
                    table.ForeignKey(
                        name: "FK_EmployeeLanguages_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjects",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    Start = table.Column<DateTime>(type: "date", nullable: true),
                    Finish = table.Column<DateTime>(type: "date", nullable: true),
                    Completed = table.Column<string>(maxLength: 60, nullable: true),
                    JobPosition = table.Column<string>(maxLength: 30, nullable: true),
                    ProjectId = table.Column<int>(maxLength: 20, nullable: false),
                    Notes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjects", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EmployeeProjects_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeQuits",
                columns: table => new
                {
                    ApproverId = table.Column<int>(maxLength: 20, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    ProcessBegin = table.Column<DateTime>(type: "date", nullable: true),
                    ProcessEnd = table.Column<DateTime>(type: "date", nullable: true),
                    CHRAdvance = table.Column<string>(maxLength: 60, nullable: true),
                    TrainingCancel = table.Column<string>(maxLength: 50, nullable: true),
                    HealthInsurance = table.Column<string>(maxLength: 50, nullable: true),
                    CHRNotes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    CompanyIdCard = table.Column<string>(maxLength: 20, nullable: true),
                    PC = table.Column<string>(maxLength: 50, nullable: true),
                    Monitor = table.Column<string>(maxLength: 50, nullable: true),
                    PhoneHeadSet = table.Column<string>(maxLength: 30, nullable: true),
                    CioNotes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    CreditCard = table.Column<string>(maxLength: 30, nullable: true),
                    GSMCard = table.Column<string>(maxLength: 50, nullable: true),
                    CompanyVehicle = table.Column<string>(maxLength: 50, nullable: true),
                    VehicleEntryStamp = table.Column<string>(maxLength: 60, nullable: true),
                    BookKeepingAdvance = table.Column<string>(maxLength: 30, nullable: true),
                    BANotes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    Multinet = table.Column<string>(maxLength: 50, nullable: true),
                    Quit = table.Column<bool>(nullable: false),
                    QuitDate = table.Column<DateTime>(type: "date", nullable: true),
                    QuitReason = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    MailSent = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeQuits", x => x.ApproverId);
                    table.ForeignKey(
                        name: "FK_EmployeeQuits_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTechnicalSkills",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    Level = table.Column<int>(maxLength: 30, nullable: true),
                    Notes = table.Column<string>(type: "ntext", maxLength: 500, nullable: true),
                    SkillId = table.Column<int>(maxLength: 30, nullable: false),
                    LevelId = table.Column<int>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTechnicalSkills", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EmployeeTechnicalSkills_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTrainings",
                columns: table => new
                {
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    EmployeeId = table.Column<int>(maxLength: 30, nullable: true),
                    Location = table.Column<string>(maxLength: 50, nullable: true),
                    Duration = table.Column<string>(maxLength: 50, nullable: true),
                    Provider = table.Column<string>(maxLength: 60, nullable: true),
                    Start = table.Column<DateTime>(type: "date", nullable: true),
                    Finish = table.Column<DateTime>(type: "date", nullable: true),
                    Notes = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTrainings", x => x.Name);
                    table.ForeignKey(
                        name: "FK_EmployeeTrainings_Employees",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttachments_EmployeeId",
                table: "EmployeeAttachments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeCertificates_EmployeeId",
                table: "EmployeeCertificates",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEducations_EmployeeId",
                table: "EmployeeEducations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeEmergencyCalls_EmployeeId",
                table: "EmployeeEmergencyCalls",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLanguages_EmployeeId",
                table: "EmployeeLanguages",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjects_EmployeeId",
                table: "EmployeeProjects",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeQuits_EmployeeId",
                table: "EmployeeQuits",
                column: "EmployeeId",
                unique: true,
                filter: "[EmployeeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTechnicalSkills_EmployeeId",
                table: "EmployeeTechnicalSkills",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTrainings_EmployeeId",
                table: "EmployeeTrainings",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EmployeeAttachments");

            migrationBuilder.DropTable(
                name: "EmployeeCertificates");

            migrationBuilder.DropTable(
                name: "EmployeeEducations");

            migrationBuilder.DropTable(
                name: "EmployeeEmergencyCalls");

            migrationBuilder.DropTable(
                name: "EmployeeLanguages");

            migrationBuilder.DropTable(
                name: "EmployeeProjects");

            migrationBuilder.DropTable(
                name: "EmployeeQuits");

            migrationBuilder.DropTable(
                name: "EmployeeTechnicalSkills");

            migrationBuilder.DropTable(
                name: "EmployeeTrainings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
