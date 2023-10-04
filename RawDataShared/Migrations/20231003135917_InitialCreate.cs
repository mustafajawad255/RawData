using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RawData.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessUnit",
                columns: table => new
                {
                    BusinessUnitID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnit", x => x.BusinessUnitID);
                });

            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    InstrumentID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.InstrumentID);
                });

            migrationBuilder.CreateTable(
                name: "ProfitCentre",
                columns: table => new
                {
                    ProfitCentreID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfitCentre", x => x.ProfitCentreID);
                });

            migrationBuilder.CreateTable(
                name: "Trade",
                columns: table => new
                {
                    TradeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstrumentID = table.Column<int>(type: "INTEGER", nullable: false),
                    BusinessUnitID = table.Column<int>(type: "INTEGER", nullable: false),
                    ProfitCentreID = table.Column<int>(type: "INTEGER", nullable: false),
                    ReportingAmount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trade", x => x.TradeID);
                    table.ForeignKey(
                        name: "FK_Trade_BusinessUnit_BusinessUnitID",
                        column: x => x.BusinessUnitID,
                        principalTable: "BusinessUnit",
                        principalColumn: "BusinessUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trade_Instrument_InstrumentID",
                        column: x => x.InstrumentID,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trade_ProfitCentre_ProfitCentreID",
                        column: x => x.ProfitCentreID,
                        principalTable: "ProfitCentre",
                        principalColumn: "ProfitCentreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trade_BusinessUnitID",
                table: "Trade",
                column: "BusinessUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Trade_InstrumentID",
                table: "Trade",
                column: "InstrumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Trade_ProfitCentreID",
                table: "Trade",
                column: "ProfitCentreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trade");

            migrationBuilder.DropTable(
                name: "BusinessUnit");

            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "ProfitCentre");
        }
    }
}
