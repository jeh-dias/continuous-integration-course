using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousIntegrationCourse;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ContinuosIntegrationCourse;

[TestClass]
public class Tests
{
    [TestMethod]
    public void Test_Soma_Success()
    {
        var soma = new Soma();
        var result = soma.soma(10, 5);

        Assert.AreEqual(15, result);
    }

}