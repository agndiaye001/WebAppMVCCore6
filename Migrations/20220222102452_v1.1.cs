using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCCore6.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantite",
                table: "Produit",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "prix",
                table: "Produit",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "tel",
                table: "Client",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "adresseVille",
                table: "Client",
                newName: "adressCity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Produit",
                newName: "quantite");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Produit",
                newName: "prix");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Client",
                newName: "tel");

            migrationBuilder.RenameColumn(
                name: "adressCity",
                table: "Client",
                newName: "adresseVille");
        }
    }
}
