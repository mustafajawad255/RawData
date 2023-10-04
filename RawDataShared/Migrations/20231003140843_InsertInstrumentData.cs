using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RawData.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InsertInstrumentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Instrument (InstrumentID,Name) Values(1,'Bond');" +
                                 "INSERT INTO Instrument (InstrumentID,Name) Values(2,'CDS');" +
                                 "INSERT INTO Instrument (InstrumentID,Name) Values(3,'Equity');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
