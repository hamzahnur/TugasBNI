using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class migrasipertama : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_M_Item",
                columns: table => new
                {
                    IdItem = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stok = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Item", x => x.IdItem);
                });

            migrationBuilder.CreateTable(
                name: "Tb_M_Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tb_M_Customer",
                columns: table => new
                {
                    IdCustomer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Customer", x => x.IdCustomer);
                    table.ForeignKey(
                        name: "FK_Tb_M_Customer_Tb_M_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Tb_M_Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_M_Account",
                columns: table => new
                {
                    IdCustomer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_M_Account", x => x.IdCustomer);
                    table.ForeignKey(
                        name: "FK_Tb_M_Account_Tb_M_Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Tb_M_Customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_T_Transcation",
                columns: table => new
                {
                    IdTransaction = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdCustomer = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdItem = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateTranscation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_T_Transcation", x => x.IdTransaction);
                    table.ForeignKey(
                        name: "FK_Tb_T_Transcation_Tb_M_Customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "Tb_M_Customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_T_Transcation_Tb_M_Item_IdItem",
                        column: x => x.IdItem,
                        principalTable: "Tb_M_Item",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_M_Customer_RoleID",
                table: "Tb_M_Customer",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_T_Transcation_IdCustomer",
                table: "Tb_T_Transcation",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_T_Transcation_IdItem",
                table: "Tb_T_Transcation",
                column: "IdItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_M_Account");

            migrationBuilder.DropTable(
                name: "Tb_T_Transcation");

            migrationBuilder.DropTable(
                name: "Tb_M_Customer");

            migrationBuilder.DropTable(
                name: "Tb_M_Item");

            migrationBuilder.DropTable(
                name: "Tb_M_Role");
        }
    }
}
