using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RawData.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InsertProfitCentreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ProfitCentre (ProfitCentreID,Name) Values(1,'101');" +
                                 "INSERT INTO ProfitCentre (ProfitCentreID,Name) Values(2,'103');" +
                                 "INSERT INTO ProfitCentre (ProfitCentreID,Name) Values(3,'105');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
