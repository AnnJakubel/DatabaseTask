using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class CompanyDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitleHistories",
                columns: table => new
                {
                    JobTitleHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitleStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobTitleDurationInDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitleHistories", x => x.JobTitleHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "Hints",
                columns: table => new
                {
                    HintId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HintContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HintSubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HintStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hints", x => x.HintId);
                    table.ForeignKey(
                        name: "FK_Hints_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitleHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialSecurityNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractEndingDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_JobTitleHistories_JobTitleHistoryId",
                        column: x => x.JobTitleHistoryId,
                        principalTable: "JobTitleHistories",
                        principalColumn: "JobTitleHistoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeChildrenConnections",
                columns: table => new
                {
                    ConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeChildrenConnections", x => x.ConnectionId);
                    table.ForeignKey(
                        name: "FK_EmployeeChildrenConnections_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    PermissionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionsGrantedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionsExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionsId);
                    table.ForeignKey(
                        name: "FK_Permissions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalEvaluations",
                columns: table => new
                {
                    PhysicalEvalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhysicalEvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Limitations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AidEquipment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalEvaluations", x => x.PhysicalEvalId);
                    table.ForeignKey(
                        name: "FK_PhysicalEvaluations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalId);
                    table.ForeignKey(
                        name: "FK_Rentals_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestSubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SickLeaves",
                columns: table => new
                {
                    SickLeaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SickLeaveType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SickLeaveDurationInDays = table.Column<int>(type: "int", nullable: false),
                    SickLeaveStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SickLeaveEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SickLeaves", x => x.SickLeaveId);
                    table.ForeignKey(
                        name: "FK_SickLeaves_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    VacationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VacationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VacationDurationInDays = table.Column<int>(type: "int", nullable: false),
                    VacationStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VacationEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.VacationId);
                    table.ForeignKey(
                        name: "FK_Vacations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    ChildId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildAgeInYears = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeChildrenConnectionConnectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.ChildId);
                    table.ForeignKey(
                        name: "FK_Children_EmployeeChildrenConnections_EmployeeChildrenConnectionConnectionId",
                        column: x => x.EmployeeChildrenConnectionConnectionId,
                        principalTable: "EmployeeChildrenConnections",
                        principalColumn: "ConnectionId");
                    table.ForeignKey(
                        name: "FK_Children_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    JobTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobTitleHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PermissionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.JobTitleId);
                    table.ForeignKey(
                        name: "FK_JobTitles_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTitles_JobTitleHistories_JobTitleHistoryId",
                        column: x => x.JobTitleHistoryId,
                        principalTable: "JobTitleHistories",
                        principalColumn: "JobTitleHistoryId");
                    table.ForeignKey(
                        name: "FK_JobTitles_Permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "Permissions",
                        principalColumn: "PermissionsId");
                });

            migrationBuilder.CreateTable(
                name: "RentalItems",
                columns: table => new
                {
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalItems", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_RentalItems_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentalItems_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "RentalId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Children_EmployeeChildrenConnectionConnectionId",
                table: "Children",
                column: "EmployeeChildrenConnectionConnectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_EmployeeId",
                table: "Children",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeChildrenConnections_EmployeeId",
                table: "EmployeeChildrenConnections",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BranchId",
                table: "Employees",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleHistoryId",
                table: "Employees",
                column: "JobTitleHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hints_BranchId",
                table: "Hints",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_BranchId",
                table: "JobTitles",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_JobTitleHistoryId",
                table: "JobTitles",
                column: "JobTitleHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_PermissionsId",
                table: "JobTitles",
                column: "PermissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_EmployeeId",
                table: "Permissions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalEvaluations_EmployeeId",
                table: "PhysicalEvaluations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalItems_BranchId",
                table: "RentalItems",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalItems_RentalId",
                table: "RentalItems",
                column: "RentalId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_EmployeeId",
                table: "Rentals",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_BranchId",
                table: "Requests",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_EmployeeId",
                table: "Requests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SickLeaves_EmployeeId",
                table: "SickLeaves",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_EmployeeId",
                table: "Vacations",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Hints");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "PhysicalEvaluations");

            migrationBuilder.DropTable(
                name: "RentalItems");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "SickLeaves");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "EmployeeChildrenConnections");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "JobTitleHistories");
        }
    }
}
