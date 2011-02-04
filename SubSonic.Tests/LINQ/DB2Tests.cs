using SubSonic.DataProviders;
using SubSonic.Tests.Linq;
using SubSonic.Tests.Linq.TestBases;
using Xunit;

namespace SubSonic.Tests.Linq
{
    public class DB2SelectTests : SelectTests
    {
        public DB2SelectTests()
        {
            _db = new TestDB(TestConfiguration.DB2TestConnectionString, DbClientTypeName.DB2);
            var setup = new Setup(_db.Provider);
            setup.DropTestTables();
            setup.CreateTestTable();
            setup.LoadTestData();
        }
    }
}
