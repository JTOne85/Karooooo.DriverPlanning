using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karooooo.DriverPlanning.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DriverAddressDetils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormattedAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProofOfAddressUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverAddressDetils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverBankingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProofOfBankingDetailsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverBankingDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverLicenseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseType = table.Column<int>(type: "int", nullable: false),
                    LicenceCode = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LicenseDocumentImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicenseDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverNextOfKinDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverNextOfKinDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicleLicenseDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleRegisterNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleEngineNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LicenseDocumentImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicleLicenseDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ResidencyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidencyStatus = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResidencyDocumentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidencyDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleMake = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleColour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleBackImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleFrontImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleSideImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverVehicleLicenseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverVehicleDetails_DriverVehicleLicenseDetails_DriverVehicleLicenseId",
                        column: x => x.DriverVehicleLicenseId,
                        principalTable: "DriverVehicleLicenseDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverIdentificationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentityType = table.Column<int>(type: "int", nullable: false),
                    IsForeignNational = table.Column<bool>(type: "bit", nullable: false),
                    WorkPermit = table.Column<int>(type: "int", nullable: false),
                    ResidencyId = table.Column<int>(type: "int", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverIdentificationUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverWorkPermitUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverIdentificationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverIdentificationDetails_ResidencyDetails_ResidencyId",
                        column: x => x.ResidencyId,
                        principalTable: "ResidencyDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverIdentificationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverDetails_DriverIdentificationDetails_DriverIdentificationId",
                        column: x => x.DriverIdentificationId,
                        principalTable: "DriverIdentificationDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: true),
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DriverDetailsId = table.Column<int>(type: "int", nullable: false),
                    DriverNextOfKinId = table.Column<int>(type: "int", nullable: false),
                    DriverIdentificationId = table.Column<int>(type: "int", nullable: false),
                    DriverVehcileId = table.Column<int>(type: "int", nullable: false),
                    DriverLisenceId = table.Column<int>(type: "int", nullable: false),
                    DriverAddressId = table.Column<int>(type: "int", nullable: false),
                    DriverBankingDetailsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Driver_DriverAddressDetils_DriverAddressId",
                        column: x => x.DriverAddressId,
                        principalTable: "DriverAddressDetils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Driver_DriverBankingDetails_DriverBankingDetailsId",
                        column: x => x.DriverBankingDetailsId,
                        principalTable: "DriverBankingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Driver_DriverDetails_DriverDetailsId",
                        column: x => x.DriverDetailsId,
                        principalTable: "DriverDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Driver_DriverIdentificationDetails_DriverIdentificationId",
                        column: x => x.DriverIdentificationId,
                        principalTable: "DriverIdentificationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Driver_DriverLicenseDetails_DriverLisenceId",
                        column: x => x.DriverLisenceId,
                        principalTable: "DriverLicenseDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Driver_DriverNextOfKinDetails_DriverNextOfKinId",
                        column: x => x.DriverNextOfKinId,
                        principalTable: "DriverNextOfKinDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Driver_DriverVehicleDetails_DriverVehcileId",
                        column: x => x.DriverVehcileId,
                        principalTable: "DriverVehicleDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DriverAddressId",
                table: "Driver",
                column: "DriverAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DriverBankingDetailsId",
                table: "Driver",
                column: "DriverBankingDetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DriverDetailsId",
                table: "Driver",
                column: "DriverDetailsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DriverIdentificationId",
                table: "Driver",
                column: "DriverIdentificationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DriverLisenceId",
                table: "Driver",
                column: "DriverLisenceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DriverNextOfKinId",
                table: "Driver",
                column: "DriverNextOfKinId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Driver_DriverVehcileId",
                table: "Driver",
                column: "DriverVehcileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UC_Driver_UID",
                table: "Driver",
                column: "Uid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UC_Driver_UserId",
                table: "Driver",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverDetails_DriverIdentificationId",
                table: "DriverDetails",
                column: "DriverIdentificationId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverIdentificationDetails_ResidencyId",
                table: "DriverIdentificationDetails",
                column: "ResidencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicleDetails_DriverVehicleLicenseId",
                table: "DriverVehicleDetails",
                column: "DriverVehicleLicenseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "DriverAddressDetils");

            migrationBuilder.DropTable(
                name: "DriverBankingDetails");

            migrationBuilder.DropTable(
                name: "DriverDetails");

            migrationBuilder.DropTable(
                name: "DriverLicenseDetails");

            migrationBuilder.DropTable(
                name: "DriverNextOfKinDetails");

            migrationBuilder.DropTable(
                name: "DriverVehicleDetails");

            migrationBuilder.DropTable(
                name: "DriverIdentificationDetails");

            migrationBuilder.DropTable(
                name: "DriverVehicleLicenseDetails");

            migrationBuilder.DropTable(
                name: "ResidencyDetails");
        }
    }
}
