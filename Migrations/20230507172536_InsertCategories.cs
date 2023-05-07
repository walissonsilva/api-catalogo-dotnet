using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class InsertCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO categories(name, imageUrl) VALUES('Bebida', 'bebidas.jpg')"
            );
            migrationBuilder.Sql(
                "INSERT INTO categories(name, imageUrl) VALUES('Lanches', 'lanches.jpg')"
            );
            migrationBuilder.Sql(
                "INSERT INTO categories(name, imageUrl) VALUES('Sobremesas', 'sobremesas.jpg')"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categories");
        }
    }
}
