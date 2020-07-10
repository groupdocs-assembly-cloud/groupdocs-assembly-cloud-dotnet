:Create folder structure
if exist c:\Build\package rmdir c:\Build\package /S /Q
mkdir c:\Build\package || goto end
mkdir c:\Build\package\lib\net20 || goto end
mkdir c:\Build\package\lib\netstandard2.0 || goto end
mkdir c:\Build\package\License || goto end

:Build a release
c:\build\.nuget\NuGet.exe restore c:\build\GroupDocs.Assembly.Cloud.Sdk.sln || goto end
msbuild c:\build\GroupDocs.Assembly.Cloud.Sdk.sln /p:Configuration=Release || goto end

:Create a strong name PE .net 2.0 library and sign it
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\ildasm" c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\net20\GroupDocs.Assembly.Cloud.Sdk.dll /out=c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.il || goto end
"C:\Windows\Microsoft.NET\Framework\v2.0.50727\ilasm" c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.il /res=c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.res /dll /key=c:\Build\Scripts\aspose.snk /out=c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end
c:\\build\tools\\signtool.exe sign /f c:\Build\Scripts\aspose.pfx /fd sha256 /p f27Hp99Ds3 /tr http://timestamp.comodoca.com/?td=sha256 /td sha256 /v c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end

:Check the strong name and the signature for .net 2.0 library
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\sn" -vf c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end
c:\\build\tools\signtool.exe verify /pa c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end

:Copy dll to package folder
copy c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll c:\Build\package\lib\net20\ || goto end

:Create a strong name PE .net standard 2.0 library and sign it
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\ildasm" c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\netstandard2.0\GroupDocs.Assembly.Cloud.Sdk.dll /out=c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.il || goto end
"C:\Windows\Microsoft.NET\Framework\v2.0.50727\ilasm" c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.il /res=c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.res /dll /key=c:\Build\Scripts\aspose.snk /out=c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end
c:\\build\tools\\signtool.exe sign /f c:\Build\Scripts\aspose.pfx /fd sha256 /p f27Hp99Ds3 /tr http://timestamp.comodoca.com/?td=sha256 /td sha256 /v c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end

:Check the strong name and the signature for .net standard 2.0 library
"C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\Bin\NETFX 4.6.1 Tools\x64\sn" -vf c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end
c:\\build\tools\signtool.exe verify /pa c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll || goto end

:Copy dll to package folder
copy c:\Build\GroupDocs.Assembly.Cloud.Sdk\bin\Release\GroupDocs.Assembly.Cloud.Sdk.dll c:\Build\package\lib\netstandard2.0\ || goto end

:Build nuget package
cd C:\build
dir
copy c:\Build\GroupDocs.Assembly.Cloud.Sdk\GroupDocs.Assembly-Cloud.nuspec c:\Build\package\ || goto end
copy c:\Build\License c:\Build\package\License || goto end
"c:\Build\.nuget\NuGet.exe" pack c:\Build\package\GroupDocs.Assembly-Cloud.nuspec -OutputDirectory c:\Build\packages  -properties version=%SDK_VERSION% || goto end

:Replace the nuget package with a new version
c:\Build\.nuget\NuGet.exe add c:\Build\packages\GroupDocs.Assembly-Cloud.%SDK_VERSION%.0.nupkg -Source c:\Build\packages || goto end
dotnet remove c:\Build\GroupDocs.Assembly.Cloud.Sdk.Test\GroupDocs.Assembly.Cloud.Sdk.Test.csproj reference ..\GroupDocs.Assembly.Cloud.Sdk\GroupDocs.Assembly.Cloud.Sdk.csproj || goto end
dotnet add c:\Build\GroupDocs.Assembly.Cloud.Sdk.Test\GroupDocs.Assembly.Cloud.Sdk.Test.csproj package GroupDocs.Assembly-Cloud -s c:\Build\packages -v %SDK_VERSION%.0 || goto end

:Build tests
c:\build\.nuget\NuGet.exe restore c:\build\GroupDocs.Assembly.Cloud.Sdk.sln || goto end
msbuild c:\build\GroupDocs.Assembly.Cloud.Sdk.sln

:end
exit /b %ERRORLEVEL%

