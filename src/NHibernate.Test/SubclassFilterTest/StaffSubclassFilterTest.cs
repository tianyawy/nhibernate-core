using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace NHibernate.Test.SubclassFilterTest
{
    [TestFixture]
    public class StaffSubclassFilterTest : TestCase
    {
        protected override IList Mappings
        {
            get { return new string[] { "SubclassFilterTest.Staff.hbm.xml" }; }
        }

        protected override string MappingsAssembly
        {
            get { return "NHibernate.Test"; }
        }

        [Test]
        public void FiltersWithSubclass()
        {
            
        }
    }
}