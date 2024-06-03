using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BussinessObjects.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoDoctors = table.Column<int>(type: "int", nullable: false),
                    NoStaffs = table.Column<int>(type: "int", nullable: false),
                    PrivateFacility = table.Column<bool>(type: "bit", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "ServicePrices",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceLevel = table.Column<int>(type: "int", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePrices", x => x.ServiceId);
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilityId", "FacilityName", "Level", "NoDoctors", "NoStaffs", "PrivateFacility" },
                values: new object[,]
                {
                    { 1, "Green Valley Hospital", 4, 50, 200, true },
                    { 2, "Sunrise Health Center", 2, 30, 120, false },
                    { 3, "Lakeside Clinic", 1, 20, 80, true },
                    { 4, "Downtown Medical Center", 2, 40, 150, false },
                    { 5, "Riverside Hospital", 4, 60, 250, true },
                    { 6, "Mountainview Health Facility", 2, 25, 90, false },
                    { 7, "Oceanview Clinic", 5, 15, 60, true },
                    { 8, "City Central Hospital", 1, 55, 230, false },
                    { 9, "Hilltop Medical Center", 5, 35, 140, true },
                    { 10, "Valley View Hospital", 3, 45, 190, false }
                });

            migrationBuilder.InsertData(
                table: "ServicePrices",
                columns: new[] { "ServiceId", "ServiceLevel", "ServiceName", "ServicePrice" },
                values: new object[,]
                {
                    { 1, 1, "General Consultation", 50.00m },
                    { 2, 1, "Basic Health Checkup", 75.00m },
                    { 3, 2, "Specialist Consultation", 120.00m },
                    { 4, 2, "Advanced Health Checkup", 150.00m },
                    { 5, 3, "Emergency Care", 200.00m },
                    { 6, 3, "Surgical Procedure", 500.00m },
                    { 7, 4, "Inpatient Care", 1000.00m },
                    { 8, 4, "Intensive Care", 2000.00m },
                    { 9, 5, "Specialized Surgery", 5000.00m },
                    { 10, 5, "Comprehensive Health Package", 10000.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "ServicePrices");
        }
    }
}
