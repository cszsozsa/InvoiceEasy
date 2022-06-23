using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InvoiceEasy.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyModel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    phoneNumber = table.Column<string>(type: "text", nullable: false),
                    registrationNumber = table.Column<int>(type: "integer", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PersonModel",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    firstName = table.Column<string>(type: "text", nullable: false),
                    lastName = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    companyid = table.Column<int>(type: "integer", nullable: false),
                    phoneNumber = table.Column<int>(type: "integer", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonModel", x => x.id);
                    table.ForeignKey(
                        name: "FK_PersonModel_CompanyModel_companyid",
                        column: x => x.companyid,
                        principalTable: "CompanyModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    uniqueNumber = table.Column<int>(type: "integer", nullable: false),
                    sellerid = table.Column<int>(type: "integer", nullable: false),
                    buyerid = table.Column<int>(type: "integer", nullable: false),
                    issueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    paymentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    deliveryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    paymentMethod = table.Column<string>(type: "text", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.id);
                    table.ForeignKey(
                        name: "FK_Invoices_PersonModel_buyerid",
                        column: x => x.buyerid,
                        principalTable: "PersonModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoices_PersonModel_sellerid",
                        column: x => x.sellerid,
                        principalTable: "PersonModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceItemModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    cost = table.Column<decimal>(type: "numeric", nullable: false),
                    isActive = table.Column<bool>(type: "boolean", nullable: false),
                    InvoiceModelid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceItemModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceItemModel_Invoices_InvoiceModelid",
                        column: x => x.InvoiceModelid,
                        principalTable: "Invoices",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceItemModel_InvoiceModelid",
                table: "InvoiceItemModel",
                column: "InvoiceModelid");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_buyerid",
                table: "Invoices",
                column: "buyerid");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_sellerid",
                table: "Invoices",
                column: "sellerid");

            migrationBuilder.CreateIndex(
                name: "IX_PersonModel_companyid",
                table: "PersonModel",
                column: "companyid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceItemModel");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "PersonModel");

            migrationBuilder.DropTable(
                name: "CompanyModel");
        }
    }
}
