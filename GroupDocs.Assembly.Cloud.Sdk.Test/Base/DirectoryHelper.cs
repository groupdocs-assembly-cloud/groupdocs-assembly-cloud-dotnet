namespace GroupDocs.Assembly.Cloud.Sdk.Test.Base
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class DirectoryHelper
    {
        /// <summary>
        /// Returns path to folder with test data
        /// </summary>
        /// <param name="parentDir">parent directory</param>
        /// <returns>path to test data folder</returns>
        public static string GetRootSdkFolder(string parentDir = null)
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);

            var info = Directory.GetParent(parentDir ?? Path.GetDirectoryName(path));
            if (info != null)
            {
                var dataFolderExists = info.GetDirectories("Settings");
                if (dataFolderExists.Any())
                {
                    return info.FullName;
                }

                return GetRootSdkFolder(info.FullName);
            }

            throw new ArgumentException("Unexpected folder structure");
        }

        /// <summary>
        /// Get Files with specified extension
        /// </summary>
        /// <param name="directoryPath">folder</param>
        /// <param name="extension">extension</param>
        /// <param name="searchOption">option</param>
        /// <returns>list of files names</returns>
        public static IEnumerable<string> GetFilesByExtension(string directoryPath, string extension, SearchOption searchOption)
        {
            return
                Directory.EnumerateFiles(directoryPath, "*" + extension, searchOption).OrderBy(x => x)
                    .Where(x => string.Equals(Path.GetExtension(x), extension, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}