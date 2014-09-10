using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OrphansOverSeas.Models.Fixtures
{
    [TestFixture]
    public class CountryFixture
    {
        [Test]
        public void CountryTest()
        {
            var country = new Country();
            country.Name = "usa";
            Assert.AreEqual("USA", country.Name);
        }
    }
}
