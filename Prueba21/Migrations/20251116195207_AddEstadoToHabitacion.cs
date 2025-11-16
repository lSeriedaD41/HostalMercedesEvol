using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba21.Migrations
{
    /// <inheritdoc />
    public partial class AddEstadoToHabitacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Habitaciones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 1,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 2,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 3,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 4,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 5,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 6,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 7,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 8,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 9,
                column: "Estado",
                value: "Disponible");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 10,
                column: "Estado",
                value: "Disponible");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "Habitaciones",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 1,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 2,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 3,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 4,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 5,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 6,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 7,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 8,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 9,
                column: "Estado",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "HabitacionId",
                keyValue: 10,
                column: "Estado",
                value: 0);
        }
    }
}
