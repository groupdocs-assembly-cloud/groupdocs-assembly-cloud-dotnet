// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostAssembleDocumentRequest.cs">
//   Copyright (c) 2019 GroupDocs.Assembly for Cloud
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
        /// <param name="argName">File name of template, which is located on a storage</param>
        /// <param name="argReportData">Report Data Options. It should be JSON with SaveFormat and ReportData</param>
        /// <param name="argFolder">Folder path where template file is located(on a storage)</param>
        /// <param name="argDestFileName">Result name of built document</param>
        public PostAssembleDocumentRequest(string argName, ReportOptionsData argReportData, string argFolder = null, string argDestFileName = null)             
        {
            this.Name = argName;
            this.ReportData = argReportData;
            this.Folder = argFolder;
            this.DestFileName = argDestFileName;
        }

        /// <summary>
        /// File name of template, which is located on a storage
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Report Data Options. It should be JSON with SaveFormat and ReportData
        /// </summary>  
        public ReportOptionsData ReportData { get; set; }

        /// <summary>
        /// Folder path where template file is located(on a storage)
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Result name of built document
        /// </summary>  
        public string DestFileName { get; set; }
  }
}
