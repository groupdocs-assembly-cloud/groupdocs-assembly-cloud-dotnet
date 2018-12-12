namespace GroupDocs.Assembly.Cloud.Sdk.Test.Api
{
    using System.IO;

    using GroupDocs.Assembly.Cloud.Sdk.Model.Requests;
    using GroupDocs.Assembly.Cloud.Sdk.Test.Base;

    using NUnit.Framework;

    /// <summary>
    /// Class for testing Assembly for Cloud
    /// </summary>
    [TestFixture]
    public class AssemblyApiTests : BaseTestContext
    {
        [Test]
        public void TestPostAssembleDocument()
        {
            var fileName = "TestAllChartTypes.docx";
            var dataName = "Teams.json";
            var data = new MemoryStream(File.ReadAllBytes(Path.Combine(LocalTestDataFolder, dataName)));
            this.UploadFileToStorage(Path.Combine(RemoteBaseTestDataFolder, "GroupDocs.Assembly", fileName), null, null, File.ReadAllBytes(Path.Combine(LocalTestDataFolder, fileName)));

            var request = new PostAssembleDocumentRequest(
                fileName,
                Path.Combine(RemoteBaseTestDataFolder, "GroupDocs.Assembly"), null, data);
            var result = this.AssemblyApi.PostAssembleDocument(request);

            Assert.IsTrue(result.Length > 0, "Error occurred while assemble document");
        }
    }
}