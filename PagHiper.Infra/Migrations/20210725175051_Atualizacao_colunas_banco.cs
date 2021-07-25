using Microsoft.EntityFrameworkCore.Migrations;

namespace PagHiper.Infra.Migrations
{
    public partial class Atualizacao_colunas_banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boletos",
                columns: table => new
                {
                    OrderId = table.Column<string>(nullable: false),
                    ApiKey = table.Column<string>(nullable: true),
                    PayerEmail = table.Column<string>(nullable: true),
                    PayerName = table.Column<string>(nullable: true),
                    PayerCpfCnpj = table.Column<string>(nullable: true),
                    PayerPhone = table.Column<string>(nullable: true),
                    PayerStreet = table.Column<string>(nullable: true),
                    PayerNumber = table.Column<string>(nullable: true),
                    PayerComplement = table.Column<string>(nullable: true),
                    PayerDistrict = table.Column<string>(nullable: true),
                    PayerCity = table.Column<string>(nullable: true),
                    PayerState = table.Column<string>(nullable: true),
                    PayerZipCode = table.Column<string>(nullable: true),
                    NotificationUrl = table.Column<string>(nullable: true),
                    DiscountCents = table.Column<string>(nullable: true),
                    ShippingPriceCents = table.Column<string>(nullable: true),
                    ShippingMethods = table.Column<string>(nullable: true),
                    FixedDescription = table.Column<bool>(nullable: false),
                    DaysDueDate = table.Column<string>(nullable: true),
                    TypeBankSlip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletos", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    PriceCents = table.Column<string>(nullable: true),
                    BoletoOrderId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Boletos_BoletoOrderId",
                        column: x => x.BoletoOrderId,
                        principalTable: "Boletos",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_BoletoOrderId",
                table: "Item",
                column: "BoletoOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Boletos");
        }
    }
}
