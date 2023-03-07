using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProduct.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id_Produto = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome_Produto = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Unidade_Medida = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    Foto_Produto = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Id_Tipo_Produto = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id_Produto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
