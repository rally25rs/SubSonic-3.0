using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubSonic.DataProviders;

namespace SubSonic.Tests.Repositories
{
    public class DB2AutoCollectionTests : AutoCollectionTests
    {
      public DB2AutoCollectionTests() :
        base(ProviderFactory.GetProvider(TestConfiguration.DB2TestConnectionString, DbClientTypeName.DB2))
        {}
    }
}
