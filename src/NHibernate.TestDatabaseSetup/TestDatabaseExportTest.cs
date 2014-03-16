using Moq;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace NHibernate.TestDatabaseSetup
{
    [TestFixture]
    public class TestDatabaseExportTest
    {
        [Test]
        public void shouldCallSchemaExportCreateWithConfiguration()
        {
            var mock = new Mock<TestDatabaseExport>();
            var calls = 0;
            mock.Setup(export => export.GetSchemaExport()).Callback(() => calls++);
            
        }
    }
}