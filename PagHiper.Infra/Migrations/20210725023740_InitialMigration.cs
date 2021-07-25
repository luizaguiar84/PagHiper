using Microsoft.EntityFrameworkCore.Migrations;

namespace PagHiper.Infra.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boletos",
                columns: table => new
                {
                    order_id = table.Column<string>(type: "TEXT", nullable: false),
                    apiKey = table.Column<string>(type: "TEXT", nullable: true),
                    payer_email = table.Column<string>(type: "TEXT", nullable: true),
                    payer_name = table.Column<string>(type: "TEXT", nullable: true),
                    payer_cpf_cnpj = table.Column<string>(type: "TEXT", nullable: true),
                    payer_phone = table.Column<string>(type: "TEXT", nullable: true),
                    payer_street = table.Column<string>(type: "TEXT", nullable: true),
                    payer_number = table.Column<string>(type: "TEXT", nullable: true),
                    payer_complement = table.Column<string>(type: "TEXT", nullable: true),
                    payer_district = table.Column<string>(type: "TEXT", nullable: true),
                    payer_city = table.Column<string>(type: "TEXT", nullable: true),
                    payer_state = table.Column<string>(type: "TEXT", nullable: true),
                    payer_zip_code = table.Column<string>(type: "TEXT", nullable: true),
                    notification_url = table.Column<string>(type: "TEXT", nullable: true),
                    discount_cents = table.Column<string>(type: "TEXT", nullable: true),
                    shipping_price_cents = table.Column<string>(type: "TEXT", nullable: true),
                    shipping_methods = table.Column<string>(type: "TEXT", nullable: true),
                    fixed_description = table.Column<bool>(type: "INTEGER", nullable: false),
                    days_due_date = table.Column<string>(type: "TEXT", nullable: true),
                    type_bank_slip = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletos", x => x.order_id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    item_id = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    quantity = table.Column<string>(type: "TEXT", nullable: true),
                    price_cents = table.Column<string>(type: "TEXT", nullable: true),
                    Boleto_OrderId = table.Column<string>(type: "TEXT", nullable: true),
                    Boletoorder_id = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.item_id);
                    table.ForeignKey(
                        name: "FK_Item_Boletos_Boletoorder_id",
                        column: x => x.Boletoorder_id,
                        principalTable: "Boletos",
                        principalColumn: "order_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_Boletoorder_id",
                table: "Item",
                column: "Boletoorder_id");
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
