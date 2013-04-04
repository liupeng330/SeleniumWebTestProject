using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AFPWebTest.TestUtilities;
using AFPWebTest.TestFramework;

namespace AFPWebTest.TestCases
{
    public class AFPWebTestBase: TestBase
    {
        protected AFPWebTestHelper AFPWebTestHelper;

        public override void OnTestInitialize()
        {
            base.OnTestInitialize();
            AFPWebTestHelper = Get<AFPWebTestHelper>();
        }
    }
}
