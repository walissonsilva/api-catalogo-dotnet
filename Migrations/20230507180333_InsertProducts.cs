using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class InsertProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,ImageUrl,Inventory,RegistrationDate,categoryId) VALUES('Coca Cola Zero', 'Refrigerante de Cola 350 ml', 5.45, 'coca-cola.jpg', 50, now(), 1)"
            );
            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,ImageUrl,Inventory,RegistrationDate,categoryId) VALUES('Lanche de Atum', 'Lanche de Atum com Maionese', 8.50, 'atum.jpg', 10, now(), 2)"
            );
            migrationBuilder.Sql(
                "INSERT INTO Products(Name,Description,Price,ImageUrl,Inventory,RegistrationDate,categoryId) VALUES('Pudim 100g', 'Pudim de Leite Condensado 100g', 6.75, 'pudim.jpg', 20, now(), 3)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
