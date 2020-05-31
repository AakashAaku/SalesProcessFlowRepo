using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DSP.Data.Migrations
{
    public partial class Add_All_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ITN_OINV",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvoiceType = table.Column<string>(maxLength: 20, nullable: true),
                    PANVATNumber = table.Column<string>(maxLength: 20, nullable: true),
                    CustomerName = table.Column<string>(maxLength: 200, nullable: false),
                    CustomerCode = table.Column<string>(maxLength: 20, nullable: false),
                    Branch = table.Column<string>(maxLength: 30, nullable: false),
                    ReferenceNo = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 20, nullable: false),
                    DocumentNo = table.Column<string>(maxLength: 4, nullable: false),
                    Status = table.Column<string>(maxLength: 20, nullable: true),
                    Postingdate = table.Column<DateTime>(nullable: true),
                    ContactPerson = table.Column<string>(maxLength: 20, nullable: true),
                    DocumentOwner = table.Column<string>(maxLength: 30, nullable: true),
                    TotalBeforeDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(maxLength: 30, nullable: true),
                    BaseEntry = table.Column<string>(maxLength: 30, nullable: true),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountReturn = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    DeletedFlag = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_OINV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITN_OPDN",
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
                    ReceivedDate = table.Column<DateTime>(nullable: true),
                    ContactPerson = table.Column<string>(maxLength: 20, nullable: true),
                    DocumentOwner = table.Column<string>(maxLength: 30, nullable: true),
                    TotalBeforeDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Remarks = table.Column<string>(maxLength: 200, nullable: true),
                    BaseEntry = table.Column<string>(maxLength: 30, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    DeletedFlag = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_OPDN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ITN_ORPD",
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
                    BaseEntry = table.Column<string>(maxLength: 30, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    DeletedFlag = table.Column<string>(maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_ORPD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    LicensesId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false),
                    License = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.LicensesId);
                });

            migrationBuilder.CreateTable(
                name: "VendorCustomer",
                columns: table => new
                {
                    VendorsCustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: false),
                    GroupCode = table.Column<string>(nullable: false),
                    ContactPerson = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PANVAT = table.Column<string>(nullable: true),
                    ContractNo = table.Column<string>(nullable: false),
                    EmailId = table.Column<string>(nullable: true),
                    ShipToAddress = table.Column<string>(nullable: true),
                    BillToAddress = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorCustomer", x => x.VendorsCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "ITN_INV1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ITN_OINVID = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(maxLength: 200, nullable: false),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxCode = table.Column<string>(maxLength: 10, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Warehouse = table.Column<string>(maxLength: 20, nullable: false),
                    BaseQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 150, nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    DeletedFlag = table.Column<string>(maxLength: 2, nullable: true),
                    SERIAL_NO = table.Column<int>(nullable: false),
                    BATCH_NO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_INV1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITN_INV1_ITN_OINV_ITN_OINVID",
                        column: x => x.ITN_OINVID,
                        principalTable: "ITN_OINV",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITN_PDN1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ITN_OPDNID = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(maxLength: 200, nullable: false),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false),
                    RequestedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DamagedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxCode = table.Column<string>(maxLength: 10, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Warehouse = table.Column<string>(maxLength: 20, nullable: false),
                    ReturnQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    SoldQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 150, nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    DeletedFlag = table.Column<string>(maxLength: 2, nullable: true),
                    SERIAL_NO = table.Column<int>(nullable: false),
                    BATCH_NO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_PDN1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITN_PDN1_ITN_OPDN_ITN_OPDNID",
                        column: x => x.ITN_OPDNID,
                        principalTable: "ITN_OPDN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITN_RPD1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ITN_ORPDID = table.Column<int>(nullable: false),
                    ItemDescription = table.Column<string>(maxLength: 200, nullable: false),
                    ItemCode = table.Column<string>(maxLength: 20, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DamagedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxCode = table.Column<string>(maxLength: 10, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Warehouse = table.Column<string>(maxLength: 20, nullable: false),
                    BaseLine = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 150, nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 150, nullable: true),
                    DeletedFlag = table.Column<string>(maxLength: 2, nullable: true),
                    SERIAL_NO = table.Column<int>(nullable: false),
                    BATCH_NO = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITN_RPD1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITN_RPD1_ITN_ORPD_ITN_ORPDID",
                        column: x => x.ITN_ORPDID,
                        principalTable: "ITN_ORPD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DspUsers",
                columns: table => new
                {
                    DspUsersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    SAPBranch = table.Column<string>(nullable: false),
                    BranchCode = table.Column<string>(nullable: false),
                    Warehouse = table.Column<string>(nullable: false),
                    WarehouseCode = table.Column<string>(nullable: false),
                    CustomerCode = table.Column<string>(nullable: false),
                    VendorCustomerVendorsCustomerId = table.Column<int>(nullable: false),
                    VendorCode = table.Column<string>(nullable: false),
                    ContactNo = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    LicenseAssignLicensesId = table.Column<int>(nullable: true),
                    LicenseAvailablity = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true),
                    Approver = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DspUsers", x => x.DspUsersId);
                    table.ForeignKey(
                        name: "FK_DspUsers_Licenses_LicenseAssignLicensesId",
                        column: x => x.LicenseAssignLicensesId,
                        principalTable: "Licenses",
                        principalColumn: "LicensesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DspUsers_VendorCustomer_VendorCustomerVendorsCustomerId",
                        column: x => x.VendorCustomerVendorsCustomerId,
                        principalTable: "VendorCustomer",
                        principalColumn: "VendorsCustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DspUsers_LicenseAssignLicensesId",
                table: "DspUsers",
                column: "LicenseAssignLicensesId");

            migrationBuilder.CreateIndex(
                name: "IX_DspUsers_VendorCustomerVendorsCustomerId",
                table: "DspUsers",
                column: "VendorCustomerVendorsCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ITN_INV1_ITN_OINVID",
                table: "ITN_INV1",
                column: "ITN_OINVID");

            migrationBuilder.CreateIndex(
                name: "IX_ITN_PDN1_ITN_OPDNID",
                table: "ITN_PDN1",
                column: "ITN_OPDNID");

            migrationBuilder.CreateIndex(
                name: "IX_ITN_RPD1_ITN_ORPDID",
                table: "ITN_RPD1",
                column: "ITN_ORPDID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DspUsers");

            migrationBuilder.DropTable(
                name: "ITN_INV1");

            migrationBuilder.DropTable(
                name: "ITN_PDN1");

            migrationBuilder.DropTable(
                name: "ITN_RPD1");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "VendorCustomer");

            migrationBuilder.DropTable(
                name: "ITN_OINV");

            migrationBuilder.DropTable(
                name: "ITN_OPDN");

            migrationBuilder.DropTable(
                name: "ITN_ORPD");
        }
    }
}
