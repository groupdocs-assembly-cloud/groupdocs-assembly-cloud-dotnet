// --------------------------------------------------------------------------------------------------------------------
// <copyright company="GroupDocs" file="PostAssembleDocumentRequest.cs">
//   Copyright (c) 2018 GroupDocs.Assembly for Cloud
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
  /// <summary>
  /// Request model for <see cref="GroupDocs.Assembly.Cloud.Sdk.Api.AssemblyApi.PostAssembleDocument" /> operation.
  /// </summary>  
  public class PostAssembleDocumentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAssembleDocumentRequest"/> class.
        /// </summary>        
        public PostAssembleDocumentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAssembleDocumentRequest"/> class.
        /// </summary>
        /// <param name="name">Template file name on a storage.</param>
        /// <param name="folder">Template folder name on a storage.</param>
        /// <param name="destFileName">Report file name</param>
        /// <param name="data">Report data</param>
        /// <param name="saveOptions">saveOptions</param>
        public PostAssembleDocumentRequest(string name, string folder = null, string destFileName = null, System.IO.Stream data = null, LoadSaveOptionsData saveOptions = null)             
        {
            this.Name = name;
            this.Folder = folder;
            this.DestFileName = destFileName;
            this.Data = data;
            this.SaveOptions = saveOptions;
        }

        /// <summary>
        /// Template file name on a storage.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Template folder name on a storage.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Report file name
        /// </summary>  
        public string DestFileName { get; set; }

        /// <summary>
        /// Report data
        /// </summary>  
        public System.IO.Stream Data { get; set; }

        /// <summary>
        /// Save options
        /// </summary>
        public LoadSaveOptionsData SaveOptions { get; set; }
  }
}
