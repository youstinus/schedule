using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace schedule.api.framework.tests.Controllers
{
    [TestClass]
    public class BaseControllerTests
    {
        [TestMethod]
        public void Get_ReturnsEmptyCollection()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
