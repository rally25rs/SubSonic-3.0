using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubSonic.DataProviders;

namespace SubSonic.Tests.Repositories
{
    public class OracleAutoCollectionTests : AutoCollectionTests
    {
        public OracleAutoCollectionTests() :
        base(ProviderFactory.GetProvider(TestConfiguration.OracleTestConnectionString, DbClientTypeName.Oracle))
        {}
    }
}
