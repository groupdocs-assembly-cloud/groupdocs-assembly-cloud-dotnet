namespace GroupDocs.Assembly.Cloud.Sdk.Test.Base
{
    using System.IO;

    using GroupDocs.Assembly.Cloud.Sdk.Api;
    using GroupDocs.Storage.Cloud.Sdk.Api;
    using GroupDocs.Storage.Cloud.Sdk.Model.Requests;

    using Newtonsoft.Json;

    /// <summary>
    /// Base class for all tests
    /// </summary>
    public abstract class BaseTestContext
    {
        protected static readonly string LocalTestDataFolder = DirectoryHelper.GetRootSdkFolder() + "/TestData/";
        private readonly Keys keys;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        protected BaseTestContext()
        {
            // To run tests with your own credentials please substitute code bellow with this one
            // this.keys = new Keys { AppKey = "your app key", AppSid = "your app sid" };
            var serverCreds = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Settings", "servercreds.json");
            this.keys = JsonConvert.DeserializeObject<Keys>(File.ReadAllText(serverCreds));
            if (this.keys == null)
            {
                throw new FileNotFoundException("servercreds.json doesn't contain AppKey and AppSid");
            }

            var configuration = new Configuration { ApiBaseUrl = this.keys.BaseUrl, AppKey = this.keys.AppKey, AppSid = this.keys.AppSid, DebugMode = true };
            this.AssemblyApi = new AssemblyApi(configuration);
            this.StorageApi = new StorageApi(new Storage.Cloud.Sdk.Configuration { AppKey = this.AppKey, AppSid = this.AppSid, ApiBaseUrl = this.BaseProductUri, DebugMode = true });
        }

        /// <summary>
        /// Base path to test data        
        /// </summary>
        protected static string RemoteBaseTestDataFolder
        {
            get
            {
                return "Temp/SdkTests/TestData";
            }
        }

        /// <summary>
        /// Base path to output data
        /// </summary>
        protected static string BaseTestOutPath
        {
            get
            {
                return "TestOut";
            }
        }

        /// <summary>
        /// Storage API
        /// </summary>
        protected StorageApi StorageApi { get; set; }

        /// <summary>
        /// Words API
        /// </summary>
        protected AssemblyApi AssemblyApi { get; set; }

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppSid
        {
            get
            {
                return this.keys.AppSid;
            }
        }

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppKey
        {
            get
            {
                return this.keys.AppKey;
            }
        }

        /// <summary>
        /// Base Url for tests
        /// </summary>
        protected string BaseProductUri
        {
            get
            {
                return this.keys.BaseUrl;
            }
        }

        /// <summary>
        /// Returns test data path
        /// </summary>
        /// <param name="subfolder">subfolder for specific tests</param>
        /// <returns>test data path</returns>
        protected static string GetDataDir(string subfolder = null)
        {
            return Path.Combine(LocalTestDataFolder, string.IsNullOrEmpty(subfolder) ? string.Empty : subfolder);
        }

        /// <summary>
        /// Uploads file to storage.
        /// </summary>
        /// <param name="path">Path in storage.</param>
        /// <param name="versionId">Api version.</param>
        /// <param name="storage">Storage.</param>
        /// <param name="fileContent">File content.</param>
        protected void UploadFileToStorage(string path, string versionId, string storage, byte[] fileContent)
        {
            using (var ms = new MemoryStream(fileContent))
            {
                var request = new PutCreateRequest(path, ms);
                this.StorageApi.PutCreate(request);
            }
        }

        private class Keys
        {
            public string AppSid { get; set; }

            public string AppKey { get; set; }

            public string BaseUrl { get; set; }
        }
    }
}