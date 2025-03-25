using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karooooo.DriverPlanning.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CopydriverobjectfromAccessManagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "DriverUid",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "VehicleType",
                table: "Driver",
                newName: "UserId");

            migrationBuilder.AlterTable(
                name: "Driver")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "Driver_History")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "hist")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Driver",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "Driver",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Driver",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Bank",
                table: "Driver",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BranchCode",
                table: "Driver",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "CanSeeEarnings",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAtUtc",
                table: "Driver",
                type: "datetime2(2)",
                precision: 2,
                nullable: false,
                defaultValueSql: "(getutcdate())");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Driver",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DriversLicenseExpiryDate",
                table: "Driver",
                type: "date",
                precision: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fleet",
                table: "Driver",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Driver",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "IdentificationExpiryDate",
                table: "Driver",
                type: "date",
                precision: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentificationNumber",
                table: "Driver",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdentificationType",
                table: "Driver",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActivated",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsForeignNational",
                table: "Driver",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Labels",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Driver",
                type: "varchar(60)",
                unicode: false,
                maxLength: 60,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodEnd",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:TemporalIsPeriodEndColumn", true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodStart",
                table: "Driver",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:TemporalIsPeriodStartColumn", true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneModel",
                table: "Driver",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileUrl",
                table: "Driver",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Race",
                table: "Driver",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Driver",
                type: "char(43)",
                unicode: false,
                fixedLength: true,
                maxLength: 43,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UniqueDeviceIdentifier",
                table: "Driver",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAtUtc",
                table: "Driver",
                type: "datetime2(2)",
                precision: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Driver",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "V2VehicleId",
                table: "Driver",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleColour",
                table: "Driver",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "VehicleLicenseExpiryDate",
                table: "Driver",
                type: "date",
                precision: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleLicensePlateNumber",
                table: "Driver",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleMake",
                table: "Driver",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleModel",
                table: "Driver",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehiclePhotoBackUrl",
                table: "Driver",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehiclePhotoFrontUrl",
                table: "Driver",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehiclePhotoSideUrl",
                table: "Driver",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleVinNumber",
                table: "Driver",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Driver",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormattedAddress = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Suburb = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Latitude = table.Column<decimal>(type: "decimal(8,5)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(8,5)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UnitNr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Complex = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StreetNr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2(2)", precision: 2, nullable: false, defaultValueSql: "(getutcdate())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAtUtc = table.Column<DateTime>(type: "datetime2(2)", precision: 2, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:TemporalIsPeriodEndColumn", true),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:TemporalIsPeriodStartColumn", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "Address_History")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "hist")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatsAppNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirebaseUid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultBusinessId = table.Column<int>(type: "int", nullable: true),
                    IsSuperUser = table.Column<bool>(type: "bit", nullable: false),
                    CreatedFromSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestAuthTimestampUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LatestAuthAs = table.Column<int>(type: "int", nullable: true),
                    TimeZoneOffset = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SuperUserAccessLevelId = table.Column<short>(type: "smallint", nullable: true),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsSystemAdministrator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Driver_AddressId",
                table: "Driver",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_VendorId",
                table: "Driver",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "UC_Driver_Uid",
                table: "Driver",
                column: "Uid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UC_Driver_UserId",
                table: "Driver",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Address_AddressId",
                table: "Driver",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Vendor_VendorId",
                table: "Driver",
                column: "VendorId",
                principalTable: "Vendor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_dbo_Driver_UserId",
                table: "Driver",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Address_AddressId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Vendor_VendorId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_dbo_Driver_UserId",
                table: "Driver");

            migrationBuilder.DropTable(
                name: "Address")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "Address_History")
                .Annotation("SqlServer:TemporalHistoryTableSchema", "hist")
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Driver_AddressId",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "IX_Driver_VendorId",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "UC_Driver_Uid",
                table: "Driver");

            migrationBuilder.DropIndex(
                name: "UC_Driver_UserId",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Bank",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "BranchCode",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CanSeeEarnings",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CreatedAtUtc",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "DriversLicenseExpiryDate",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Fleet",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IdentificationExpiryDate",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IdentificationNumber",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IdentificationType",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IsActivated",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "IsForeignNational",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Labels",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "PeriodEnd",
                table: "Driver")
                .Annotation("SqlServer:TemporalIsPeriodEndColumn", true);

            migrationBuilder.DropColumn(
                name: "PeriodStart",
                table: "Driver")
                .Annotation("SqlServer:TemporalIsPeriodStartColumn", true);

            migrationBuilder.DropColumn(
                name: "PhoneModel",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "ProfileUrl",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "UniqueDeviceIdentifier",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "UpdatedAtUtc",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "V2VehicleId",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehicleColour",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehicleLicenseExpiryDate",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehicleLicensePlateNumber",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehicleMake",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehicleModel",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehiclePhotoBackUrl",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehiclePhotoFrontUrl",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehiclePhotoSideUrl",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VehicleVinNumber",
                table: "Driver");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Driver",
                newName: "VehicleType");

            migrationBuilder.AlterTable(
                name: "Driver")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "Driver_History")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", "hist")
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddColumn<Guid>(
                name: "DriverUid",
                table: "Driver",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Driver",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "DriverUid");
        }
    }
}
