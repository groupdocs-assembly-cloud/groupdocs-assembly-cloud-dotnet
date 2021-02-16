# GroupDocs.Assembly.Cloud.Sdk - the C# library for the GroupDocs.Assembly for Cloud API References
This repository contains GroupDocs.Assembly Cloud SDK for .NET source code. This SDK allows you to work with GroupDocs.Assembly Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

See [API Reference](https://apireference.groupdocs.cloud/) for full API specification.

# Key Features
* API to Define Templates, Fetch Data Source, Insert Data in Template & Generate on the fly Reports.

## How to use the SDK?
The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/GroupDocs.Assembly-Cloud/) (recommended).

### Prerequisites

To use GroupDocs.Assembly for Cloud .NET SDK you need to register an account with [GroupDocs Cloud](https://www.groupdocs.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.groupdocs.cloud/applications). There is free quota available. For more details, see [GroupDocs Cloud Pricing](https://purchase.groupdocs.cloud/pricing).

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
#### Test running
Before run tests please fill file [servercreds.json](Settings/servercreds.json) with this json
```json
{
    "AppSid": "your app sid here",
    "AppKey": "your app key here",
    "BaseUrl": "https://api.groupdocs.cloud"
}
```

The examples below show how your application have to assemble document using GroupDocs.Assembly-Cloud library:
```csharp
var fileName = "Template.docx";
var dataName = "JsonData.json";
var data = File.ReadAllText(Path.Combine(pathToData));
var saveOptions = new AssembleOptions() { SaveFormat = "pdf", ReportData = data, TemplateFileInfo = new TemplateFileInfo { FilePath = pathToFile } };

var request = new AssembleDocumentRequest(saveOptions);
var result = this.AssemblyApi.AssembleDocument(request);
```

[Tests](GroupDocs.Assembly.Cloud.Sdk.Test) contain examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Contact Us
[Product Page](https://products.groupdocs.cloud/assembly/net) | [Documentation](https://docs.groupdocs.cloud/display/assemblycloud/Home) | [API Reference](https://apireference.groupdocs.cloud/assembly/) | [Code Samples](https://github.com/groupdocs-assembly-cloud/groupdocs-assembly-cloud-net) | [Blog](https://blog.groupdocs.cloud/category/assembly/) | [Free Support](https://forum.groupdocs.cloud/c/assembly) | [Free Trial](https://dashboard.groupdocs.cloud/applications)
