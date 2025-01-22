using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMeter.Data.Migrations
{
    /// <inheritdoc />
    public partial class ParkingModelEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSlots_Payment_PaymentId",
                table: "ParkSlots");

            migrationBuilder.DropForeignKey(
                name: "FK_ParkSlots_Status_StatusId",
                table: "ParkSlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Vehicles_Payment",
                table: "Payment");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_ParkSlots_StatusId",
                table: "ParkSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "ParkSlots");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_Payment",
                table: "Payments",
                newName: "IX_Payments_Payment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Parkings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkSlotId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parkings_ParkSlots_ParkSlotId",
                        column: x => x.ParkSlotId,
                        principalTable: "ParkSlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkingPayment",
                columns: table => new
                {
                    ParkingsId = table.Column<int>(type: "int", nullable: false),
                    PaymentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingPayment", x => new { x.ParkingsId, x.PaymentsId });
                    table.ForeignKey(
                        name: "FK_ParkingPayment_Parkings_ParkingsId",
                        column: x => x.ParkingsId,
                        principalTable: "Parkings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParkingPayment_Payments_PaymentsId",
                        column: x => x.PaymentsId,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParkingVehicle",
                columns: table => new
                {
                    ParkingsId = table.Column<int>(type: "int", nullable: false),
                    VehiclesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingVehicle", x => new { x.ParkingsId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_ParkingVehicle_Parkings_ParkingsId",
                        column: x => x.ParkingsId,
                        principalTable: "Parkings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParkingVehicle_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkingPayment_PaymentsId",
                table: "ParkingPayment",
                column: "PaymentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Parkings_ParkSlotId",
                table: "Parkings",
                column: "ParkSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingVehicle_VehiclesId",
                table: "ParkingVehicle",
                column: "VehiclesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSlots_Payments_PaymentId",
                table: "ParkSlots",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Vehicles_Payment",
                table: "Payments",
                column: "Payment",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParkSlots_Payments_PaymentId",
                table: "ParkSlots");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Vehicles_Payment",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "ParkingPayment");

            migrationBuilder.DropTable(
                name: "ParkingVehicle");

            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_Payment",
                table: "Payment",
                newName: "IX_Payment_Payment");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "ParkSlots",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParkSlots_StatusId",
                table: "ParkSlots",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSlots_Payment_PaymentId",
                table: "ParkSlots",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ParkSlots_Status_StatusId",
                table: "ParkSlots",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Vehicles_Payment",
                table: "Payment",
                column: "Payment",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
