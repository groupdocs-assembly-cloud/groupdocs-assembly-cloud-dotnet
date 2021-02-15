// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CopyFileRequest.cs">
//   Copyright (c) 2021 GroupDocs.Assembly for Cloud
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
  /// Request model for <see cref="GroupDocs.Assembly.Cloud.Sdk.Api.AssemblyApi.CopyFile" /> operation.
  /// </summary>  
  public class CopyFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>        
        public CopyFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopyFileRequest"/> class.
        /// </summary>
        /// <param name="argDestPath">Destination file path</param>
        /// <param name="argSrcPath">Source file&#39;s path e.g. &#39;/Folder 1/file.ext&#39; or &#39;/Bucket/Folder 1/file.ext&#39;</param>
        /// <param name="argSrcStorageName">Source storage name</param>
        /// <param name="argDestStorageName">Destination storage name</param>
        /// <param name="argVersionId">File version ID to copy</param>
        public CopyFileRequest(string argDestPath, string argSrcPath, string argSrcStorageName = null, string argDestStorageName = null, string argVersionId = null)             
        {
            this.DestPath = argDestPath;
            this.SrcPath = argSrcPath;
            this.SrcStorageName = argSrcStorageName;
            this.DestStorageName = argDestStorageName;
            this.VersionId = argVersionId;
        }

        /// <summary>
        /// Destination file path
        /// </summary>  
        public string DestPath { get; set; }

        /// <summary>
        /// Source file's path e.g. '/Folder 1/file.ext' or '/Bucket/Folder 1/file.ext'
        /// </summary>  
        public string SrcPath { get; set; }

        /// <summary>
        /// Source storage name
        /// </summary>  
        public string SrcStorageName { get; set; }

        /// <summary>
        /// Destination storage name
        /// </summary>  
        public string DestStorageName { get; set; }

        /// <summary>
        /// File version ID to copy
        /// </summary>  
        public string VersionId { get; set; }
  }
}
