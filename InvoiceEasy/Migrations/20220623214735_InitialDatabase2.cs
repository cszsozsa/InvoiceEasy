using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceEasy.Migrations
{
    public partial class InitialDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItemModel_Invoices_InvoiceModelid",
                table: "InvoiceItemModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_PersonModel_buyerid",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_PersonModel_sellerid",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonModel_CompanyModel_companyid",
                table: "PersonModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonModel",
                table: "PersonModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItemModel",
                table: "InvoiceItemModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyModel",
                table: "CompanyModel");

            migrationBuilder.RenameTable(
                name: "PersonModel",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "InvoiceItemModel",
                newName: "InvoiceItems");

            migrationBuilder.RenameTable(
                name: "CompanyModel",
                newName: "Companies");

            migrationBuilder.RenameIndex(
                name: "IX_PersonModel_companyid",
                table: "Persons",
                newName: "IX_Persons_companyid");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItemModel_InvoiceModelid",
                table: "InvoiceItems",
                newName: "IX_InvoiceItems_InvoiceModelid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceModelid",
                table: "InvoiceItems",
                column: "InvoiceModelid",
                principalTable: "Invoices",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Persons_buyerid",
                table: "Invoices",
                column: "buyerid",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Persons_sellerid",
                table: "Invoices",
                column: "sellerid",
                principalTable: "Persons",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Companies_companyid",
                table: "Persons",
                column: "companyid",
                principalTable: "Companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_Invoices_InvoiceModelid",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Persons_buyerid",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Persons_sellerid",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Companies_companyid",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceItems",
                table: "InvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "PersonModel");

            migrationBuilder.RenameTable(
                name: "InvoiceItems",
                newName: "InvoiceItemModel");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "CompanyModel");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_companyid",
                table: "PersonModel",
                newName: "IX_PersonModel_companyid");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceItems_InvoiceModelid",
                table: "InvoiceItemModel",
                newName: "IX_InvoiceItemModel_InvoiceModelid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonModel",
                table: "PersonModel",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceItemModel",
                table: "InvoiceItemModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyModel",
                table: "CompanyModel",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItemModel_Invoices_InvoiceModelid",
                table: "InvoiceItemModel",
                column: "InvoiceModelid",
                principalTable: "Invoices",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_PersonModel_buyerid",
                table: "Invoices",
                column: "buyerid",
                principalTable: "PersonModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_PersonModel_sellerid",
                table: "Invoices",
                column: "sellerid",
                principalTable: "PersonModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonModel_CompanyModel_companyid",
                table: "PersonModel",
                column: "companyid",
                principalTable: "CompanyModel",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
