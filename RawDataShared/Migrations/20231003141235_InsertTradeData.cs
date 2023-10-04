using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RawData.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InsertTradeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Trade (TradeID,InstrumentID,BusinessUnitID,ProfitCentreID,ReportingAmount) " +
                                "Values(1,1,1,1,5000);" +
                                "INSERT INTO Trade (TradeID,InstrumentID,BusinessUnitID,ProfitCentreID,ReportingAmount) " +
                                "Values(2,1,1,2,1000);" +
                                "INSERT INTO Trade (TradeID,InstrumentID,BusinessUnitID,ProfitCentreID,ReportingAmount) " +
                                "Values(3,2,1,1,5000);" +
                                "INSERT INTO Trade (TradeID,InstrumentID,BusinessUnitID,ProfitCentreID,ReportingAmount) " +
                                "Values(4,2,2,1,3000);" +
                                "INSERT INTO Trade (TradeID,InstrumentID,BusinessUnitID,ProfitCentreID,ReportingAmount) " +
                                "Values(5,3,2,3,6000);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
