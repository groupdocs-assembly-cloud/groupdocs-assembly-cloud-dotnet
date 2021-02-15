// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AssemblyApi.cs">
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

namespace GroupDocs.Assembly.Cloud.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Assembly.Cloud.Sdk;
    using GroupDocs.Assembly.Cloud.Sdk.Model;
    using GroupDocs.Assembly.Cloud.Sdk.Model.Requests;
    using GroupDocs.Assembly.Cloud.Sdk.RequestHandlers;
    
    /// <summary>
    /// GroupDocs.Assembly for Cloud API.
    /// </summary>
    public class AssemblyApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public AssemblyApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssemblyApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public AssemblyApi(Configuration configuration)
        {
            if (string.IsNullOrEmpty(configuration.AppKey?.Trim()))
            {
                throw new ArgumentException("AppKey configuration value must be non-empty string");
            }

            if (string.IsNullOrEmpty(configuration.AppSid?.Trim()))
            {
                throw new ArgumentException("AppSid configuration value must be non-empty string");
            }

            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Builds a document using document template and XML or JSON data passed in request. 
        /// </summary>
        /// <param name="request">Request. <see cref="AssembleDocumentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream AssembleDocument(AssembleDocumentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/assemble";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var postBody = SerializationHelper.Serialize(request.AssembleOptions); // http body (model) parameter
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "POST", 
                    postBody, 
                null, 
                null);
        }

        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>         
        public void CopyFile(CopyFileRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/file/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>         
        public void CopyFolder(CopyFolderRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>         
        public void CreateFolder(CreateFolderRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>         
        public void DeleteFile(DeleteFileRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>         
        public void DeleteFolder(DeleteFolderRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.Recursive);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "DELETE", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "GET", 
                    null, 
                null, 
                null);
        }

        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>         
        public FilesList GetFilesList(GetFilesListRequest request)
        {
           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (FilesList)SerializationHelper.Deserialize(response, typeof(FilesList));
            }
                    
            return null;
        }

        /// <summary>
        /// Retrieves list of supported file formats. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetSupportedFileFormatsRequest" /></param>
        /// <returns><see cref="FileFormatsResponse"/></returns>         
        public FileFormatsResponse GetSupportedFileFormats(GetSupportedFileFormatsRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/formats";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "GET", 
                null, 
                null, 
                null);
            if (response != null)
            {
                return (FileFormatsResponse)SerializationHelper.Deserialize(response, typeof(FileFormatsResponse));
            }
                    
            return null;
        }

        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>         
        public void MoveFile(MoveFileRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/file/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>         
        public void MoveFolder(MoveFolderRequest request)
        {
           // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/folder/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                null);
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>         
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
           // verify the required parameter 'fileContent' is set
            if (request.FileContent == null) 
            {
                throw new ApiException(400, "Missing required parameter 'fileContent' when calling UploadFile");
            }

           // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            if (request.FileContent != null) 
            {
                formParams.Add("fileContent", this.apiInvoker.ToFileInfo(request.FileContent, "FileContent"));
            }
            
            var response = this.apiInvoker.InvokeApi(
                resourcePath, 
               "PUT", 
                null, 
                null, 
                formParams);
            if (response != null)
            {
                return (FilesUploadResult)SerializationHelper.Deserialize(response, typeof(FilesUploadResult));
            }
                    
            return null;
        }
    }
}
