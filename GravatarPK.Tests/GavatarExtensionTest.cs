using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GravatarPK.Tests;

[TestClass]
public class GravatarExtensionTest
{
    
    [TestCategory("Gravatar Tests")]
    [TestMethod(displayName:"Should validate Gravatar Extension")]
    [DataRow(data1: null, false)]
    [DataRow("", 200, false)]
    [DataRow(" ", 200, false)]
    [DataRow("a@a", 200, false)]
    [DataRow("a@an.com", 200, false)]
    [DataRow("dexsh103@outlook.com", null, true)]
    [DataRow("dexsh103@outlook.com", 200, true)]
    
    public void ShouldValidateGravatar(string email, int? size, bool status)
    {   
        var imagemSize = size.HasValue ? size.Value.ToString() : "80";
        var result = "https://www.gravatar.com/avatar/39d98b3918e609ae6134f7b05dd3bd2b?s={imageSize}";
        Assert.AreEqual((email.ToGravatarPK(size ?? 80) == result), status);
    }
}

