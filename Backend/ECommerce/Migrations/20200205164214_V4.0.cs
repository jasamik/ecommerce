using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class V40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_usuarios_UsuarioID",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Deseos_usuarios_UsuarioID",
                table: "Deseos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Usuario_UsuarioID",
                table: "Compras",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deseos_Usuario_UsuarioID",
                table: "Deseos",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Usuario_UsuarioID",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Deseos_Usuario_UsuarioID",
                table: "Deseos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "usuarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_usuarios_UsuarioID",
                table: "Compras",
                column: "UsuarioID",
                principalTable: "usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Deseos_usuarios_UsuarioID",
                table: "Deseos",
                column: "UsuarioID",
                principalTable: "usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
