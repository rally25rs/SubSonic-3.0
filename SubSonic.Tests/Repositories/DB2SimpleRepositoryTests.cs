using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubSonic.DataProviders;

namespace SubSonic.Tests.Repositories
{
    public class DB2SimpleRepositoryTests : SimpleRepositoryTests
    {
      public DB2SimpleRepositoryTests() :
            base(ProviderFactory.GetProvider(TestConfiguration.DB2TestConnectionString, DbClientTypeName.DB2))
        {
        }
    }
}
