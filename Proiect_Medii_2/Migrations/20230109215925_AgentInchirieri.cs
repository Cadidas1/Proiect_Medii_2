using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect_Medii_2.Migrations
{
    public partial class AgentInchirieri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgentInchirieri",
                table: "Masina");

            migrationBuilder.AddColumn<int>(
                name: "AgentInchirieriID",
                table: "Masina",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AgentInchirieri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentInchirieri", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Masina_AgentInchirieriID",
                table: "Masina",
                column: "AgentInchirieriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Masina_AgentInchirieri_AgentInchirieriID",
                table: "Masina",
                column: "AgentInchirieriID",
                principalTable: "AgentInchirieri",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Masina_AgentInchirieri_AgentInchirieriID",
                table: "Masina");

            migrationBuilder.DropTable(
                name: "AgentInchirieri");

            migrationBuilder.DropIndex(
                name: "IX_Masina_AgentInchirieriID",
                table: "Masina");

            migrationBuilder.DropColumn(
                name: "AgentInchirieriID",
                table: "Masina");

            migrationBuilder.AddColumn<string>(
                name: "AgentInchirieri",
                table: "Masina",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
