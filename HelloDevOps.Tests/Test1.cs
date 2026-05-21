using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloDevOps.Tests;

[TestClass]
public class Test1
{
    [TestMethod]
    public void Test_OnePlusOne_IsTwo()
    {
        int result = 1 + 1;
        Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Test_StringNotEmpty()
    {
        string message = "Hello DevOps";
        Assert.IsFalse(string.IsNullOrEmpty(message));
    }
}