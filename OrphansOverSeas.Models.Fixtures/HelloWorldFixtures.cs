using NUnit.Framework;

namespace OrphansOverSeas.Models.Fixtures
{
    [TestFixture]
    public class HelloWorldFixtures
    {
        [Test]
        public void HelloWorldModelTest()
        {
            var helloWorldModel = new HelloWorldModel();

            Assert.AreEqual("HelloWorld", helloWorldModel.HelloWorld);
        }
    }
}
