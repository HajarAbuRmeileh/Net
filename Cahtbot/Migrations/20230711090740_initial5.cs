using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cahtbot.Migrations
{
    /// <inheritdoc />
    public partial class initial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    logistics_interface = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_digest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    partner_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    from_code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    msg_type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    msg_id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packages");
        }
    }
}
