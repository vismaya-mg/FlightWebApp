using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Flightcreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flightname = table.Column<string>(name: "Flight_name", type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Flightdescriptiom = table.Column<string>(name: "Flight_descriptiom", type: "nvarchar(70)", maxLength: 70, nullable: true),
                    FlightType = table.Column<int>(name: "Flight_Type", type: "int", nullable: false),
                    flighttotalcapacity = table.Column<string>(name: "flight_total_capacity", type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
