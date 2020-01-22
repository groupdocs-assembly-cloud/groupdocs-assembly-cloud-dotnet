// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AssemblyApi.cs">
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

namespace GroupDocs.Assembly.Cloud.Sdk
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using GroupDocs.Assembly.Cloud.Sdk;
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
        /// Builds a document using document template and XML or JSON data passed in request 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAssembleDocumentRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>         
        public System.IO.Stream PostAssembleDocument(PostAssembleDocumentRequest request)
        {
           // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostAssembleDocument");
            }

           // verify the required parameter 'data' is set
            if (request.Data == null) 
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling PostAssembleDocument");
            }

           // verify the required parameter 'saveOptions' is set
            if (request.SaveOptions == null) 
            {
                throw new ApiException(400, "Missing required parameter 'saveOptions' when calling PostAssembleDocument");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/assembly/{name}/build";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destFileName", request.DestFileName);
            
            if (request.SaveOptions != null) 
            {
                formParams.Add("saveOptions", request.SaveOptions);
            }
            
            if (request.Data != null) 
            {
                formParams.Add("data", this.apiInvoker.ToFileInfo(request.Data, "Data"));
            }
            
                    return this.apiInvoker.InvokeBinaryApi(
                    resourcePath, 
                   "POST", 
                    null, 
                null, 
                formParams);
        }
    }
}
