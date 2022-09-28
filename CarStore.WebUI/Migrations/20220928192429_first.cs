using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarStore.WebUI.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Body_Type",
                columns: table => new
                {
                    body_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Body_Typ__5DC6EDB60A71CA35", x => x.body_type);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    brand_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Brand__0C0C3B5910D68796", x => x.brand_name);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    customer_surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phone_number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    facebook_link = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "Fuel_Type",
                columns: table => new
                {
                    fuel_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fuel_Typ__D2CA04354606B6F1", x => x.fuel_type);
                });

            migrationBuilder.CreateTable(
                name: "Transmission_Type",
                columns: table => new
                {
                    transmission_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Transmis__99F9313D4AF84CB6", x => x.transmission_type);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    model_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    brand_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    body_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    transmission_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    fuel_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Car__5DD3F6BAF8D20AEF", x => x.model_name);
                    table.ForeignKey(
                        name: "FK__Car__body_type__2D27B809",
                        column: x => x.body_type,
                        principalTable: "Body_Type",
                        principalColumn: "body_type");
                    table.ForeignKey(
                        name: "FK__Car__brand_name__2C3393D0",
                        column: x => x.brand_name,
                        principalTable: "Brand",
                        principalColumn: "brand_name");
                    table.ForeignKey(
                        name: "FK__Car__fuel_type__2F10007B",
                        column: x => x.fuel_type,
                        principalTable: "Fuel_Type",
                        principalColumn: "fuel_type");
                    table.ForeignKey(
                        name: "FK__Car__transmissio__2E1BDC42",
                        column: x => x.transmission_type,
                        principalTable: "Transmission_Type",
                        principalColumn: "transmission_type");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    customer_id = table.Column<int>(type: "int", nullable: false),
                    delivery_address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    addit_info = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.order_id);
                    table.ForeignKey(
                        name: "FK__Orders__customer__34C8D9D1",
                        column: x => x.customer_id,
                        principalTable: "Customer",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Orders__model_na__33D4B598",
                        column: x => x.model_name,
                        principalTable: "Car",
                        principalColumn: "model_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_body_type",
                table: "Car",
                column: "body_type");

            migrationBuilder.CreateIndex(
                name: "IX_Car_brand_name",
                table: "Car",
                column: "brand_name");

            migrationBuilder.CreateIndex(
                name: "IX_Car_fuel_type",
                table: "Car",
                column: "fuel_type");

            migrationBuilder.CreateIndex(
                name: "IX_Car_transmission_type",
                table: "Car",
                column: "transmission_type");

            migrationBuilder.CreateIndex(
                name: "IX_Order_customer_id",
                table: "Order",
                column: "customer_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_model_name",
                table: "Order",
                column: "model_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Body_Type");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Fuel_Type");

            migrationBuilder.DropTable(
                name: "Transmission_Type");
        }
    }
}
