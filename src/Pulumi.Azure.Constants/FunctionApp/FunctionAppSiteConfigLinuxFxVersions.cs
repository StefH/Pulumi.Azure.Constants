// ReSharper disable once CheckNamespace
namespace Pulumi.Azure.Constants
{
    /// <summary>
    /// Linux App Framework and version for the AppService, e.g. `DOCKER|mcr.microsoft.com/azure-functions/dotnet:3.0`.
    /// </summary>
    public static class FunctionAppSiteConfigLinuxFxVersions
    {
        public const string DotNetV2 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:2.0";

        public const string DotNetV3 = "DOCKER|mcr.microsoft.com/azure-functions/dotnet:3.0";

        public const string NodeV2 = "DOCKER|mcr.microsoft.com/azure-functions/node:2.0";

        public const string PowerShellV2 = "DOCKER|mcr.microsoft.com/azure-functions/powershell:2.0";

        public const string PythonV2 = "DOCKER|mcr.microsoft.com/azure-functions/python:2.0";
    }
}