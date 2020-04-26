// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Windows App Framework and version for the AppService.
    /// </summary>
    public static class FunctionAppSiteConfigWindowsVersions
    {
        public const string DotNetV2NanoServer1709 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0-nanoserver-1709";

        public const string DotNetV2NanoServer1803 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0-nanoserver-1803";

        public const string DotNetV2NanoServer1809 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0-nanoserver-1809";
    }
}