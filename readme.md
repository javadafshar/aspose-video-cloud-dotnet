# Aspose.Video Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.Video-Cloud.svg)](https://www.nuget.org/packages/Aspose.Video-Cloud/)
This repository contains Aspose.Video Cloud SDK for .NET source code. This SDK allows you to work with Aspose.Video Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

# Key Features
* Conversion between various document-related formats (20+ formats supported), including PDF<->Word conversion
* Mail merge and reports generation 
* Splitting Word documents
* Accessing Word document metadata and statistics
* Find and replace
* Watermarks and protection
* Full read & write access to Document Object Model, including sections, paragraphs, text, images, tables, headers/footers and many others

See [API Reference](https://apireference.aspose.cloud/Video/) for full API specification.

## How to use the SDK?
The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.Video-Cloud/) (recommended). For more details, please visit our [documentation website](https://docs.aspose.cloud/display/Videocloud/Available+SDKs#AvailableSDKs-.NET).

### Prerequisites

To use Aspose Video for Cloud .NET SDK you need to register an account with [Aspose Cloud](https://www.aspose.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.aspose.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).

### Installation

#### Install Aspose.Video-Cloud via NuGet

From the command line:

	nuget install Aspose.Video-Cloud

From Package Manager:

	PM> Install-Package Aspose.Video-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aspose.Video-Cloud".
5. Click on the Aspose.Video-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage

The examples below show how your application have to initiate and convert "avi" file to "mp4" using Aspose.Video-Cloud library:
```csharp
var VideoApi = new VideoApi(AppKey, AppSID);
ConvertOptions options = new ConvertOptions();
var request = new PostConvertVideoRequest("original.avi", "mp4", "destination.mp4, options);
VideoApi.PostConvertVideo(request);        

```

[Tests](Aspose.Video.Cloud.Sdk.Tests) contain various examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.aspose.cloud/c/Video).