using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DSP.Data.Migrations
{
    public partial class TablesAddedonDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ITN_OPRO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    VendorName = table.Column<string>(maxLength: 200, nullable: false),
                    VendorCode = table.Column<string>(maxLength: 20, nullable: false),
                    Branch = table.Column<string>(maxLength: 30, nullable: false),
                    ReferenceNo = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    DocumentNo = table.Column<string>(maxLength: 4, nullable: false),
                    Status = table.Column<string>(maxLength: 20, nullable: true),
                    PostingDate = table.Column<DateTime>(nullable: true),
                    ContactPerson = table.Column<string>(maxLength: 20, nullable: true),
                    DocumentOwner = table.Column<string>(maxLength: 30, nullable: true),
                    TotalBeforeDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(maxLength: 30, nullable: true),
                    PORefNo = table.Column<string>(nullable: true),
                    SORefNo = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedFlag = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_OPRO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITN_PRO1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ITN_PROID = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(maxLength: 200, nullable: false),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedQty = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxCode = table.Column<string>(maxLength: 10, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Warehouse = table.Column<string>(maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    DeletedFlag = table.Column<string>(nullable: true),
                    SERIAL_NO = table.Column<int>(nullable: false),
                    BATCH_NO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_PRO1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ITN_OPRO");

            migrationBuilder.DropTable(
                name: "ITN_PRO1");
        }
    }
}
