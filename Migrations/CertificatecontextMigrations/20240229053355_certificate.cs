using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Intern_Admin_Collaboration.Migrations.CertificatecontextMigrations
{
    public partial class certificate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certificatedetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    intern_department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    certificate_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    issue_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificatedetails", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certificatedetails");
        }
    }
}
