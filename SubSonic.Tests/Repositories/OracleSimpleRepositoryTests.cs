using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubSonic.DataProviders;

namespace SubSonic.Tests.Repositories
{
    public class OracleSimpleRepositoryTests : SimpleRepositoryTests
    {
        public OracleSimpleRepositoryTests() :
            base(ProviderFactory.GetProvider(TestConfiguration.OracleTestConnectionString, DbClientTypeName.Oracle))
        {
        }
    }
}
