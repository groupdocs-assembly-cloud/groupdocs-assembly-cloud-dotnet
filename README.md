# GroupDocs.Assembly.Cloud.Sdk - the C# library for the GroupDocs.Assembly for Cloud API References
This repository contains GroupDocs.Assembly Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Assembly Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

See [API Reference](https://apireference.groupdocs.cloud/) for full API specification.

## How to use the SDK?
The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/GroupDocs.Assembly-Cloud/) (recommended).

### Prerequisites

To use GroupDocs.Assembly for Cloud .NET SDK you need to register an account with [GroupDocs Cloud](https://www.groupdocs.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.groupdocs.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.groupdocs.cloud/pricing).

### Installation

#### Install roupDocs.Assembly-Cloud via NuGet

From the command line:

	nuget install GroupDocs.Assembly-Cloud

From Package Manager:

	PM> Install-Package GroupDocs.Assembly-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "GroupDocs.Assembly-Cloud".
5. Click on the GroupDocs.Assembly-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage

The examples below show how your application have to assemble document using GroupDocs.Assembly-Cloud library:
```csharp
var assemblyApi = new AssemblyApi(AppKey, AppSid);
var dataName = "FileWithData.json";
var data = new MemoryStream(File.ReadAllBytes(Path.Combine(LocalTestDataFolder, dataName)));
var request = new PostAssembleDocumentRequest(
                fileName,
                Path.Combine("Path/To/Document/On/Storage"), null, data);            
var documentStream = this.AssemblyApi.PostAssembleDocument(request);
```

[Tests](GroupDocs.Assembly.Cloud.Sdk.Test) contain examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)
