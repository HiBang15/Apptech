using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HospitalName = table.Column<string>(maxLength: 100, nullable: true),
                    DecisionMaker = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    Phone = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 8, nullable: false),
                    Services = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "HospitalDetails",
                columns: table => new
                {
                    HospitalDetailsId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HospitalId = table.Column<int>(nullable: false),
                    HospitalsHospitalId = table.Column<int>(nullable: true),
                    Available = table.Column<int>(nullable: false),
                    Unavailable = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalDetails", x => x.HospitalDetailsId);
                    table.ForeignKey(
                        name: "FK_HospitalDetails_Hospitals_HospitalsHospitalId",
                        column: x => x.HospitalsHospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalDetails_HospitalsHospitalId",
                table: "HospitalDetails",
                column: "HospitalsHospitalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalDetails");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
