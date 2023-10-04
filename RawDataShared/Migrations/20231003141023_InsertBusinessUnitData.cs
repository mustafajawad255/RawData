using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RawData.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InsertBusinessUnitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO BusinessUnit (BusinessUnitID,Name) Values(1,'BU1');" +
                                 "INSERT INTO BusinessUnit (BusinessUnitID,Name) Values(2,'BU2');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
