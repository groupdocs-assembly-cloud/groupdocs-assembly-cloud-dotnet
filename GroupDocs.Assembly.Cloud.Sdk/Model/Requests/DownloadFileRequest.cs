// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DownloadFileRequest.cs">
//   Copyright (c) 2020 GroupDocs.Assembly for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GroupDocs.Assembly.Cloud.Sdk.Model.Requests 
{
  using System.Collections.Generic;
  using GroupDocs.Assembly.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Assembly.Cloud.Sdk.Api.AssemblyApi.DownloadFile" /> operation.
  /// </summary>  
  public class DownloadFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFileRequest"/> class.
        /// </summary>        
        public DownloadFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFileRequest"/> class.
        /// </summary>
        /// <param name="argPath">Path of the file including the file name and extension e.g. /folder1/file.ext</param>
        /// <param name="argStorageName">Storage name</param>
        /// <param name="argVersionId">File version ID to download</param>
        public DownloadFileRequest(string argPath, string argStorageName = null, string argVersionId = null)             
        {
            this.Path = argPath;
            this.StorageName = argStorageName;
            this.VersionId = argVersionId;
        }

        /// <summary>
        /// Path of the file including the file name and extension e.g. /folder1/file.ext
        /// </summary>  
        public string Path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string StorageName { get; set; }

        /// <summary>
        /// File version ID to download
        /// </summary>  
        public string VersionId { get; set; }
  }
}
