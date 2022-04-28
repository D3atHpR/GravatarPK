using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravatarPK.Tests;

[TestClass]
public class GravatarExtensionTest
{
    
    [TestCategory("Gravatar Tests")]
    [TestMethod(displayName:"Should validate Gravatar Extension")]
    [DataRow(data1: null, false)]
    [DataRow("", false)]
    [DataRow(" ", false)]
    [DataRow("a@a", false)]
    [DataRow("a@an.com", false)]
    [DataRow("dexsh103@outlook.com", true)]
    
    public void ShouldValidateGravatar(string email, bool status)
    {
        var result = "https://www.gravatar.com/avatar/39d98b3918e609ae6134f7b05dd3bd2b";
        Assert.AreEqual((email.ToGravatarPK() == result), status);
    }
}

