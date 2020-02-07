using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Migrations
{
    public partial class v30 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Producto_ProductoID",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Usuario_UsuarioID",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Categorias_CategoriaID",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Producto_Subcategoria_SubcategoriaID",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_Subcategoria_Categorias_CategoriaID",
                table: "Subcategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subcategoria",
                table: "Subcategoria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compra",
                table: "Compra");

            migrationBuilder.RenameTable(
                name: "Usuario",
                newName: "usuarios");

            migrationBuilder.RenameTable(
                name: "Subcategoria",
                newName: "subcategorias");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Productos");

            migrationBuilder.RenameTable(
                name: "Compra",
                newName: "Compras");

            migrationBuilder.RenameIndex(
                name: "IX_Subcategoria_CategoriaID",
                table: "subcategorias",
                newName: "IX_subcategorias_CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_SubcategoriaID",
                table: "Productos",
                newName: "IX_Productos_SubcategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Producto_CategoriaID",
                table: "Productos",
                newName: "IX_Productos_CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_UsuarioID",
                table: "Compras",
                newName: "IX_Compras_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_ProductoID",
                table: "Compras",
                newName: "IX_Compras_ProductoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subcategorias",
                table: "subcategorias",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productos",
                table: "Productos",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compras",
                table: "Compras",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Deseos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(nullable: true),
                    ProductoID = table.Column<int>(nullable: true),
                    fecha = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deseos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Deseos_Productos_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Productos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Deseos_usuarios_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "usuarios",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioNuevo = table.Column<string>(nullable: true),
                    VentaNueva = table.Column<string>(nullable: true),
                    VisitaNueva = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Slides",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Ruta = table.Column<string>(nullable: true),
                    orden = table.Column<int>(nullable: false),
                    fecha = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slides", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deseos_ProductoID",
                table: "Deseos",
                column: "ProductoID");

            migrationBuilder.CreateIndex(
                name: "IX_Deseos_UsuarioID",
                table: "Deseos",
                column: "UsuarioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Productos_ProductoID",
                table: "Compras",
                column: "ProductoID",
                principalTable: "Productos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_usuarios_UsuarioID",
                table: "Compras",
                column: "UsuarioID",
                principalTable: "usuarios",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Categorias_CategoriaID",
                table: "Productos",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_subcategorias_SubcategoriaID",
                table: "Productos",
                column: "SubcategoriaID",
                principalTable: "subcategorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_subcategorias_Categorias_CategoriaID",
                table: "subcategorias",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Productos_ProductoID",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_usuarios_UsuarioID",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Categorias_CategoriaID",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_subcategorias_SubcategoriaID",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_subcategorias_Categorias_CategoriaID",
                table: "subcategorias");

            migrationBuilder.DropTable(
                name: "Deseos");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "Slides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subcategorias",
                table: "subcategorias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productos",
                table: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compras",
                table: "Compras");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "Usuario");

            migrationBuilder.RenameTable(
                name: "subcategorias",
                newName: "Subcategoria");

            migrationBuilder.RenameTable(
                name: "Productos",
                newName: "Producto");

            migrationBuilder.RenameTable(
                name: "Compras",
                newName: "Compra");

            migrationBuilder.RenameIndex(
                name: "IX_subcategorias_CategoriaID",
                table: "Subcategoria",
                newName: "IX_Subcategoria_CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_SubcategoriaID",
                table: "Producto",
                newName: "IX_Producto_SubcategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Productos_CategoriaID",
                table: "Producto",
                newName: "IX_Producto_CategoriaID");

            migrationBuilder.RenameIndex(
                name: "IX_Compras_UsuarioID",
                table: "Compra",
                newName: "IX_Compra_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Compras_ProductoID",
                table: "Compra",
                newName: "IX_Compra_ProductoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuario",
                table: "Usuario",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subcategoria",
                table: "Subcategoria",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compra",
                table: "Compra",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Producto_ProductoID",
                table: "Compra",
                column: "ProductoID",
                principalTable: "Producto",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Usuario_UsuarioID",
                table: "Compra",
                column: "UsuarioID",
                principalTable: "Usuario",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Categorias_CategoriaID",
                table: "Producto",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producto_Subcategoria_SubcategoriaID",
                table: "Producto",
                column: "SubcategoriaID",
                principalTable: "Subcategoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subcategoria_Categorias_CategoriaID",
                table: "Subcategoria",
                column: "CategoriaID",
                principalTable: "Categorias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
